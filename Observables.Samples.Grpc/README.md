# Observables.Samples.Grpc

Console sample for **`Observables.Grpc.R3`** `0.1.4` (declarative gRPC interface -> R3 `Observable` + `GrpcService.For`).

## NuGet

```xml
<PackageReference Include="Observables.Grpc.R3" Version="0.1.4" />
<PackageReference Include="R3" Version="1.3.0" />
<PackageReference Include="Grpc.Net.Client" Version="2.67.0" />
```

## CI behavior

`RegistrationDemo` only checks that the source generator registered a factory (null `CallInvoker` -> `ArgumentNullException`). No network I/O.

See [gRPC testing](https://github.com/Skymly/Observables.Docs/blob/main/docs/grpc.md#testing) in Observables.Docs for in-memory `TestServer` patterns used in the main repo.
