namespace Observables.Samples.Grpc.Reactive;

internal static class SampleMetadata
{
    public static string Describe()
    {
#if LOCAL_OBSERVABLES
        return "Reference mode: local ../Observables Grpc runtime + Reactive generator";
#else
        return "Package mode: Observables.Grpc.Reactive 0.1.0-preview6 (nuget.org)";
#endif
    }
}
