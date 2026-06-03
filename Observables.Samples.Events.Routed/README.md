# Observables.Samples.Events.Routed

Avalonia desktop sample for `<ObservableRoutedEvents>true</ObservableRoutedEvents>` and `RoutedEvents()` / `RoutedEventHandlers()`.

## Run locally

Requires a graphical environment (Windows/macOS/Linux desktop).

```powershell
dotnet run --project Observables.Samples.Events.Routed -c Release
```

## CI

This project is **excluded** from GitHub Actions via Nuke (`ObservablesExcludeFromCi`). CI builds and runs the console samples only.
