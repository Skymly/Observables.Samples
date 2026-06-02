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

        using var client = mockHttp.ToHttpClient();
        client.BaseAddress = new Uri("https://api.example.com");

        var api = RestService.For<IUserApi>(client);

        Console.WriteLine("-- Task<User> client --");
        User taskUser = await api.GetUserAsync(42);
        Console.WriteLine($"  GET /users/42 -> {taskUser.Name} (id={taskUser.Id})");

        Console.WriteLine("-- Observable<User> client (R3) --");
        User? observed = null;
        using var subscription = api.GetUserObservable(7).Subscribe(user => observed = user);

        await Task.Delay(250);
        Console.WriteLine($"  GET /users/7 -> {observed?.Name ?? "(none)"} (id={observed?.Id})");
    }
}
