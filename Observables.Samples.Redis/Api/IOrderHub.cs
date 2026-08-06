using Observables.Redis;
using R3;

namespace Observables.Samples.Redis.Api;

[Redis]
public interface IOrderHub
{
    [RedisSubscribe("samples.ping")]
    Observable<string> Ping { get; }

    [RedisPublish("samples.ping")]
    Observable<Unit> PublishPing(string payload);
}
