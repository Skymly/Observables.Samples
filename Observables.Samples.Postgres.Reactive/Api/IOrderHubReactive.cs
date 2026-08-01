using Observables.Postgres;
using System.Reactive;

namespace Observables.Samples.Postgres.Reactive.Api;

[Postgres]
public interface IOrderHubReactive
{
    [Listen("samples_ping")]
    IObservable<string> Ping { get; }

    [Notify("samples_ping")]
    IObservable<Unit> PublishPing(string payload);
}
