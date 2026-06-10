using Observables.Samples.RestAPI.Demos;

Console.WriteLine("Observables.Samples.RestAPI â€?declarative HTTP (Task + R3 Observable)");
Console.WriteLine(Observables.Samples.RestAPI.SampleMetadata.Describe());
Console.WriteLine();

await MockHttpDemo.RunAsync();

Console.WriteLine();
Console.WriteLine("Done.");
