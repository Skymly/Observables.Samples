# Observables.Samples � AI agent notes

## Scope

This repository contains **sample apps only**. Do not add source generators or library code here � change [Observables](https://github.com/Skymly/Observables) instead.

## Local development

- **Default**: NuGet **`ObservablesPackageVersion`** (`0.1.1`) via `Observables.Events.R3` / `Observables.RestAPI.R3` / `Observables.SignalR.R3` / `Observables.Mqtt.R3` / `Observables.WebSocket.R3` / `Observables.Grpc.R3` / `Observables.Sse.R3` / `Observables.Nats.R3` on nuget.org.
- **Optional sibling**: `../Observables` with `-p:UseLocalObservables=true` for generator work.
- Build: `dotnet build Observables.Samples.slnx` or `./build.cmd Ci` from the repo root.
- CI uses **Nuke** `./build.cmd Ci` with **`UseLocalObservables=false`** (no Observables checkout).
- **`Observables.Samples.Events.Routed`** (Avalonia) is **skipped on server/CI** builds; run locally with a graphical environment.

## Language

- User chat: ???? (unless requested otherwise).
- Commit messages and GitHub Issue/PR text: **English**.

## Git

- Do not commit or push unless the user asks.
- Do not bump Observables package versions without user approval.
