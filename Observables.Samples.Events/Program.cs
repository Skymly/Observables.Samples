using Observables.Samples.Events.Demos;

Console.WriteLine("Observables.Samples.Events - R3 classic event wrappers");
Console.WriteLine(Observables.Samples.Events.SampleMetadata.Describe());
Console.WriteLine();

ClassicEventsDemo.Run();
Console.WriteLine();
EventHandlersDemo.Run();
Console.WriteLine();
SharedEventStreamDemo.Run();

Console.WriteLine();
Console.WriteLine("Done.");
