using System.Net;
using Observables.Samples.RestAPI.Api;
using Observables.Samples.RestAPI.Models;
using Observables.RestAPI;
using RichardSzalay.MockHttp;
using R3;

namespace Observables.Samples.RestAPI.Demos;

internal static class MockHttpDemo
{
    public static async Task RunAsync()
    {
        using var mockHttp = new MockHttpMessageHandler();
        mockHttp.When(HttpMethod.Get, "https://api.example.com/users/42")
            .Respond(HttpStatusCode.OK, "application/json", """{"id":42,"name":"Ada"}""");
        mockHttp.When(HttpMethod.Get, "https://api.example.com/users/7")
            .Respond(HttpStatusCode.OK, "application/json", """{"id":7,"name":"Grace"}""");
        mockHttp.When(HttpMethod.Get, "https://api.example.com/users")
            .Respond(HttpStatusCode.OK, "application/json",
                """[{"id":1,"name":"Ann"},{"id":2,"name":"Bob"}]""");
        mockHttp.When(HttpMethod.Get, "https://api.example.com/users/404")
            .Respond(HttpStatusCode.NotFound);

        using var client = mockHttp.ToHttpClient();
        client.BaseAddress = new Uri("https://api.example.com");

        var api = RestService.For<IUserApi>(client);

        Console.WriteLine("-- Task<User> --");
        User taskUser = await api.GetUserAsync(42);
        Console.WriteLine($"  GET /users/42 -> {taskUser.Name} (id={taskUser.Id})");

        Console.WriteLine("-- Observable<User> (FirstAsync) --");
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(5));
        User observed = await api.GetUserObservable(7).FirstAsync(cts.Token);
        Console.WriteLine($"  GET /users/7 -> {observed.Name} (id={observed.Id})");

        Console.WriteLine("-- Task<IReadOnlyList<User>> --");
        IReadOnlyList<User> users = await api.ListUsersAsync();
        Console.WriteLine($"  GET /users -> {users.Count} item(s): {string.Join(", ", users.Select(u => u.Name))}");

        Console.WriteLine("-- ApiException on 404 (Task) --");
        try
        {
            _ = await api.GetUserAsync(404);
            Console.WriteLine("  unexpected success");
        }
        catch (ApiException ex)
        {
            Console.WriteLine($"  GET /users/404 -> ApiException status={(int?)ex.StatusCode}");
        }
    }
}
