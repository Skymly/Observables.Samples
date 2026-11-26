# Observables.Samples

[English](README.md) | **简体中文** | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md)

**[Skymly/Observables](https://github.com/Skymly/Observables)** 的可运行示例应用集，基于 [nuget.org](https://www.nuget.org/packages/Observables.Events.R3/0.5.1) 上 **`0.5.1`** 版本的 NuGet 元包（覆盖 Events、RestAPI、SignalR、Mqtt、WebSocket、Grpc、Sse、Nats、Postgres 与 Redis）。

| 包名 | 示例项目 |
|------|----------|
| `Observables.Events.R3` | **Observables.Samples.Events** |
| `Observables.Events.Reactive` | **Observables.Samples.Events.Reactive** |
| `Observables.Events.R3` + Avalonia routed | **Observables.Samples.Events.Routed**（仅限本地桌面环境） |
| `Observables.RestAPI.R3` | **Observables.Samples.RestAPI** |
| `Observables.RestAPI.Reactive` | **Observables.Samples.RestAPI.Reactive** |
| `Observables.SignalR.R3` | **Observables.Samples.SignalR** |
| `Observables.SignalR.Reactive` | **Observables.Samples.SignalR.Reactive** |
| `Observables.Mqtt.R3` | **Observables.Samples.Mqtt** |
| `Observables.Mqtt.Reactive` | **Observables.Samples.Mqtt.Reactive** |
| `Observables.WebSocket.R3` | **Observables.Samples.WebSocket** |
| `Observables.WebSocket.Reactive` | **Observables.Samples.WebSocket.Reactive** |
| `Observables.Grpc.R3` | **Observables.Samples.Grpc** |
| `Observables.Grpc.Reactive` | **Observables.Samples.Grpc.Reactive** |
| `Observables.Sse.R3` | **Observables.Samples.Sse** |
| `Observables.Sse.Reactive` | **Observables.Samples.Sse.Reactive** |
| `Observables.Nats.R3` | **Observables.Samples.Nats** |
| `Observables.Nats.Reactive` | **Observables.Samples.Nats.Reactive** |
| `Observables.Postgres.R3` | **Observables.Samples.Postgres** |
| `Observables.Postgres.Reactive` | **Observables.Samples.Postgres.Reactive** |
| `Observables.Redis.R3` | **Observables.Samples.Redis** |
| `Observables.Redis.Reactive` | **Observables.Samples.Redis.Reactive** |

预览版包：**仅推送 tag + NuGet**（不建 GitHub Release）。详见主仓 `AGENTS.md`。

## 构建与运行（NuGet，默认）

仅需 **.NET 8 SDK** — 无需本地同级 `../Observables` 克隆。

```powershell
dotnet restore Observables.Samples.slnx
dotnet build Observables.Samples.slnx

dotnet run --project Observables.Samples.Events
dotnet run --project Observables.Samples.Events.Reactive
dotnet run --project Observables.Samples.RestAPI
dotnet run --project Observables.Samples.RestAPI.Reactive
dotnet run --project Observables.Samples.SignalR
dotnet run --project Observables.Samples.SignalR.Reactive
dotnet run --project Observables.Samples.Mqtt
dotnet run --project Observables.Samples.Mqtt.Reactive
dotnet run --project Observables.Samples.WebSocket
dotnet run --project Observables.Samples.WebSocket.Reactive
dotnet run --project Observables.Samples.Grpc
dotnet run --project Observables.Samples.Grpc.Reactive
dotnet run --project Observables.Samples.Sse
dotnet run --project Observables.Samples.Sse.Reactive
dotnet run --project Observables.Samples.Nats
dotnet run --project Observables.Samples.Nats.Reactive
dotnet run --project Observables.Samples.Postgres
dotnet run --project Observables.Samples.Postgres.Reactive
dotnet run --project Observables.Samples.Redis
dotnet run --project Observables.Samples.Redis.Reactive

# Avalonia 路由事件（需要 GUI；不在 CI 中运行）
dotnet run --project Observables.Samples.Events.Routed
```

CI 使用 Nuke：`./build.cmd Ci`（构建并运行控制台示例；在 GitHub Actions 上**跳过** `Observables.Samples.Events.Routed`）。

`Directory.Build.props` 默认将 `ObservablesPackageVersion` 设为 **`0.5.1`**，且 `UseLocalObservables=false`。

## 本地联调 Observables 主仓（可选）

在同级克隆中开发源生成器时：

```powershell
dotnet build -p:UseLocalObservables=true
dotnet run --project Observables.Samples.Events -p:UseLocalObservables=true
```

需要存在 `../Observables/Observables.slnx`。详见 **`build/README-LocalSourceGenerators.md`**。

## 示例项目说明

| 项目 | 演示内容 |
|------|----------|
| **Observables.Samples.Events** | `Events()`、`EventHandlers()`、多订阅者 — 见各项目内 `README.md` |
| **Observables.Samples.Events.Reactive** | 经典事件的 `IObservable` 桥接 |
| **Observables.Samples.Events.Routed** | Avalonia `RoutedEvents()` / `<ObservableRoutedEvents>` — 见项目 `README.md` |
| **Observables.Samples.RestAPI** | `Task` + `Observable<T>`、列表 GET、基于 MockHttp 的 `ApiException` — 见项目 `README.md` |
| **Observables.Samples.RestAPI.Reactive** | `IObservable<T>` + `FirstAsync().ToTask()`、404 处理 |
| **Observables.Samples.SignalR** | `[Hub]` 代理注册校验（CI 无实时服务端）— 见项目 `README.md` |
| **Observables.Samples.SignalR.Reactive** | `[Hub]` IObservable 代理注册校验（CI 无实时服务端） |
| **Observables.Samples.Mqtt** | `[Mqtt]` 代理注册校验（CI 无 Broker）— 见项目 `README.md` |
| **Observables.Samples.Mqtt.Reactive** | `[Mqtt]` IObservable 代理注册校验（CI 无 Broker） |
| **Observables.Samples.WebSocket** | `[WebSocket]` 代理注册校验（CI 无实时服务端）— 见项目 `README.md` |
| **Observables.Samples.WebSocket.Reactive** | `[WebSocket]` IObservable 代理注册校验（CI 无实时服务端） |
| **Observables.Samples.Grpc** | `[Grpc]` 代理注册校验（CI 无实时服务端）— 见项目 `README.md` |
| **Observables.Samples.Grpc.Reactive** | `[Grpc]` IObservable 代理注册校验（CI 无实时服务端） |
| **Observables.Samples.Sse** | `[Sse]` 代理注册校验（CI 无实时服务端）— 见项目 `README.md` |
| **Observables.Samples.Sse.Reactive** | `[Sse]` IObservable 代理注册校验（CI 无实时服务端） |
| **Observables.Samples.Nats** | `[Nats]` subject 代理注册校验（CI 无服务端）— 见项目 `README.md` |
| **Observables.Samples.Nats.Reactive** | `[Nats]` IObservable 代理注册校验（CI 无服务端） |
| **Observables.Samples.Postgres** | `[Postgres]` LISTEN/NOTIFY 代理注册校验（CI 无服务端）— 见项目 `README.md` |
| **Observables.Samples.Postgres.Reactive** | `[Postgres]` IObservable LISTEN/NOTIFY 代理注册校验（CI 无服务端） |
| **Observables.Samples.Redis** | `[Redis]` Pub/Sub 代理注册校验（CI 无服务端）— 见项目 `README.md` |
| **Observables.Samples.Redis.Reactive** | `[Redis]` IObservable Pub/Sub 代理注册校验（CI 无服务端） |

## 文档

权威用户文档：**[Observables.Docs](https://github.com/Skymly/Observables.Docs)**。

## 相关仓库

| 仓库 | 角色 |
|------|------|
| [Observables](https://github.com/Skymly/Observables) | 源生成器与运行时 |
| [Observables.Docs](https://github.com/Skymly/Observables.Docs) | 用户文档站点 |

## 许可证

MIT — 见 [LICENSE](LICENSE)。
