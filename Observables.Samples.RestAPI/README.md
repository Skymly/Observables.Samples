# Observables.Samples.RestAPI

Console sample for **Observables.RestAPI** runtime and **Observables.RestAPI.R3.SourceGenerators** (declarative HTTP → `Task` and R3 `Observable`).

## Prerequisites

- Sibling clone: `../Observables` with `Observables.slnx`
- .NET 8 SDK

## Run

```powershell
dotnet run --project Observables.Samples.RestAPI
```

Uses [RichardSzalay.MockHttp](https://www.nuget.org/packages/RichardSzalay.MockHttp) so no real HTTP server is required.

## What it demonstrates

- `IUserApi` with `[Get("/users/{id}")]` — same route for **Task** and **Observable** members
- `RestService.For<IUserApi>(httpClient)` builds the generated client
- `MockHttpDemo` exercises both call styles against canned JSON responses

API contract: `Api/IUserApi.cs`. DTO: `Models/User.cs`.

## Local wiring

`ObservablesSampleKind=RestAPI` references:

- `Observables.RestAPI/Observables.RestAPI` (runtime)
- `Observables.RestAPI.R3.SourceGenerators` as analyzer (`OutputItemType=Analyzer`)

See root `Directory.Build.props` for paths after the `Observables.<Feature>/` folder layout.
