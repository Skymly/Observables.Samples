using Observables.Samples.SignalR.Api;
using Observables.SignalR;

namespace Observables.Samples.SignalR.Demos;

/// <summary>
/// Verifies source-generated hub proxy registration without a live SignalR server (CI-safe).
/// </summary>
internal static class RegistrationDemo
{
    public static void Run()
    {
        Console.WriteLine("-- Hub proxy factory (no live server) --");
        try
        {
            _ = HubService.For<IChatHub>(null!);
            Console.WriteLine("  unexpected: null connection accepted");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine(
                "  HubService.For<IChatHub>: factory registered (ArgumentNullException on null connection)");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"  missing generated factory: {ex.Message}");
        }

        Console.WriteLine();
        Console.WriteLine(
            "  Live Invoke/On demos need HubConnection.StartAsync against a real hub; see README.md.");
    }
}
