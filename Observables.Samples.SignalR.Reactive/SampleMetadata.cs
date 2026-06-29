namespace Observables.Samples.SignalR.Reactive;

internal static class SampleMetadata
{
    public static string Describe()
    {
#if LOCAL_OBSERVABLES
        return "Reference mode: local ../Observables SignalR runtime + Reactive generator";
#else
        return "Package mode: Observables.SignalR.Reactive 0.1.2 (nuget.org)";
#endif
    }
}
