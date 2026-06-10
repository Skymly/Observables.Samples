using Observables.Grpc;

namespace Observables.Samples.Grpc.Reactive.Api;

[Grpc("echo.Echo")]
public interface ISmokeHubReactive
{
    [GrpcUnary("UnaryEcho")]
    IObservable<string> UnaryEcho(string request, CancellationToken cancellationToken = default);
}
