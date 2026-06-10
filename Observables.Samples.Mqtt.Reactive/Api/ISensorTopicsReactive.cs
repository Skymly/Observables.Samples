using Observables.Mqtt;
using System.Reactive;

namespace Observables.Samples.Mqtt.Reactive.Api;

[Mqtt]
public interface ISensorTopicsReactive
{
    [MqttSubscribe("samples/ping")]
    IObservable<string> Ping { get; }

    [MqttPublish("samples/ping")]
    IObservable<Unit> PublishPing();
}
