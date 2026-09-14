# Observables.Samples.Redis.Reactive

Console sample for **`Observables.Redis.Reactive`** `0.2.2` (declarative Redis Pub/Sub interface → `IObservable` + `RedisService.For`).

## Package reference (default)

```xml
<PackageReference Include="Observables.Redis.Reactive" Version="0.2.2" />
<PackageReference Include="StackExchange.Redis" Version="2.8.41" />
```

Optional sibling **Observables** clone: `dotnet run --project Observables.Samples.Redis.Reactive -p:UseLocalObservables=true`

## What it demonstrates

- `[Redis]` interface with `[RedisPublish]` and `[RedisSubscribe]` returning `IObservable<T>` (`Api/IOrderHubReactive.cs`)
- Source-generated proxy registration via module initializer (`RegistrationDemo` — no server in CI)

## Live Redis (local only)

CI and `./build.cmd Ci` run `RegistrationDemo` (factory registration only; no server).

To exercise publish/subscribe against a real server:

1. Start Redis (or compatible) on `127.0.0.1:6379`.
2. `await using var mux = await ConnectionMultiplexer.ConnectAsync("localhost:6379");`
3. `var hub = RedisService.For<IOrderHubReactive>(mux);` and subscribe to `hub.Ping` / call `hub.PublishPing(...)`.

## Run

```powershell
dotnet run --project Observables.Samples.Redis.Reactive
```
