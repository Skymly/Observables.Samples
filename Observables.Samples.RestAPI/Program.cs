using Observables.Samples.RestAPI.Demos;

if (!IsLocalGeneratorBuild())
{
    Console.WriteLine("Observables.Samples.RestAPI requires a sibling Observables clone.");
    Console.WriteLine("Clone ../Observables and build with UseLocalObservables=true (default when Observables.slnx exists).");
    Console.WriteLine("See README.md and build/README-LocalSourceGenerators.md.");
    return;
}

Console.WriteLine("Observables.Samples.RestAPI — declarative HTTP (Task + R3 Observable)");
Console.WriteLine();

await MockHttpDemo.RunAsync();

Console.WriteLine();
Console.WriteLine("Done.");

static bool IsLocalGeneratorBuild()
{
#if LOCAL_OBSERVABLES
    return true;
#else
    return false;
#endif
}
