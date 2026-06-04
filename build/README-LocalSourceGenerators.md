# Local Observables source generators

## Layout

Clone both repositories as siblings when hacking generators:

```
Skymly/
  Observables/
  Observables.Samples/    ← this repo
```

Paths in `Directory.Build.props` assume the **Observables** folder layout (`Observables.<Feature>/…`).

## MSBuild properties

| Property | Default | Meaning |
|----------|---------|---------|
| `ObservablesPackageVersion` | `0.1.0-preview4` | NuGet version for Events/RestAPI/SignalR meta-packages |
| `UseLocalObservables` | `false` | `true` → sibling `ProjectReference` analyzers |
| `ObservablesRepoRoot` | `../Observables` (absolute) | Path to the generator repository |
| `ObservablesSampleKind` | per sample csproj | `Events`, `RestAPI`, `SignalR`, `Mqtt`, … — selects `Directory.Build.targets` wiring |

## Commands

```powershell
# NuGet packages (default, no sibling clone required)
dotnet build Observables.Samples.slnx
dotnet run --project Observables.Samples.Events
dotnet run --project Observables.Samples.RestAPI
dotnet run --project Observables.Samples.SignalR
dotnet run --project Observables.Samples.Mqtt -p:UseLocalObservables=true

# Sibling Observables repo
dotnet build -p:UseLocalObservables=true Observables.Samples.slnx
dotnet run --project Observables.Samples.Events -p:UseLocalObservables=true
```

Published packages: [Events.R3](https://www.nuget.org/packages/Observables.Events.R3/0.1.0-preview4), [RestAPI.R3](https://www.nuget.org/packages/Observables.RestAPI.R3/0.1.0-preview4), [SignalR.R3](https://www.nuget.org/packages/Observables.SignalR.R3/0.1.0-preview4) (and `.Reactive` counterparts). **Mqtt** requires a sibling Observables clone until the next preview NuGet line.
