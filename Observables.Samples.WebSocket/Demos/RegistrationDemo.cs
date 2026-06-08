using Observables.Samples.WebSocket.Api;
using Observables.WebSocket;

namespace Observables.Samples.WebSocket.Demos;

/// <summary>
/// Verifies source-generated WebSocket proxy registration without a live server (CI-safe).
/// </summary>
internal static class RegistrationDemo
{
    public static void Run()
    {
        Console.WriteLine("-- WebSocket proxy factory (no live server) --");
        try
        {
            _ = WebSocketService.For<IEchoHub>(null!);
            Console.WriteLine("  unexpected: null socket accepted");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine(
                "  WebSocketService.For<IEchoHub>: factory registered (ArgumentNullException on null socket)");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"  missing generated factory: {ex.Message}");
        }

        Console.WriteLine();
        Console.WriteLine(
            "  Live connect/send/receive demos need ClientWebSocket against a real endpoint; see README.md.");
    }
}
