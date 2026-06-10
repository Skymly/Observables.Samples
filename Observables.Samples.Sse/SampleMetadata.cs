namespace Observables.Samples.Sse;

internal static class SampleMetadata
{
    public static string Describe()
    {
#if LOCAL_OBSERVABLES
        return "Reference mode: local ../Observables Sse runtime + R3 generator";
#else
        return "Package mode: Observables.Sse.R3 (nuget.org)";
#endif
    }
}
