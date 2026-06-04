using Observables.SignalR;
using Observables.Samples.SignalR.Models;
using R3;

namespace Observables.Samples.SignalR.Api;

[Hub]
public interface IChatHub
{
    [HubInvoke]
    Observable<int> GetUserCount();

    [HubOn("ReceiveMessage")]
    Observable<ChatMessage> ReceiveMessage { get; }
}
