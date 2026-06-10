using Observables.Samples.Grpc.Reactive.Demos;

Console.WriteLine("Observables.Samples.Grpc.Reactive - declarative gRPC proxy (IObservable)");
Console.WriteLine(Observables.Samples.Grpc.Reactive.SampleMetadata.Describe());
Console.WriteLine();

RegistrationDemo.Run();

Console.WriteLine();
Console.WriteLine("Done.");
