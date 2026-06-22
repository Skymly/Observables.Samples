# Observables.Samples.SignalR

Console sample for **`Observables.SignalR.R3`** `0.1.1` (declarative hub interface �?R3 `Observable` + `HubService.For`).

## Package reference (default)

```xml
<PackageReference Include="Observables.SignalR.R3" Version="0.1.1" />
```

## What it demonstrates

- `[Hub]` interface with `[HubInvoke]` and `[HubOn]` members (`Api/IChatHub.cs`)
- Source-generated proxy registration via module initializer (`RegistrationDemo` �?no network in CI)

## Live hub (local only)

CI and `./build.cmd Ci` intentionally **do not** start a SignalR server. To exercise `InvokeAsync` / `On` against a real hub:

1. Run an ASP.NET Core app with a matching hub (method names aligned with attributes).
2. `HubConnectionBuilder.WithUrl("https://localhost:�?hub").Build()` then `await connection.StartAsync()`.
3. `var chat = HubService.For<IChatHub>(connection);` and subscribe to `chat.ReceiveMessage` / `chat.GetUserCount()`.

## Run

```powershell
dotnet run --project Observables.Samples.SignalR
```
