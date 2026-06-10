using Observables.Samples.Grpc.Demos;

Console.WriteLine("Observables.Samples.Grpc - declarative gRPC proxy (R3)");
Console.WriteLine(Observables.Samples.Grpc.SampleMetadata.Describe());
Console.WriteLine();

RegistrationDemo.Run();

Console.WriteLine();
Console.WriteLine("Done.");
