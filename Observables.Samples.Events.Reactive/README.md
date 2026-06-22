# Observables.Samples.Events.Reactive

Console sample for **`Observables.Events.Reactive`** `0.1.1` — classic CLR events to `IObservable<T>`.

## Run

```powershell
dotnet run --project Observables.Samples.Events.Reactive
```

With a sibling Observables clone:

```powershell
dotnet run --project Observables.Samples.Events.Reactive -p:UseLocalObservables=true
```

## What it demonstrates

- `Events()` and `EventHandlers()` with `IObservable` return types
- Multiple subscribers on the same event stream

See [Observables.Docs — Events](https://github.com/Skymly/Observables.Docs/blob/main/docs/events.md).
