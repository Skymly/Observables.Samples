# Observables.Samples

Runnable sample applications for **[Skymly/Observables](https://github.com/Skymly/Observables)** using the **`0.1.0-preview2`** NuGet packages on [nuget.org](https://www.nuget.org/packages/Observables.Events.R3/0.1.0-preview2).

| Package | Sample project |
|---------|----------------|
| `Observables.Events.R3` | **Observables.Samples.Events** |
| `Observables.Events.Reactive` | **Observables.Samples.Events.Reactive** |
| `Observables.Events.R3` + Avalonia routed | **Observables.Samples.Events.Routed** (local desktop only) |
| `Observables.RestAPI.R3` | **Observables.Samples.RestAPI** |
| `Observables.RestAPI.Reactive` | **Observables.Samples.RestAPI.Reactive** |

Preview packages: **tag + NuGet only** (no GitHub Release). See Observables `AGENTS.md`.

## Build and run (NuGet, default)

Requires **.NET 8 SDK** only — no sibling `../Observables` clone required.

```powershell
dotnet restore Observables.Samples.slnx
dotnet build Observables.Samples.slnx

dotnet run --project Observables.Samples.Events
dotnet run --project Observables.Samples.Events.Reactive
dotnet run --project Observables.Samples.RestAPI
dotnet run --project Observables.Samples.RestAPI.Reactive

# Avalonia routed events (requires GUI; not run in CI)
dotnet run --project Observables.Samples.Events.Routed
```

CI uses Nuke: `./build.cmd Ci` (builds and runs console samples; **skips** `Observables.Samples.Events.Routed` on GitHub Actions).

`Directory.Build.props` sets `ObservablesPackageVersion` to **`0.1.0-preview2`** and `UseLocalObservables=false` by default.

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
| **Observables.Samples.Events** | `Events()`, `EventHandlers()`, multiple subscribers — see project `README.md` |
| **Observables.Samples.Events.Reactive** | `IObservable` from classic events |
| **Observables.Samples.Events.Routed** | Avalonia `RoutedEvents()` / `<ObservableRoutedEvents>` — see project `README.md` |
| **Observables.Samples.RestAPI** | `Task` + `Observable<T>`, list GET, `ApiException` with MockHttp — see project `README.md` |
| **Observables.Samples.RestAPI.Reactive** | `IObservable<T>` + `FirstAsync().ToTask()`, 404 handling |

## Documentation

Canonical docs: **[Observables.Docs](https://github.com/Skymly/Observables.Docs)**.

## Related

| Repository | Role |
|------------|------|
| [Observables](https://github.com/Skymly/Observables) | Generators and runtime |
| [Observables.Docs](https://github.com/Skymly/Observables.Docs) | User documentation site |

## License

MIT — see [LICENSE](LICENSE).
