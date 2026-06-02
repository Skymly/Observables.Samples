# Local Observables source generators

## Layout

Clone both repositories as siblings:

```
Skymly/
  Observables/
  Observables.Samples/    ← this repo
```

## MSBuild properties

| Property | Default | Meaning |
|----------|---------|---------|
| `UseLocalObservables` | `true` when `../Observables/Observables.slnx` exists | Use `ProjectReference` to analyzer projects (same as generator tests) |
| `ObservablesRepoRoot` | `../Observables` (absolute) | Path to the generator repository |

## Commands

```powershell
dotnet build Observables.Samples.slnx
dotnet build -p:UseLocalObservables=false Observables.Samples.slnx
```

When NuGet packages (`Observables.Events.R3`, etc.) are published, `-p:UseLocalObservables=false` will restore packages instead of project references.
