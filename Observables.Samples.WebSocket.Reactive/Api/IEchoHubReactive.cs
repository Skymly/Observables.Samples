using Observables.WebSocket;
using System.Reactive;

namespace Observables.Samples.WebSocket.Reactive.Api;

[WebSocket]
public interface IEchoHubReactive
{
    [WebSocketConnect]
    IObservable<Unit> Connect(Uri uri, CancellationToken cancellationToken = default);

    [WebSocketClose]
    IObservable<Unit> Close(CancellationToken cancellationToken = default);

    [WebSocketSend]
    IObservable<Unit> SendText(string message, CancellationToken cancellationToken = default);

    [WebSocketReceive("echo")]
    IObservable<string> EchoText { get; }
}
