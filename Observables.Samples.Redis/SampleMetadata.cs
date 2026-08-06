namespace Observables.Samples.Redis;

internal static class SampleMetadata
{
    public static string Describe()
    {
#if LOCAL_OBSERVABLES
        return "Reference mode: local ../Observables Redis runtime + R3 generator";
#else
        return "Package mode: Observables.Redis.R3 (nuget.org)";
#endif
    }
}
