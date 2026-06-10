# Observables.Samples.Grpc

Console sample for **`Observables.Grpc.R3`** `0.1.0-preview6` (declarative gRPC interface -> R3 `Observable` + `GrpcService.For`).

## NuGet

```xml
<PackageReference Include="Observables.Grpc.R3" Version="0.1.0-preview6" />
<PackageReference Include="R3" Version="1.3.0" />
<PackageReference Include="Grpc.Net.Client" Version="2.67.0" />
```

## CI behavior

`RegistrationDemo` only checks that the source generator registered a factory (null `CallInvoker` -> `ArgumentNullException`). No network I/O.
