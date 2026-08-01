using Observables.Postgres;
using R3;

namespace Observables.Samples.Postgres.Api;

[Postgres]
public interface IOrderHub
{
    [Listen("samples_ping")]
    Observable<string> Ping { get; }

    [Notify("samples_ping")]
    Observable<Unit> PublishPing(string payload);
}
