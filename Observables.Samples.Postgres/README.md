# Observables.Samples.Postgres

Console sample for **`Observables.Postgres.R3`** `0.1.7` (declarative PostgreSQL LISTEN/NOTIFY interface → R3 `Observable` + `PostgresService.For`).

## Package reference (default)

```xml
<PackageReference Include="Observables.Postgres.R3" Version="0.1.7" />
<PackageReference Include="Npgsql" Version="10.0.3" />
```

Optional sibling **Observables** clone: `dotnet run --project Observables.Samples.Postgres -p:UseLocalObservables=true`

## What it demonstrates

- `[Postgres]` interface with `[Listen]` and `[Notify]` (`Api/IOrderHub.cs`)
- Source-generated proxy registration via module initializer (`RegistrationDemo` — no server in CI)
- Live demo uses **two** `NpgsqlConnection` instances (listener + notifier) with **`Pooling=false`** on the connection string

## Live PostgreSQL (local only)

CI and `./build.cmd Ci` run `RegistrationDemo` only (factory registration; no database).

To exercise LISTEN/NOTIFY against a real server:

1. Set `POSTGRES_CONNECTION_STRING` (include `Pooling=false` or let the sample force it via `NpgsqlConnectionStringBuilder`).
2. Ensure PostgreSQL accepts the connection (default fallback: `Host=127.0.0.1;Port=5432;Database=postgres;Username=postgres;Password=postgres`).
3. Run with `--live`:

```powershell
$env:POSTGRES_CONNECTION_STRING = "Host=127.0.0.1;Port=5432;Database=postgres;Username=postgres;Password=postgres"
dotnet run --project Observables.Samples.Postgres -- --live
```

## Run

```powershell
dotnet run --project Observables.Samples.Postgres
```
