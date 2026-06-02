# Observables.Samples.Events

Console sample for **Observables.Events.R3.SourceGenerators** (classic CLR events → R3).

## Prerequisites

- Sibling clone: `../Observables` with `Observables.slnx`
- .NET 8 SDK
- Package [R3](https://www.nuget.org/packages/R3) 1.3.0

## Project references (local)

```xml
<ProjectReference Include="$(ObservablesSharedProject)">
  <ReferenceOutputAssembly>false</ReferenceOutputAssembly>
  <OutputItemType>Analyzer</OutputItemType>
</ProjectReference>
<ProjectReference Include="$(ObservablesEventsR3Generator)">
  <ReferenceOutputAssembly>false</ReferenceOutputAssembly>
  <OutputItemType>Analyzer</OutputItemType>
</ProjectReference>
```

Properties `ObservablesSharedProject` and `ObservablesEventsR3Generator` are defined in the repo root `Directory.Build.props`.

Entry method name: `Events()` on branches that ship the rename; `FromEvents()` on `main` until that change is merged.

## Example source

```csharp
using R3;

namespace Observables.Samples.Events.Models;

public sealed class ClickSource
{
    public event Action? Click;
    public void RaiseClick() => Click?.Invoke();
}

// In Program.cs after wiring analyzers:
var source = new ClickSource();
using var sub = source.FromEvents().Click.Subscribe(_ => Console.WriteLine("Clicked"));
source.RaiseClick();
```

When **Observables.Events.R3** is published to NuGet, this project will switch to `PackageReference` with `IncludeAssets="analyzers"` (see root `build/README-LocalSourceGenerators.md`).
