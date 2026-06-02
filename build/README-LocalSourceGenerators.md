# Local Observables source generators

## Layout

Clone both repositories as siblings:

```
Skymly/
  Observables/
  Observables.Samples/    ← this repo
```

Paths in `Directory.Build.props` assume the **Observables** folder layout (`Observables.<Feature>/…`).

## MSBuild properties

| Property | Default | Meaning |
|----------|---------|---------|
| `UseLocalObservables` | `true` when `../Observables/Observables.slnx` exists | Use `ProjectReference` to analyzer/runtime projects |
| `ObservablesRepoRoot` | `../Observables` (absolute) | Path to the generator repository |
| `ObservablesSampleKind` | per sample csproj | `Events` or `RestAPI` — selects `Directory.Build.targets` wiring |

## Commands

```powershell
dotnet build Observables.Samples.slnx
dotnet run --project Observables.Samples.Events
dotnet run --project Observables.Samples.RestAPI
dotnet build -p:UseLocalObservables=false Observables.Samples.slnx
```

When NuGet packages (`Observables.Events.R3`, `Observables.RestAPI.R3`, etc.) are published, `-p:UseLocalObservables=false` will restore packages instead of project references.
