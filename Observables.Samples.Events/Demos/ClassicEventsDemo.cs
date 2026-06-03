using Observables.Samples.Events.Models;
using R3;

namespace Observables.Samples.Events.Demos;

internal static class ClassicEventsDemo
{
    public static void Run()
    {
        Console.WriteLine("-- Events(): Action -> Observable<Unit> --");
        var click = new ClickSource();
        using var clickSub = click.Events().Click.Subscribe(_ => Console.WriteLine("  Click"));

        click.RaiseClick();

        Console.WriteLine("-- Events(): Action<T> -> Observable<T> --");
        var counter = new CounterSource();
        using var countSub = counter.Events().CountChanged.Subscribe(n => Console.WriteLine($"  Count = {n}"));

        counter.SetCount(1);
        counter.SetCount(2);
    }
}
