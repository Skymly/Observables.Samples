namespace Observables.Samples.SignalR.Reactive;

internal static class SampleMetadata
{
    public static string Describe()
    {
#if LOCAL_OBSERVABLES
        return "Reference mode: local ../Observables SignalR runtime + Reactive generator";
#else
        return "Package mode: Observables.SignalR.Reactive 0.1.1-preview1 (nuget.org)";
#endif
    }
}
