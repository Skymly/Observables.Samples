using NATS.Client.Core;
using Observables.Nats;
using Observables.Samples.Nats.Api;

namespace Observables.Samples.Nats.Demos;

/// <summary>
/// Verifies source-generated subject proxy registration without a live NATS server (CI-safe when built locally).
/// </summary>
internal static class RegistrationDemo
{
    public static void Run()
    {
        Console.WriteLine("-- Subject proxy factory (no live server) --");
        try
        {
            _ = NatsService.For<IOrderHub>((INatsConnection)null!);
            Console.WriteLine("  unexpected: null connection accepted");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine(
                "  NatsService.For<IOrderHub>: factory registered (ArgumentNullException on null connection)");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"  missing generated factory: {ex.Message}");
        }

        Console.WriteLine();
        Console.WriteLine(
            "  Live subscribe/publish/request demos need INatsConnection connected to a server; see README.md.");
    }
}
