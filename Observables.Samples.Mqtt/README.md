# Observables.Samples.Mqtt

Console sample for **`Observables.Mqtt.R3`** `0.1.4` (declarative topic interface �?R3 `Observable` + `MqttService.For`).

## Package reference (default)

```xml
<PackageReference Include="Observables.Mqtt.R3" Version="0.1.4" />
<PackageReference Include="MQTTnet" Version="4.3.7.1207" />
```

Optional sibling **Observables** clone: `dotnet run --project Observables.Samples.Mqtt -p:UseLocalObservables=true`

## What it demonstrates

- `[Mqtt]` interface with `[MqttPublish]` and `[MqttSubscribe]` (`Api/ISensorTopics.cs`)
- Source-generated proxy registration via module initializer (`RegistrationDemo` �?no broker in CI)

## Live broker (local only)

CI and `./build.cmd Ci` run `RegistrationDemo` (factory registration only; no broker).

To exercise publish/subscribe against a real broker:

1. Start MQTTnet or any broker on `127.0.0.1`.
2. `var client = new MqttFactory().CreateMqttClient();` then `ConnectAsync`.
3. `var topics = MqttService.For<ISensorTopics>(client);` and subscribe to `topics.Ping` / call `topics.PublishPing()`.

## Run

```powershell
dotnet run --project Observables.Samples.Mqtt
```
