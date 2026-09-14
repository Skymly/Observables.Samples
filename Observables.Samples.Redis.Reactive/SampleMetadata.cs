namespace Observables.Samples.Redis.Reactive;

internal static class SampleMetadata
{
    public static string Describe()
    {
#if LOCAL_OBSERVABLES
        return "Reference mode: local ../Observables Redis runtime + Reactive generator";
#else
        return "Package mode: Observables.Redis.Reactive (nuget.org)";
#endif
    }
}
