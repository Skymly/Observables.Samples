namespace Observables.Samples.Mqtt;

internal static class SampleMetadata
{
    public static string Describe()
    {
#if LOCAL_OBSERVABLES
        return "Reference mode: local ../Observables Mqtt runtime + R3 generator";
#else
        return "Stub mode: Observables.Mqtt.R3 not on nuget.org yet — use -p:UseLocalObservables=true";
#endif
    }
}
