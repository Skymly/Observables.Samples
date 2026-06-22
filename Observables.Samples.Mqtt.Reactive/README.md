# Observables.Samples.Mqtt.Reactive

Console sample for **`Observables.Mqtt.Reactive`** `0.1.1` — declarative MQTT topic interface proxies returning `IObservable<T>`.

## Run

```powershell
dotnet run --project Observables.Samples.Mqtt.Reactive
```

With a sibling Observables clone:

```powershell
dotnet run --project Observables.Samples.Mqtt.Reactive -p:UseLocalObservables=true
```

## What it demonstrates

- `[Mqtt]` interface with `[MqttPublish]` and `[MqttSubscribe]` returning `IObservable<T>`
- Source-generated proxy registration via module initializer (`RegistrationDemo` — no broker in CI)

See [Observables.Docs — Mqtt](https://github.com/Skymly/Observables.Docs/blob/main/docs/mqtt.md).
