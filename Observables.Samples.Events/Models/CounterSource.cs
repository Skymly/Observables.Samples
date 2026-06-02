namespace Observables.Samples.Events.Models;

public sealed class CounterSource
{
    public event Action<int>? CountChanged;

    public void SetCount(int value) => CountChanged?.Invoke(value);
}
