# Observables.Samples

[English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | **日本語**

[![Build](https://github.com/Skymly/Observables.Samples/actions/workflows/build.yml/badge.svg)](https://github.com/Skymly/Observables.Samples/actions/workflows/build.yml)

[nuget.org](https://www.nuget.org/packages/Observables.Events.R3/0.5.1) 上の **`0.5.1`** NuGet メタパッケージを使用した **[Skymly/Observables](https://github.com/Skymly/Observables)** の実行可能なサンプルアプリケーション集です（Events、RestAPI、SignalR、Mqtt、WebSocket、Grpc、Sse、Nats、Postgres、Redis）。

| パッケージ | サンプルプロジェクト |
|------------|----------------------|
| `Observables.Events.R3` | **Observables.Samples.Events** |
| `Observables.Events.Reactive` | **Observables.Samples.Events.Reactive** |
| `Observables.Events.R3` + Avalonia routed | **Observables.Samples.Events.Routed**（ローカルデスクトップ専用） |
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

## ビルドと実行（NuGet、既定）

必要なのは **.NET 8 SDK** のみです — 兄弟ディレクトリ `../Observables` のクローンは不要です。

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

# Avalonia ルーテッドイベント（GUI が必要；CI では実行されません）
dotnet run --project Observables.Samples.Events.Routed
```

CI は Nuke `./build.cmd Ci` を使用します（コンソールサンプルをビルド・実行し、GitHub Actions 上では `Observables.Samples.Events.Routed` を**スキップ**します）。

`Directory.Build.props` は既定で `ObservablesPackageVersion` を **`0.5.1`**、`UseLocalObservables=false` に設定しています。

## ローカルの Observables リポジトリ利用（任意）

兄弟クローンでジェネレーターを開発する場合：

```powershell
dotnet build -p:UseLocalObservables=true
dotnet run --project Observables.Samples.Events -p:UseLocalObservables=true
```

`../Observables/Observables.slnx` が必要です。詳細は **`build/README-LocalSourceGenerators.md`** を参照してください。

## プロジェクト一覧

| プロジェクト | デモ内容 |
|--------------|----------|
| **Observables.Samples.Events** | `Events()`、`EventHandlers()`、複数購読者 — 各プロジェクト内 `README.md` 参照 |
| **Observables.Samples.Events.Reactive** | 従来イベントからの `IObservable` 変換 |
| **Observables.Samples.Events.Routed** | Avalonia `RoutedEvents()` / `<ObservableRoutedEvents>` — プロジェクト内 `README.md` 参照 |
| **Observables.Samples.RestAPI** | `Task` + `Observable<T>`、リスト GET、MockHttp を用いた `ApiException` — プロジェクト内 `README.md` 参照 |
| **Observables.Samples.RestAPI.Reactive** | `IObservable<T>` + `FirstAsync().ToTask()`、404 ハンドリング |
| **Observables.Samples.SignalR** | `[Hub]` プロキシ登録確認（CI にライブサーバーなし）— プロジェクト内 `README.md` 参照 |
| **Observables.Samples.SignalR.Reactive** | `[Hub]` IObservable プロキシ登録確認（CI にライブサーバーなし） |
| **Observables.Samples.Mqtt** | `[Mqtt]` プロキシ登録確認（CI にブローカーなし）— プロジェクト内 `README.md` 参照 |
| **Observables.Samples.Mqtt.Reactive** | `[Mqtt]` IObservable プロキシ登録確認（CI にブローカーなし） |
| **Observables.Samples.WebSocket** | `[WebSocket]` プロキシ登録確認（CI にライブサーバーなし）— プロジェクト内 `README.md` 参照 |
| **Observables.Samples.WebSocket.Reactive** | `[WebSocket]` IObservable プロキシ登録確認（CI にライブサーバーなし） |
| **Observables.Samples.Grpc** | `[Grpc]` プロキシ登録確認（CI にライブサーバーなし）— プロジェクト内 `README.md` 参照 |
| **Observables.Samples.Grpc.Reactive** | `[Grpc]` IObservable プロキシ登録確認（CI にライブサーバーなし） |
| **Observables.Samples.Sse** | `[Sse]` プロキシ登録確認（CI にライブサーバーなし）— プロジェクト内 `README.md` 参照 |
| **Observables.Samples.Sse.Reactive** | `[Sse]` IObservable プロキシ登録確認（CI にライブサーバーなし） |
| **Observables.Samples.Nats** | `[Nats]` subject プロキシ登録確認（CI にサーバーなし）— プロジェクト内 `README.md` 参照 |
| **Observables.Samples.Nats.Reactive** | `[Nats]` IObservable プロキシ登録確認（CI にサーバーなし） |
| **Observables.Samples.Postgres** | `[Postgres]` LISTEN/NOTIFY プロキシ登録確認（CI にサーバーなし）— プロジェクト内 `README.md` 参照 |
| **Observables.Samples.Postgres.Reactive** | `[Postgres]` IObservable LISTEN/NOTIFY プロキシ登録確認（CI にサーバーなし） |
| **Observables.Samples.Redis** | `[Redis]` Pub/Sub プロキシ登録確認（CI にサーバーなし）— プロジェクト内 `README.md` 参照 |
| **Observables.Samples.Redis.Reactive** | `[Redis]` IObservable Pub/Sub プロキシ登録確認（CI にサーバーなし） |

## ドキュメント

正典ドキュメント：**[Observables.Docs](https://github.com/Skymly/Observables.Docs)**。

## 関連リンク

| リポジトリ | 役割 |
|------------|------|
| [Observables](https://github.com/Skymly/Observables) | ジェネレーターとランタイム |
| [Observables.Docs](https://github.com/Skymly/Observables.Docs) | ユーザードキュメントサイト |

## ライセンス

MIT — [LICENSE](LICENSE) を参照してください。

> 補足：上流リポジトリのプレビュー版パッケージはタグ + NuGet のみで公開され、GitHub Release は作成されません。
