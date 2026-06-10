namespace Observables.Samples.Sse.Reactive;

internal static class SampleMetadata
{
    public static string Describe()
    {
#if LOCAL_OBSERVABLES
        return "Reference mode: local ../Observables Sse runtime + Reactive generator";
#else
        return "Package mode: Observables.Sse.Reactive (nuget.org)";
#endif
    }
}
