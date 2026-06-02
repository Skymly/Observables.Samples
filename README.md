# Observables.Samples

Runnable sample applications for **[Skymly/Observables](https://github.com/Skymly/Observables)** (R3 and System.Reactive source generators).

## Generator reference: NuGet or local repo

**`Directory.Build.props`** detects a **sibling clone** at **`../Observables`**. When `Observables.slnx` is present, samples use **project references** to the matching analyzer projects instead of NuGet packages (not published yet).

Override:

```powershell
dotnet build -p:UseLocalObservables=false   # force NuGet (when packages exist)
dotnet build -p:UseLocalObservables=true    # force local sibling
```

See **`build/README-LocalSourceGenerators.md`**.

## Projects

| Project | Description |
|---------|-------------|
| **Observables.Samples.Events** | Console (`net8.0`) — placeholder entry point; full Events R3 walkthrough in `Observables.Samples.Events/README.md` (local analyzer wiring until NuGet ships). |

More samples (RoutedEvents, RestAPI, SignalR, …) will be added as those domains stabilize.

## Build

Requires **.NET 8 SDK** (and **.NET 10 SDK** when samples target `net10.0`).

```powershell
# With ../Observables checked out (recommended)
dotnet build Observables.Samples.slnx

# CI also checks out Observables next to this repo (see .github/workflows/build.yml)
```

## Documentation

Canonical docs: **[Observables.Docs](https://github.com/Skymly/Observables.Docs)** (VitePress; GitHub Pages URL after first deploy).

## Related

| Repository | Role |
|------------|------|
| [Observables](https://github.com/Skymly/Observables) | Generators and runtime |
| [Observables.Docs](https://github.com/Skymly/Observables.Docs) | User documentation site |

## License

MIT — see [LICENSE](LICENSE).
