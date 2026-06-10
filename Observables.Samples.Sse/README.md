# Observables.Samples.Sse

Console sample for **`Observables.Sse.R3`** — declarative `[Sse]` interface proxies for Server-Sent Events.

## What it demonstrates

- `[SseEvent("price")]` named events and the default `[SseEvent]` (`message`) on `IPriceFeed`
- Typed payload deserialization (`PriceTick`) and raw `string` passthrough
- `SseService.For<IPriceFeed>(connection)` factory registration (CI runs this without a live server)

## Run

```powershell
dotnet run --project Observables.Samples.Sse
```

With a sibling Observables clone:

```powershell
dotnet run --project Observables.Samples.Sse -p:UseLocalObservables=true
```

## Live SSE (optional)

CI only checks that the source-generated factory is registered. To stream real events, point the `SseConnection` at a `text/event-stream` endpoint, then `Subscribe` to `Prices` / `Heartbeats`. Each subscription opens a fresh SSE connection. See [Observables.Docs — Sse](https://github.com/Skymly/Observables.Docs/blob/main/docs/sse.md).
