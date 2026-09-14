# Local Observables source generators

## Layout

Clone the generator repo and this samples repo as **siblings**. `Directory.Build.props` resolves `ObservablesRepoRoot` to `../Observables`:

```
<parent>/
  Observables/            # generator repository (Observables.slnx)
  Observables.Samples/    # this repository
```

Paths assume the Observables repo folder layout (`Observables.<Feature>/…`).

## MSBuild properties

| Property | Default | Meaning |
|----------|---------|---------|
| `ObservablesPackageVersion` | see `Directory.Build.props` (currently `0.2.2`) | NuGet version for all Observables meta-packages when `UseLocalObservables` is false |
| `UseLocalObservables` | `false` | `true` → sibling `ProjectReference` analyzers and runtimes |
| `ObservablesRepoRoot` | `../Observables` (made absolute) | Path to the generator repository |
| `ObservablesSampleKind` | per sample csproj | Selects `Directory.Build.targets` wiring |

Do not change the CI default `UseLocalObservables=false`. Local generator hacking uses `-p:UseLocalObservables=true`.

## Sample kinds

`ObservablesSampleKind` values wired in `Directory.Build.targets`:

| Kind | Sample project |
|------|----------------|
| `Events` | Events, Events.Routed |
| `EventsReactive` | Events.Reactive |
| `RestAPI` | RestAPI |
| `RestAPIReactive` | RestAPI.Reactive |
| `SignalR` | SignalR |
| `SignalRReactive` | SignalR.Reactive |
| `Mqtt` | Mqtt |
| `MqttReactive` | Mqtt.Reactive |
| `WebSocket` | WebSocket |
| `WebSocketReactive` | WebSocket.Reactive |
| `Grpc` | Grpc |
| `GrpcReactive` | Grpc.Reactive |
| `Sse` | Sse |
| `SseReactive` | Sse.Reactive |
| `Nats` | Nats |
| `NatsReactive` | Nats.Reactive |
| `Postgres` | Postgres |
| `PostgresReactive` | Postgres.Reactive |
| `Redis` | Redis |
| `RedisReactive` | Redis.Reactive |

## Commands

```powershell
# NuGet packages (default, no sibling clone required)
dotnet build Observables.Samples.slnx
dotnet run --project Observables.Samples.Events

# Sibling Observables repo
dotnet build -p:UseLocalObservables=true Observables.Samples.slnx
dotnet run --project Observables.Samples.Events -p:UseLocalObservables=true
```

Published packages follow `ObservablesPackageVersion` in `Directory.Build.props`.
