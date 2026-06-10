using System.Net.Http;
using Observables.Samples.Sse.Reactive.Api;
using Observables.Sse;

namespace Observables.Samples.Sse.Reactive.Demos;

/// <summary>
/// Verifies the source-generated SSE proxy registration without a live server (CI-safe).
/// </summary>
internal static class RegistrationDemo
{
    public static void Run()
    {
        Console.WriteLine("-- SSE proxy factory (no live server) --");

        var connection = new SseConnection(new HttpClient(), new Uri("https://feed.example.com/stream"));
        try
        {
            var feed = SseService.For<IPriceFeedReactive>(connection);
            Console.WriteLine($"  SseService.For<IPriceFeedReactive>: generated proxy created ({feed.GetType().Name})");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"  missing generated factory: {ex.Message}");
        }

        Console.WriteLine();
        Console.WriteLine(
            "  Live event streaming needs a real text/event-stream endpoint; see README.md.");
    }
}
