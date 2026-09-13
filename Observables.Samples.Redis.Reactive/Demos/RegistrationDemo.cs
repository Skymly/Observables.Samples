using Observables.Redis;
using Observables.Samples.Redis.Reactive.Api;
using StackExchange.Redis;

namespace Observables.Samples.Redis.Reactive.Demos;

/// <summary>
/// Verifies source-generated Pub/Sub proxy registration without a live Redis server (CI-safe when built locally).
/// </summary>
internal static class RegistrationDemo
{
    public static void Run()
    {
        Console.WriteLine("-- Redis proxy factory (no live server) --");
        try
        {
            _ = RedisService.For<IOrderHubReactive>((IConnectionMultiplexer)null!);
            Console.WriteLine("  unexpected: null multiplexer accepted");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine(
                "  RedisService.For<IOrderHubReactive>: factory registered (ArgumentNullException on null multiplexer)");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"  missing generated factory: {ex.Message}");
        }

        Console.WriteLine();
        Console.WriteLine(
            "  Live subscribe/publish demos need IConnectionMultiplexer connected to Redis; see README.md.");
    }
}
