using Observables.Samples.Events.Models;
using R3;

namespace Observables.Samples.Events.Demos;

internal static class EventHandlersDemo
{
    public static void Run()
    {
        Console.WriteLine("-- EventHandlers(): EventHandler -> Observable<(object? sender, EventArgs e)> --");
        INotifySample notifier = new SampleNotifier();
        using var sub = notifier.EventHandlers().SampleChanged.Subscribe(tuple =>
            Console.WriteLine($"  SampleChanged sender={tuple.sender?.GetType().Name ?? "null"}"));

        ((SampleNotifier)notifier).RaiseSampleChanged();
    }
}
