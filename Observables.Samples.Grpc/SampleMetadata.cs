namespace Observables.Samples.Grpc;

internal static class SampleMetadata
{
    public static string Describe()
    {
#if LOCAL_OBSERVABLES
        return "Local mode: Observables.Grpc.R3 source generators from sibling ../Observables";
#else
        return "Package mode: Observables.Grpc.R3 0.1.5 (nuget.org)";
#endif
    }
}
