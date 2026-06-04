#if LOCAL_OBSERVABLES
using Observables.Samples.Mqtt.Demos;
#endif

Console.WriteLine("Observables.Samples.Mqtt — declarative MQTT topic proxy (R3)");
Console.WriteLine(Observables.Samples.Mqtt.SampleMetadata.Describe());
Console.WriteLine();

#if LOCAL_OBSERVABLES
RegistrationDemo.Run();
#else
Console.WriteLine(
    "NuGet: Observables.Mqtt.R3 is not on nuget.org yet (after 0.1.0-preview3).");
Console.WriteLine(
    "Build with sibling ../Observables: dotnet run -p:UseLocalObservables=true --project Observables.Samples.Mqtt");
#endif

Console.WriteLine();
Console.WriteLine("Done.");
