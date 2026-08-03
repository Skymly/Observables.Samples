using Observables.Samples.Postgres.Reactive.Demos;
using Observables.Samples.Live;

Console.WriteLine("Observables.Samples.Postgres.Reactive - declarative PostgreSQL LISTEN/NOTIFY proxy (IObservable)");
Console.WriteLine(Observables.Samples.Postgres.Reactive.SampleMetadata.Describe());
Console.WriteLine();

RegistrationDemo.Run();

Console.WriteLine();
if (args.Contains("--live", StringComparer.OrdinalIgnoreCase))
{
    await LiveDemo.RunAsync(Environment.GetEnvironmentVariable("POSTGRES_CONNECTION_STRING"));
}
else
{
    Console.WriteLine("Live Postgres demo skipped. Pass --live with PostgreSQL reachable via POSTGRES_CONNECTION_STRING.");
}

Console.WriteLine();
Console.WriteLine("Done.");
