using Observables.Samples.Postgres.Demos;
using Observables.Samples.Live;

Console.WriteLine("Observables.Samples.Postgres - declarative PostgreSQL LISTEN/NOTIFY proxy (R3)");
Console.WriteLine(Observables.Samples.Postgres.SampleMetadata.Describe());
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
