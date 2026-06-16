namespace Observables.Samples.SignalR;

internal static class SampleMetadata
{
    public static string Describe()
    {
#if LOCAL_OBSERVABLES
        return "Reference mode: local ../Observables SignalR runtime + R3 generator";
#else
        return "Package mode: Observables.SignalR.R3 0.1.0 (nuget.org)";
#endif
    }
}
