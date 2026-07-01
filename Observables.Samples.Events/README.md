# Observables.Samples.Events

Console sample for **`Observables.Events.R3`** `0.1.5` (classic CLR events �?R3).

## Package reference (default)

```xml
<PackageReference Include="Observables.Events.R3" Version="0.1.5" />
<PackageReference Include="R3" Version="1.3.0" />
```

This repo applies that via `Directory.Build.targets` when `UseLocalObservables=false`.

## Run

```powershell
dotnet run --project Observables.Samples.Events
```

## Demos

| Demo | Entry API | Scenario |
|------|-----------|----------|
| `ClassicEventsDemo` | `Events()` | `Action` �?`Observable<Unit>`; `Action<int>` �?`Observable<int>` |
| `EventHandlersDemo` | `EventHandlers()` | `EventHandler` on an interface |
| `SharedEventStreamDemo` | `Events()` | Two subscribers on the same `CountChanged` stream |

Models under `Models/`; wiring under `Demos/`.

## Local analyzer wiring

`-p:UseLocalObservables=true` switches to project references under `../Observables` (see root `build/README-LocalSourceGenerators.md`).
