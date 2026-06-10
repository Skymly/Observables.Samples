using Observables.Events.Reactive;
using Observables.Samples.Events.Models;
using System.Reactive.Linq;

Console.WriteLine("Observables.Samples.Events.Reactive â€?IObservable from classic events");
Console.WriteLine();

var click = new ClickSource();
using var clickSub = click.Events().Click.Subscribe(_ => Console.WriteLine("  Click"));
click.RaiseClick();

var counter = new CounterSource();
using var countSub = counter.Events().CountChanged.Subscribe(n => Console.WriteLine($"  Count = {n}"));
counter.SetCount(1);
counter.SetCount(2);

Console.WriteLine();
Console.WriteLine("Done.");
