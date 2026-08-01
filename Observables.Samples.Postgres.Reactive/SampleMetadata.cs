namespace Observables.Samples.Postgres.Reactive;

internal static class SampleMetadata
{
    public static string Describe()
    {
#if LOCAL_OBSERVABLES
        return "Reference mode: local ../Observables Postgres runtime + Reactive generator";
#else
        return "Package mode: Observables.Postgres.Reactive (nuget.org)";
#endif
    }
}
