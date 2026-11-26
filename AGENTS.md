# Observables.Samples

Sample applications for [Skymly/Observables](https://github.com/Skymly/Observables). Generator and library changes belong in the main repository.

## Build & Verify

```powershell
dotnet build Observables.Samples.slnx
# Or run the CI-equivalent Nuke target (uses UseLocalObservables=false):
./build.cmd Ci
```

- Local sibling development against `../Observables` uses `-p:UseLocalObservables=true`.
- `Observables.Samples.Events.Routed` (Avalonia) is skipped on headless CI builds; run it locally with a graphical environment.

## Version Sync

- `Directory.Build.props` (`ObservablesPackageVersion`) is the single version source alongside READMEs and `SampleMetadata.cs`.
- Run `pwsh scripts/sync-observables-version.ps1 -Version <x.y.z>` to update all version references together.
- `.github/workflows/version-drift.yml` asserts alignment with the latest stable release on nuget.org.
- Do not bump Observables package versions without explicit maintainer approval.

## Conventions

- Commit messages, issues, and PR text: **English**.
- Do not commit or push unless explicitly requested.
