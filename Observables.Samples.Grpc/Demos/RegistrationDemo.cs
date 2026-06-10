using Observables.Grpc;
using Observables.Samples.Grpc.Api;

namespace Observables.Samples.Grpc.Demos;

/// <summary>
/// Verifies source-generated gRPC proxy registration without a live server (CI-safe).
/// </summary>
internal static class RegistrationDemo
{
    public static void Run()
    {
        Console.WriteLine("-- gRPC proxy factory (no live server) --");
        try
        {
            _ = GrpcService.For<ISmokeHub>(null!);
            Console.WriteLine("  unexpected: null invoker accepted");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine(
                "  GrpcService.For<ISmokeHub>: factory registered (ArgumentNullException on null invoker)");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"  missing generated factory: {ex.Message}");
        }

        Console.WriteLine();
        Console.WriteLine(
            "  Live unary/streaming demos need GrpcChannel against a real endpoint; see README.md.");
    }
}
