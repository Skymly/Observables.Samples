# Observables.Samples.WebSocket

Console sample for **`Observables.WebSocket.R3`** — declarative `[WebSocket]` interface proxies.

## What it demonstrates

- `[WebSocketConnect]`, `[WebSocketClose]`, `[WebSocketSend]`, `[WebSocketReceive]` on `IEchoHub`
- `WebSocketService.For<IEchoHub>(socket)` factory registration (CI runs this without a live server)

## Run

```powershell
dotnet run --project Observables.Samples.WebSocket
```

With a sibling Observables clone:

```powershell
dotnet run --project Observables.Samples.WebSocket -p:UseLocalObservables=true
```

## Live WebSocket (optional)

CI only checks that the source-generated factory is registered. To exercise connect/send/receive against a real endpoint, create a `ClientWebSocket`, pass it to `WebSocketService.For<IEchoHub>`, then compose `Connect`, `SendText`, and `EchoText` with R3 operators. See [Observables.Docs — WebSocket](https://github.com/Skymly/Observables.Docs/blob/main/docs/websocket.md).
