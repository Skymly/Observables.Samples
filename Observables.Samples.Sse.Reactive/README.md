# Observables.Samples.Sse.Reactive

Console sample for **`Observables.Sse.Reactive`** — declarative `[Sse]` interface proxies returning `IObservable<T>`.

## What it demonstrates

- `[SseEvent("price")]` named events and the default `[SseEvent]` (`message`) on `IPriceFeedReactive`
- Typed payload deserialization (`PriceTick`) and raw `string` passthrough
- `SseService.For<IPriceFeedReactive>(connection)` factory registration (CI runs this without a live server)

## Run

```powershell
dotnet run --project Observables.Samples.Sse.Reactive
```

With a sibling Observables clone:

```powershell
dotnet run --project Observables.Samples.Sse.Reactive -p:UseLocalObservables=true
```

## Live SSE (optional)

CI only checks that the source-generated factory is registered. To stream real events, point the `SseConnection` at a `text/event-stream` endpoint, then `Subscribe` to `Prices` / `Heartbeats` with System.Reactive operators. See [Observables.Docs — Sse](https://github.com/Skymly/Observables.Docs/blob/main/docs/sse.md).
