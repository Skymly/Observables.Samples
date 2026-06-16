namespace Observables.Samples.Events;

internal static class SampleMetadata
{
    public static string Describe()
    {
#if LOCAL_OBSERVABLES
        return "Reference mode: local ../Observables source generators";
#else
        return "Package mode: Observables.Events.R3 0.1.0 (nuget.org)";
#endif
    }
}
