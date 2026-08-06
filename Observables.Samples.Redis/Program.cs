using Observables.Samples.Redis.Demos;

Console.WriteLine("Observables.Samples.Redis - declarative Redis Pub/Sub proxy (R3)");
Console.WriteLine(Observables.Samples.Redis.SampleMetadata.Describe());
Console.WriteLine();

RegistrationDemo.Run();

Console.WriteLine();
Console.WriteLine("Done.");
