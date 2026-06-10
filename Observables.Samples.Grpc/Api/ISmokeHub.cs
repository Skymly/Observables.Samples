using Observables.Grpc;
using R3;

namespace Observables.Samples.Grpc.Api;

[Grpc("echo.Echo")]
public interface ISmokeHub
{
    [GrpcUnary("UnaryEcho")]
    Observable<string> UnaryEcho(string request, CancellationToken cancellationToken = default);
}
