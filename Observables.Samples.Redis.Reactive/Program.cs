using Observables.Samples.Redis.Reactive.Demos;

Console.WriteLine("Observables.Samples.Redis.Reactive - declarative Redis Pub/Sub proxy (IObservable)");
Console.WriteLine(Observables.Samples.Redis.Reactive.SampleMetadata.Describe());
Console.WriteLine();

RegistrationDemo.Run();

Console.WriteLine();
Console.WriteLine("Done.");
