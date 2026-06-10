namespace Observables.Samples.WebSocket;

internal static class SampleMetadata
{
    public static string Describe()
    {
#if LOCAL_OBSERVABLES
        return "Reference mode: local ../Observables WebSocket runtime + R3 generator";
#else
        return "Package mode: Observables.WebSocket.R3 0.1.0-preview6 (nuget.org)";
#endif
    }
}
