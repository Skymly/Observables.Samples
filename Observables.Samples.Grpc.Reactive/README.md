# Observables.Samples.Grpc.Reactive

Console sample for **`Observables.Grpc.Reactive`** `0.1.1` — declarative gRPC interface proxies returning `IObservable<T>`.

## Run

```powershell
dotnet run --project Observables.Samples.Grpc.Reactive
```

With a sibling Observables clone:

```powershell
dotnet run --project Observables.Samples.Grpc.Reactive -p:UseLocalObservables=true
```

## What it demonstrates

- `[Grpc]` interface with unary and streaming RPC members returning `IObservable<T>`
- Source-generated proxy registration via module initializer (`RegistrationDemo` — no network in CI)

See [Observables.Docs — gRPC](https://github.com/Skymly/Observables.Docs/blob/main/docs/grpc.md).
