# Observables.Samples.Postgres.Reactive

Console sample for **`Observables.Postgres.Reactive`** `0.1.7` — declarative PostgreSQL LISTEN/NOTIFY interface proxies returning `IObservable<T>`.

## Package reference (default)

```xml
<PackageReference Include="Observables.Postgres.Reactive" Version="0.1.7" />
<PackageReference Include="Npgsql" Version="10.0.3" />
```

## What it demonstrates

- `[Postgres]` interface with `IObservable` return types (`Api/IOrderHubReactive.cs`)
- `PostgresService.For` factory registration (`RegistrationDemo` — no server in CI)
- Live demo: two dedicated connections with `Pooling=false`; set `POSTGRES_CONNECTION_STRING` and pass `--live` (see [Observables.Samples.Postgres](../Observables.Samples.Postgres/README.md))

## Run

```powershell
dotnet run --project Observables.Samples.Postgres.Reactive
dotnet run --project Observables.Samples.Postgres.Reactive -- --live
```
