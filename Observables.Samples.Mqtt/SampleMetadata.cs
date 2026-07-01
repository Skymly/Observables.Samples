namespace Observables.Samples.Mqtt;

internal static class SampleMetadata
{
    public static string Describe()
    {
#if LOCAL_OBSERVABLES
        return "Reference mode: local ../Observables Mqtt runtime + R3 generator";
#else
        return "Package mode: Observables.Mqtt.R3 0.1.6-preview1 (nuget.org)";
#endif
    }
}
