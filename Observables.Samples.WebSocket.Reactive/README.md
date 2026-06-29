# Observables.Samples.WebSocket.Reactive

Console sample for **`Observables.WebSocket.Reactive`** `0.1.2` — declarative `[WebSocket]` interface proxies returning `IObservable<T>`.

## Run

```powershell
dotnet run --project Observables.Samples.WebSocket.Reactive
```

With a sibling Observables clone:

```powershell
dotnet run --project Observables.Samples.WebSocket.Reactive -p:UseLocalObservables=true
```

## What it demonstrates

- `[WebSocketConnect]`, `[WebSocketClose]`, `[WebSocketSend]`, `[WebSocketReceive]` on `IEchoHub` returning `IObservable<T>`
- `WebSocketService.For<IEchoHub>(socket)` factory registration (CI runs this without a live server)

See [Observables.Docs — WebSocket](https://github.com/Skymly/Observables.Docs/blob/main/docs/websocket.md).
