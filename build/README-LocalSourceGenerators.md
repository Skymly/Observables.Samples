# Local Observables source generators

## Layout

Clone both repositories as siblings under the **Observables** project folder when hacking generators:

```
<workspace-root>/
  Skymly/
    Observables/
      Observables/
      Observables.Samples/    �?this repo
```

Paths in `Directory.Build.props` assume the **Observables** folder layout (`Observables.<Feature>/…`).

## MSBuild properties

| Property | Default | Meaning |
|----------|---------|---------|
| `ObservablesPackageVersion` | `0.1.5` | NuGet version for all Observables meta-packages |
| `UseLocalObservables` | `false` | `true` �?sibling `ProjectReference` analyzers |
| `ObservablesRepoRoot` | `../Observables` (absolute) | Path to the generator repository |
| `ObservablesSampleKind` | per sample csproj | `Events`, `RestAPI`, `SignalR`, `Mqtt`, �?�?selects `Directory.Build.targets` wiring |

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

Published packages: [Events.R3](https://www.nuget.org/packages/Observables.Events.R3/0.1.5) and the other **16** Observables meta-packages at **`0.1.5`** on nuget.org.
