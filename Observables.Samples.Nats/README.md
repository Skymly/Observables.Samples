# Observables.Samples.Nats

Console sample for **`Observables.Nats.R3`** `0.1.5` (declarative Core NATS subject interface �?R3 `Observable` + `NatsService.For`).

## Package reference (default)

```xml
<PackageReference Include="Observables.Nats.R3" Version="0.1.5" />
<PackageReference Include="NATS.Client.Core" Version="2.8.1" />
```

Optional sibling **Observables** clone: `dotnet run --project Observables.Samples.Nats -p:UseLocalObservables=true`

## What it demonstrates

- `[Nats]` interface with `[NatsPublish]` and `[NatsSubscribe]` (`Api/IOrderHub.cs`)
- Source-generated proxy registration via module initializer (`RegistrationDemo` �?no server in CI)

## Live NATS server (local only)

CI and `./build.cmd Ci` run `RegistrationDemo` (factory registration only; no server).

To exercise publish/subscribe against a real server:

1. Start `nats-server` on `127.0.0.1:4222`.
2. `await using var nats = new NatsConnection(new NatsOpts { Url = "nats://127.0.0.1:4222" });`
3. `var hub = NatsService.For<IOrderHub>(nats);` and subscribe to `hub.Ping` / call `hub.PublishPing()`.

## Run

```powershell
dotnet run --project Observables.Samples.Nats
```
