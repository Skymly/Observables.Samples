namespace Observables.Samples.RestAPI;

internal static class SampleMetadata
{
    public static string Describe()
    {
#if LOCAL_OBSERVABLES
        return "Reference mode: local ../Observables RestAPI runtime + R3 generator";
#else
        return "Package mode: Observables.RestAPI.R3 0.1.6-preview1 (nuget.org)";
#endif
    }
}
