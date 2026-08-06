using Observables.Redis;
using Observables.Samples.Redis.Api;
using StackExchange.Redis;

namespace Observables.Samples.Redis.Demos;

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
            _ = RedisService.For<IOrderHub>((IConnectionMultiplexer)null!);
            Console.WriteLine("  unexpected: null multiplexer accepted");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine(
                "  RedisService.For<IOrderHub>: factory registered (ArgumentNullException on null multiplexer)");
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
