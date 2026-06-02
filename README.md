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
| **Observables.Samples.Events** | Classic CLR events → R3 (`Events()`, `EventHandlers()`). See project `README.md`. |
| **Observables.Samples.RestAPI** | Declarative REST client (`Task` + `Observable<T>`) with MockHttp. See project `README.md`. |

## Build and run

Requires **.NET 8 SDK**.

```powershell
# With ../Observables checked out (recommended)
dotnet build Observables.Samples.slnx

dotnet run --project Observables.Samples.Events
dotnet run --project Observables.Samples.RestAPI
```

Without a sibling Observables repo, samples build a stub `Program.cs` that prints setup instructions (`LOCAL_OBSERVABLES` not defined).

## Documentation

Canonical docs: **[Observables.Docs](https://github.com/Skymly/Observables.Docs)** (VitePress; GitHub Pages URL after first deploy).

## Related

| Repository | Role |
|------------|------|
| [Observables](https://github.com/Skymly/Observables) | Generators and runtime |
| [Observables.Docs](https://github.com/Skymly/Observables.Docs) | User documentation site |

## License

MIT — see [LICENSE](LICENSE).
