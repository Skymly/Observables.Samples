namespace Observables.Samples.Events.Models;

public sealed class ClickSource
{
    public event Action? Click;

    public void RaiseClick() => Click?.Invoke();
}
