namespace Observables.Samples.Nats.Reactive;

internal static class SampleMetadata
{
    public static string Describe()
    {
#if LOCAL_OBSERVABLES
        return "Reference mode: local ../Observables Nats runtime + Reactive generator";
#else
        return "Package mode: Observables.Nats.Reactive (nuget.org)";
#endif
    }
}
