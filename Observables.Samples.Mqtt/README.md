# Observables.Samples.Mqtt

Console sample for **`Observables.Mqtt.R3`** (declarative topic interface → R3 `Observable` + `MqttService.For`).

## Package reference

`Observables.Mqtt.R3` is **not** on [nuget.org](https://www.nuget.org) as of **`0.1.0-preview3`**. Use a sibling **Observables** clone until the next preview line ships:

```powershell
dotnet run --project Observables.Samples.Mqtt -p:UseLocalObservables=true
```

When published, the default will match other samples:

```xml
<PackageReference Include="Observables.Mqtt.R3" Version="0.1.0-preview4" />
<PackageReference Include="MQTTnet" Version="4.3.7.1207" />
```

## What it demonstrates

- `[Mqtt]` interface with `[MqttPublish]` and `[MqttSubscribe]` (`Api/ISensorTopics.cs`)
- Source-generated proxy registration via module initializer (`RegistrationDemo` — no broker in CI)

## Live broker (local only)

CI and `./build.cmd Ci` (NuGet mode) run a **stub** that explains local clone is required. With `UseLocalObservables=true`, `RegistrationDemo` checks `MqttService.For` without connecting.

To exercise publish/subscribe against a real broker:

1. Start MQTTnet or any broker on `127.0.0.1`.
2. `var client = new MqttFactory().CreateMqttClient();` then `ConnectAsync`.
3. `var topics = MqttService.For<ISensorTopics>(client);` and subscribe to `topics.Ping` / call `topics.PublishPing("device-1")`.

## Run

```powershell
dotnet run --project Observables.Samples.Mqtt -p:UseLocalObservables=true
```
