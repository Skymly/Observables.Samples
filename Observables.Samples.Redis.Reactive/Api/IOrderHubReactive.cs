using Observables.Redis;
using System.Reactive;

namespace Observables.Samples.Redis.Reactive.Api;

[Redis]
public interface IOrderHubReactive
{
    [RedisSubscribe("samples.ping")]
    IObservable<string> Ping { get; }

    [RedisPublish("samples.ping")]
    IObservable<Unit> PublishPing(string payload);
}
