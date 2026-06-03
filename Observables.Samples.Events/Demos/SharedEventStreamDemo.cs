using Observables.Samples.Events.Models;
using R3;

namespace Observables.Samples.Events.Demos;

internal static class SharedEventStreamDemo
{
    public static void Run()
    {
        Console.WriteLine("-- Multiple subscribers on Events().CountChanged --");
        var counter = new CounterSource();
        using var subA = counter.Events().CountChanged.Subscribe(n => Console.WriteLine($"  subscriber A: {n}"));
        using var subB = counter.Events().CountChanged.Subscribe(n => Console.WriteLine($"  subscriber B: {n}"));

        counter.SetCount(10);
        counter.SetCount(11);
    }
}
