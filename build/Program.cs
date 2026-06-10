using Nuke.Common;
using Nuke.Common.Execution;
using Nuke.Common.IO;
using Nuke.Common.Tools.DotNet;

using static Nuke.Common.Tools.DotNet.DotNetTasks;

[UnsetVisualStudioEnvironmentVariables]
sealed class Build : NukeBuild
{
    [Parameter("Build configuration (Debug/Release)")]
    readonly string Configuration = IsLocalBuild ? "Debug" : "Release";

    [Parameter("Use sibling Observables repo instead of NuGet packages")]
    readonly bool UseLocalObservables = false;

    AbsolutePath Root => RootDirectory;

    static readonly (string RelativePath, bool RunAfterBuild)[] SampleProjects =
    [
        ("Observables.Samples.Events/Observables.Samples.Events.csproj", true),
        ("Observables.Samples.RestAPI/Observables.Samples.RestAPI.csproj", true),
        ("Observables.Samples.Events.Reactive/Observables.Samples.Events.Reactive.csproj", true),
        ("Observables.Samples.RestAPI.Reactive/Observables.Samples.RestAPI.Reactive.csproj", true),
        ("Observables.Samples.SignalR/Observables.Samples.SignalR.csproj", true),
        ("Observables.Samples.Mqtt/Observables.Samples.Mqtt.csproj", true),
        ("Observables.Samples.WebSocket/Observables.Samples.WebSocket.csproj", true),
        ("Observables.Samples.Grpc/Observables.Samples.Grpc.csproj", true),
        ("Observables.Samples.SignalR.Reactive/Observables.Samples.SignalR.Reactive.csproj", true),
        ("Observables.Samples.Mqtt.Reactive/Observables.Samples.Mqtt.Reactive.csproj", true),
        ("Observables.Samples.WebSocket.Reactive/Observables.Samples.WebSocket.Reactive.csproj", true),
        ("Observables.Samples.Grpc.Reactive/Observables.Samples.Grpc.Reactive.csproj", true),
        ("Observables.Samples.Events.Routed/Observables.Samples.Events.Routed.csproj", false),
    ];

    public static int Main() => Execute<Build>(x => x.Ci);

    Target Ci => _ => _
        .Executes(() =>
        {
            foreach ((string relativePath, bool runAfterBuild) in GetProjectsForCi())
            {
                AbsolutePath projectFile = Root / relativePath;
                Assert.FileExists(projectFile, $"Sample project not found: {projectFile}");

                DotNetBuild(s => s
                    .SetProjectFile(projectFile)
                    .SetConfiguration(Configuration)
                    .SetProperty("UseLocalObservables", UseLocalObservables));

                if (runAfterBuild)
                {
                    DotNetRun(s => s
                        .SetProjectFile(projectFile)
                        .SetConfiguration(Configuration)
                        .SetNoRestore(true)
                        .SetNoBuild(true));
                }
            }
        });

    IEnumerable<(string RelativePath, bool RunAfterBuild)> GetProjectsForCi()
    {
        foreach ((string relativePath, bool runAfterBuild) in SampleProjects)
        {
            if (relativePath.Contains("Events.Routed", StringComparison.Ordinal))
            {
                continue;
            }

            yield return (relativePath, runAfterBuild);
        }
    }
}
