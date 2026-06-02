# Observables.Samples.Events

Console sample for **Observables.Events.R3.SourceGenerators** (classic CLR events → R3).

## Prerequisites

- Sibling clone: `../Observables` with `Observables.slnx`
- .NET 8 SDK
- Package [R3](https://www.nuget.org/packages/R3) 1.3.0 (pulled via `Directory.Build.targets` when local)

## Run

```powershell
# From Observables.Samples repo root
dotnet run --project Observables.Samples.Events
```

## What it demonstrates

| Demo | Entry API | Scenario |
|------|-----------|----------|
| `ClassicEventsDemo` | `Events()` | `Action` → `Observable<Unit>`; `Action<int>` → `Observable<int>` |
| `EventHandlersDemo` | `EventHandlers()` | `EventHandler` → `Observable<(object? sender, EventArgs e)>` on an interface |

Source types live under `Models/`; wiring is in `Demos/`.

## Local analyzer wiring

`ObservablesSampleKind=Events` and `Directory.Build.targets` add a project reference to  
`Observables.Events/Observables.Events.R3.SourceGenerators` when `UseLocalObservables=true`.

Optional routed events (`RoutedEvents()`, `ObservableRoutedEvents`, WPF/Avalonia) are documented in Observables; this sample stays on classic events only.

When **Observables.Events.R3** ships on NuGet, switch to `PackageReference` with `IncludeAssets="analyzers"` (see `build/README-LocalSourceGenerators.md`).
