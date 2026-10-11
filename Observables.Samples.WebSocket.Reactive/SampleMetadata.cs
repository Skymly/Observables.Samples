namespace Observables.Samples.WebSocket.Reactive;

internal static class SampleMetadata
{
    public static string Describe()
    {
#if LOCAL_OBSERVABLES
        return "Reference mode: local ../Observables WebSocket runtime + Reactive generator";
#else
        return "Package mode: Observables.WebSocket.Reactive 0.3.1 (nuget.org)";
#endif
    }
}
