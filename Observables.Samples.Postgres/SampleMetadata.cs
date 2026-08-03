namespace Observables.Samples.Postgres;

internal static class SampleMetadata
{
    public static string Describe()
    {
#if LOCAL_OBSERVABLES
        return "Reference mode: local ../Observables Postgres runtime + R3 generator";
#else
        return "Package mode: Observables.Postgres.R3 (nuget.org)";
#endif
    }
}
