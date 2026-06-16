# Observables.Samples.Nats.Reactive

Console sample for **`Observables.Nats.Reactive`** — declarative Core NATS subject interface proxies returning `IObservable<T>`.

## Package reference (default)

Planned NuGet line **`0.1.0`**. Until then:

```powershell
dotnet run --project Observables.Samples.Nats.Reactive -p:UseLocalObservables=true
```

## What it demonstrates

- `[Nats]` interface with `IObservable` return types (`Api/IOrderHubReactive.cs`)
- `NatsService.For` factory registration (`RegistrationDemo` — no server in CI)

See [Observables.Docs — Nats](https://github.com/Skymly/Observables.Docs/blob/main/docs/nats.md).
