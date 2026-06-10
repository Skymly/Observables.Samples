using System;
using Observables.Sse;

namespace Observables.Samples.Sse.Reactive.Api;

public sealed record PriceTick(string Symbol, decimal Price);

[Sse]
public interface IPriceFeedReactive
{
    [SseEvent("price")]
    IObservable<PriceTick> Prices { get; }

    [SseEvent("trade")]
    IObservable<string> Trades { get; }

    [SseEvent]
    IObservable<string> Heartbeats { get; }
}
