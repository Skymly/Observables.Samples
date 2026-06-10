using Observables.SignalR;
using Observables.Samples.SignalR.Models;

namespace Observables.Samples.SignalR.Reactive.Api;

[Hub]
public interface IChatHubReactive
{
    [HubInvoke]
    IObservable<int> GetUserCount();

    [HubOn("ReceiveMessage")]
    IObservable<ChatMessage> ReceiveMessage { get; }
}
