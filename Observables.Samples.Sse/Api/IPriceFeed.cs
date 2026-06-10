using Observables.Sse;
using R3;

namespace Observables.Samples.Sse.Api;

public sealed record PriceTick(string Symbol, decimal Price);

[Sse]
public interface IPriceFeed
{
    [SseEvent("price")]
    Observable<PriceTick> Prices { get; }

    [SseEvent("trade")]
    Observable<string> Trades { get; }

    [SseEvent]
    Observable<string> Heartbeats { get; }
}
