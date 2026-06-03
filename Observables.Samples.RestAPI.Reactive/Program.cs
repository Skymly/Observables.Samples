using System.Net;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using Observables.RestAPI;
using Observables.Samples.RestAPI.Reactive.Api;
using Observables.Samples.RestAPI.Models;
using RichardSzalay.MockHttp;

Console.WriteLine("Observables.Samples.RestAPI.Reactive — IObservable HTTP client");
Console.WriteLine();

using var mockHttp = new MockHttpMessageHandler();
mockHttp.When(HttpMethod.Get, "https://api.example.com/users/42")
    .Respond(HttpStatusCode.OK, "application/json", """{"id":42,"name":"Ada"}""");
mockHttp.When(HttpMethod.Get, "https://api.example.com/users/7")
    .Respond(HttpStatusCode.OK, "application/json", """{"id":7,"name":"Grace"}""");
mockHttp.When(HttpMethod.Get, "https://api.example.com/users/404")
    .Respond(HttpStatusCode.NotFound);

using var client = mockHttp.ToHttpClient();
client.BaseAddress = new Uri("https://api.example.com");

var api = RestService.For<IUserApiReactive>(client);

Console.WriteLine("-- IObservable<User> (FirstAsync) --");
User observed = await api.GetUserObservable(7).FirstAsync().ToTask();
Console.WriteLine($"  GET /users/7 -> {observed.Name} (id={observed.Id})");

Console.WriteLine("-- ApiException on 404 (IObservable) --");
try
{
    _ = await api.GetUserObservable(404).FirstAsync().ToTask();
    Console.WriteLine("  unexpected success");
}
catch (ApiException ex)
{
    Console.WriteLine($"  GET /users/404 -> ApiException status={(int?)ex.StatusCode}");
}

Console.WriteLine();
Console.WriteLine("Done.");
