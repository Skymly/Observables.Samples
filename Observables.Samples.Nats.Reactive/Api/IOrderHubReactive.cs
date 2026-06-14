using Observables.Nats;
using System.Reactive;

namespace Observables.Samples.Nats.Reactive.Api;

[Nats]
public interface IOrderHubReactive
{
    [NatsSubscribe("samples.ping")]
    IObservable<string> Ping { get; }

    [NatsPublish("samples.ping")]
    IObservable<Unit> PublishPing();
}
