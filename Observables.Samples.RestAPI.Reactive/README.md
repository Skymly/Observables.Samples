# Observables.Samples.RestAPI.Reactive

Console sample for **`Observables.RestAPI.Reactive`** `0.1.6-preview1` �?declarative HTTP interface proxies returning `IObservable<T>`.

## Run

```powershell
dotnet run --project Observables.Samples.RestAPI.Reactive
```

With a sibling Observables clone:

```powershell
dotnet run --project Observables.Samples.RestAPI.Reactive -p:UseLocalObservables=true
```

## What it demonstrates

- `IObservable<T>` from HTTP GET endpoints (`FirstAsync().ToTask()` pattern)
- `ApiException` handling on HTTP 404

Uses [RichardSzalay.MockHttp](https://www.nuget.org/packages/RichardSzalay.MockHttp) �?no real HTTP server.

See [Observables.Docs �?RestAPI](https://github.com/Skymly/Observables.Docs/blob/main/docs/restapi.md).
