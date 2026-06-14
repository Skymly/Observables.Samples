using Observables.Nats;
using R3;

namespace Observables.Samples.Nats.Api;

[Nats]
public interface IOrderHub
{
    [NatsSubscribe("samples.ping")]
    Observable<string> Ping { get; }

    [NatsPublish("samples.ping")]
    Observable<Unit> PublishPing();
}
