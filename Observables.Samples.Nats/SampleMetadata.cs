namespace Observables.Samples.Nats;

internal static class SampleMetadata
{
    public static string Describe()
    {
#if LOCAL_OBSERVABLES
        return "Reference mode: local ../Observables Nats runtime + R3 generator";
#else
        return "Package mode: Observables.Nats.R3 (nuget.org)";
#endif
    }
}
