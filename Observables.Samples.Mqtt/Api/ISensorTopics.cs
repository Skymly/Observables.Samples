using Observables.Mqtt;
using R3;

namespace Observables.Samples.Mqtt.Api;

[Mqtt]
public interface ISensorTopics
{
    [MqttSubscribe("samples/ping")]
    Observable<string> Ping { get; }

    [MqttPublish("samples/ping")]
    Observable<Unit> PublishPing();
}
