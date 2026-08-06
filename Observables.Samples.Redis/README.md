# Observables.Samples.Redis

Console sample for **`Observables.Redis.R3`** `0.1.9` (declarative Redis Pub/Sub interface → R3 `Observable` + `RedisService.For`).

Library PRD: [Skymly/Observables#169](https://github.com/Skymly/Observables/issues/169).

## Package reference (default)

```xml
<PackageReference Include="Observables.Redis.R3" Version="0.1.9" />
<PackageReference Include="StackExchange.Redis" Version="2.8.41" />
```

Optional sibling **Observables** clone: `dotnet run --project Observables.Samples.Redis -p:UseLocalObservables=true`

## What it demonstrates

- `[Redis]` interface with `[RedisPublish]` and `[RedisSubscribe]` (`Api/IOrderHub.cs`)
- Source-generated proxy registration via module initializer (`RegistrationDemo` — no server in CI)

## Live Redis (local only)

CI and `./build.cmd Ci` run `RegistrationDemo` (factory registration only; no server).

To exercise publish/subscribe against a real server:

1. Start Redis (or compatible) on `127.0.0.1:6379`.
2. `await using var mux = await ConnectionMultiplexer.ConnectAsync("localhost:6379");`
3. `var hub = RedisService.For<IOrderHub>(mux);` and subscribe to `hub.Ping` / call `hub.PublishPing(...)`.

## Run

```powershell
dotnet run --project Observables.Samples.Redis
```
