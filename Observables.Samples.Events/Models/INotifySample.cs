namespace Observables.Samples.Events.Models;

public interface INotifySample
{
    event EventHandler? SampleChanged;
}

public sealed class SampleNotifier : INotifySample
{
    public event EventHandler? SampleChanged;

    public void RaiseSampleChanged() => SampleChanged?.Invoke(this, EventArgs.Empty);
}
