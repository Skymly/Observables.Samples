namespace Observables.Samples.Mqtt.Reactive;

internal static class SampleMetadata
{
    public static string Describe()
    {
#if LOCAL_OBSERVABLES
        return "Reference mode: local ../Observables Mqtt runtime + Reactive generator";
#else
        return "Package mode: Observables.Mqtt.Reactive 0.1.0 (nuget.org)";
#endif
    }
}
