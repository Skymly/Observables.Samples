# Observables.Samples

[English](README.md) | [简体中文](README.zh-CN.md) | **繁體中文** | [日本語](README.ja.md)

**[Skymly/Observables](https://github.com/Skymly/Observables)** 的可執行範例應用程式集，使用 [nuget.org](https://www.nuget.org/packages/Observables.Events.R3/0.5.1) 上 **`0.5.1`** 版本的 NuGet 中繼套件（涵蓋 Events、RestAPI、SignalR、Mqtt、WebSocket、Grpc、Sse、Nats、Postgres 與 Redis）。

| 套件名稱 | 範例專案 |
|----------|----------|
| `Observables.Events.R3` | **Observables.Samples.Events** |
| `Observables.Events.Reactive` | **Observables.Samples.Events.Reactive** |
| `Observables.Events.R3` + Avalonia routed | **Observables.Samples.Events.Routed**（僅限本機桌面環境） |
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

預覽版套件：**僅推送 tag + NuGet**（不建立 GitHub Release）。請參閱主儲存庫 `AGENTS.md`。

## 建置與執行（NuGet，預設）

僅需 **.NET 8 SDK** — 無須本機同層 `../Observables` 複製目錄。

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

# Avalonia 路由事件（需要 GUI；不會於 CI 執行）
dotnet run --project Observables.Samples.Events.Routed
```

CI 使用 Nuke：`./build.cmd Ci`（建置並執行主控台範例；在 GitHub Actions 上會**略過** `Observables.Samples.Events.Routed`）。

`Directory.Build.props` 預設將 `ObservablesPackageVersion` 設為 **`0.5.1`**，且 `UseLocalObservables=false`。

## 本機連用 Observables 主儲存庫（選用）

在同層目錄開發原始碼產生器時：

```powershell
dotnet build -p:UseLocalObservables=true
dotnet run --project Observables.Samples.Events -p:UseLocalObservables=true
```

需要存在 `../Observables/Observables.slnx`。詳情請見 **`build/README-LocalSourceGenerators.md`**。

## 專案一覽

| 專案 | 示範內容 |
|------|----------|
| **Observables.Samples.Events** | `Events()`、`EventHandlers()`、多訂閱者 — 請見專案內 `README.md` |
| **Observables.Samples.Events.Reactive** | 傳統事件的 `IObservable` 橋接 |
| **Observables.Samples.Events.Routed** | Avalonia `RoutedEvents()` / `<ObservableRoutedEvents>` — 請見專案內 `README.md` |
| **Observables.Samples.RestAPI** | `Task` + `Observable<T>`、清單 GET、搭配 MockHttp 的 `ApiException` — 請見專案內 `README.md` |
| **Observables.Samples.RestAPI.Reactive** | `IObservable<T>` + `FirstAsync().ToTask()`、404 處理 |
| **Observables.Samples.SignalR** | `[Hub]` 代理註冊檢查（CI 無即時伺服器）— 請見專案內 `README.md` |
| **Observables.Samples.SignalR.Reactive** | `[Hub]` IObservable 代理註冊檢查（CI 無即時伺服器） |
| **Observables.Samples.Mqtt** | `[Mqtt]` 代理註冊檢查（CI 無 Broker）— 請見專案內 `README.md` |
| **Observables.Samples.Mqtt.Reactive** | `[Mqtt]` IObservable 代理註冊檢查（CI 無 Broker） |
| **Observables.Samples.WebSocket** | `[WebSocket]` 代理註冊檢查（CI 無即時伺服器）— 請見專案內 `README.md` |
| **Observables.Samples.WebSocket.Reactive** | `[WebSocket]` IObservable 代理註冊檢查（CI 無即時伺服器） |
| **Observables.Samples.Grpc** | `[Grpc]` 代理註冊檢查（CI 無即時伺服器）— 請見專案內 `README.md` |
| **Observables.Samples.Grpc.Reactive** | `[Grpc]` IObservable 代理註冊檢查（CI 無即時伺服器） |
| **Observables.Samples.Sse** | `[Sse]` 代理註冊檢查（CI 無即時伺服器）— 請見專案內 `README.md` |
| **Observables.Samples.Sse.Reactive** | `[Sse]` IObservable 代理註冊檢查（CI 無即時伺服器） |
| **Observables.Samples.Nats** | `[Nats]` subject 代理註冊檢查（CI 無伺服器）— 請見專案內 `README.md` |
| **Observables.Samples.Nats.Reactive** | `[Nats]` IObservable 代理註冊檢查（CI 無伺服器） |
| **Observables.Samples.Postgres** | `[Postgres]` LISTEN/NOTIFY 代理註冊檢查（CI 無伺服器）— 請見專案內 `README.md` |
| **Observables.Samples.Postgres.Reactive** | `[Postgres]` IObservable LISTEN/NOTIFY 代理註冊檢查（CI 無伺服器） |
| **Observables.Samples.Redis** | `[Redis]` Pub/Sub 代理註冊檢查（CI 無伺服器）— 請見專案內 `README.md` |
| **Observables.Samples.Redis.Reactive** | `[Redis]` IObservable Pub/Sub 代理註冊檢查（CI 無伺服器） |

## 文件

權威使用者文件：**[Observables.Docs](https://github.com/Skymly/Observables.Docs)**。

## 相關連結

| 儲存庫 | 角色 |
|--------|------|
| [Observables](https://github.com/Skymly/Observables) | 原始碼產生器與執行階段 |
| [Observables.Docs](https://github.com/Skymly/Observables.Docs) | 使用者文件網站 |

## 授權條款

MIT — 請參閱 [LICENSE](LICENSE)。
