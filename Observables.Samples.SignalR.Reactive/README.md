# Observables.Samples.SignalR.Reactive

Console sample for **`Observables.SignalR.Reactive`** `0.1.4` �?declarative hub interface proxies returning `IObservable<T>`.

## Run

```powershell
dotnet run --project Observables.Samples.SignalR.Reactive
```

With a sibling Observables clone:

```powershell
dotnet run --project Observables.Samples.SignalR.Reactive -p:UseLocalObservables=true
```

## What it demonstrates

- `[Hub]` interface with `[HubInvoke]` and `[HubOn]` members returning `IObservable<T>`
- Source-generated proxy registration via module initializer (`RegistrationDemo` �?no network in CI)

See [Observables.Docs �?SignalR](https://github.com/Skymly/Observables.Docs/blob/main/docs/signalr.md).
