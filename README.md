# Observables.Samples

Runnable sample applications for **[Skymly/Observables](https://github.com/Skymly/Observables)** using the **`0.1.2`** NuGet meta-packages on [nuget.org](https://www.nuget.org/packages/Observables.Events.R3/0.1.2) (Events, RestAPI, SignalR, Mqtt, WebSocket, Grpc, Sse, and Nats).

| Package | Sample project |
|---------|----------------|
| `Observables.Events.R3` | **Observables.Samples.Events** |
| `Observables.Events.Reactive` | **Observables.Samples.Events.Reactive** |
| `Observables.Events.R3` + Avalonia routed | **Observables.Samples.Events.Routed** (local desktop only) |
| `Observables.RestAPI.R3` | **Observables.Samples.RestAPI** |
| `Observables.RestAPI.Reactive` | **Observables.Samples.RestAPI.Reactive** |
| `Observables.SignalR.R3` | **Observables.Samples.SignalR** |
| `Observables.SignalR.Reactive` | **Observables.Samples.SignalR.Reactive** |
| `Observables.Mqtt.R3` | **Observables.Samples.Mqtt** |
| `Observables.Mqtt.Reactive` | **Observables.Samples.Mqtt.Reactive** |
| `Observables.WebSocket.R3` | **Observables.Samples.WebSocket** |
| `Observables.WebSocket.Reactive` | **Observables.Samples.WebSocket.Reactive** |
| `Observables.Grpc.R3` | **Observables.Samples.Grpc** |
| `Observables.Grpc.Reactive` | **Observables.Samples.Grpc.Reactive** |
| `Observables.Sse.R3` | **Observables.Samples.Sse** |
| `Observables.Sse.Reactive` | **Observables.Samples.Sse.Reactive** |
| `Observables.Nats.R3` | **Observables.Samples.Nats** |
| `Observables.Nats.Reactive` | **Observables.Samples.Nats.Reactive** |

Preview packages: **tag + NuGet only** (no GitHub Release). See Observables `AGENTS.md`.

## Build and run (NuGet, default)

Requires **.NET 8 SDK** only - no sibling `../Observables` clone required.

```powershell
dotnet restore Observables.Samples.slnx
dotnet build Observables.Samples.slnx

dotnet run --project Observables.Samples.Events
dotnet run --project Observables.Samples.Events.Reactive
dotnet run --project Observables.Samples.RestAPI
dotnet run --project Observables.Samples.RestAPI.Reactive
dotnet run --project Observables.Samples.SignalR
dotnet run --project Observables.Samples.SignalR.Reactive
dotnet run --project Observables.Samples.Mqtt
dotnet run --project Observables.Samples.Mqtt.Reactive
dotnet run --project Observables.Samples.WebSocket
dotnet run --project Observables.Samples.WebSocket.Reactive
dotnet run --project Observables.Samples.Grpc
dotnet run --project Observables.Samples.Grpc.Reactive
dotnet run --project Observables.Samples.Sse
dotnet run --project Observables.Samples.Sse.Reactive
dotnet run --project Observables.Samples.Nats
dotnet run --project Observables.Samples.Nats.Reactive

# Avalonia routed events (requires GUI; not run in CI)
dotnet run --project Observables.Samples.Events.Routed
```

CI uses Nuke: `./build.cmd Ci` (builds and runs console samples; **skips** `Observables.Samples.Events.Routed` on GitHub Actions).

`Directory.Build.props` sets `ObservablesPackageVersion` to **`0.1.2`** and `UseLocalObservables=false` by default.

## Local Observables repo (optional)

When developing generators in a sibling clone:

```powershell
dotnet build -p:UseLocalObservables=true
dotnet run --project Observables.Samples.Events -p:UseLocalObservables=true
```

Requires `../Observables/Observables.slnx`. See **`build/README-LocalSourceGenerators.md`**.

## Projects

| Project | Demonstrates |
|---------|----------------|
| **Observables.Samples.Events** | `Events()`, `EventHandlers()`, multiple subscribers - see project `README.md` |
| **Observables.Samples.Events.Reactive** | `IObservable` from classic events |
| **Observables.Samples.Events.Routed** | Avalonia `RoutedEvents()` / `<ObservableRoutedEvents>` - see project `README.md` |
| **Observables.Samples.RestAPI** | `Task` + `Observable<T>`, list GET, `ApiException` with MockHttp - see project `README.md` |
| **Observables.Samples.RestAPI.Reactive** | `IObservable<T>` + `FirstAsync().ToTask()`, 404 handling |
| **Observables.Samples.SignalR** | `[Hub]` proxy registration check (no live server in CI) - see project `README.md` |
| **Observables.Samples.SignalR.Reactive** | `[Hub]` IObservable proxy registration check (no live server in CI) |
| **Observables.Samples.Mqtt** | `[Mqtt]` proxy registration check (no broker in CI) - see project `README.md` |
| **Observables.Samples.Mqtt.Reactive** | `[Mqtt]` IObservable proxy registration check (no broker in CI) |
| **Observables.Samples.WebSocket** | `[WebSocket]` proxy registration check (no live server in CI) - see project `README.md` |
| **Observables.Samples.WebSocket.Reactive** | `[WebSocket]` IObservable proxy registration check (no live server in CI) |
| **Observables.Samples.Grpc** | `[Grpc]` proxy registration check (no live server in CI) - see project `README.md` |
| **Observables.Samples.Grpc.Reactive** | `[Grpc]` IObservable proxy registration check (no live server in CI) |
| **Observables.Samples.Sse** | `[Sse]` proxy registration check (no live server in CI) - see project `README.md` |
| **Observables.Samples.Sse.Reactive** | `[Sse]` IObservable proxy registration check (no live server in CI) |
| **Observables.Samples.Nats** | `[Nats]` subject proxy registration check (no server in CI) - see project `README.md` |
| **Observables.Samples.Nats.Reactive** | `[Nats]` IObservable proxy registration check (no server in CI) |

## Documentation

Canonical docs: **[Observables.Docs](https://github.com/Skymly/Observables.Docs)**.

## Related

| Repository | Role |
|------------|------|
| [Observables](https://github.com/Skymly/Observables) | Generators and runtime |
| [Observables.Docs](https://github.com/Skymly/Observables.Docs) | User documentation site |

## License

MIT - see [LICENSE](LICENSE).
