# Observables.Samples.RestAPI

Console sample for **`Observables.RestAPI.R3`** `0.1.0-preview3` (declarative HTTP → `Task` and R3 `Observable`).

## Package reference (default)

```xml
<PackageReference Include="Observables.RestAPI.R3" Version="0.1.0-preview3" />
<PackageReference Include="R3" Version="1.3.0" />
```

Runtime and R3 source generator are bundled in the meta-package.

## Run

```powershell
dotnet run --project Observables.Samples.RestAPI
```

Uses [RichardSzalay.MockHttp](https://www.nuget.org/packages/RichardSzalay.MockHttp) — no real HTTP server.

## Demos (`MockHttpDemo`)

| Scenario | API style |
|----------|-----------|
| Single user | `Task<User>` `GetUserAsync` |
| Single user (reactive) | `Observable<User>` + `FirstAsync` |
| User list | `Task<IReadOnlyList<User>>` `ListUsersAsync` |
| Not found | `ApiException` on HTTP 404 |

Contract: `Api/IUserApi.cs`. DTO: `Models/User.cs`.

## Local wiring

`-p:UseLocalObservables=true` references `../Observables` runtime + analyzer projects instead of NuGet.
