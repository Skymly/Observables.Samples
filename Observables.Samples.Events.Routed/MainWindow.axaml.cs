using Avalonia.Controls;
using Avalonia.Interactivity;
using Observables.Events.R3;
using R3;

namespace Observables.Samples.Events.Routed;

public partial class MainWindow : Window
{
    readonly IDisposable _clickSubscription;

    public MainWindow()
    {
        InitializeComponent();

        _clickSubscription = ((Panel)HostPanel)
            .AttachedRoutedEvent(Button.ClickEvent, RoutingStrategies.Bubble, handledEventsToo: false)
            .Subscribe(_ => StatusText.Text = "AttachedRoutedEvent(Button.ClickEvent) observed");
    }

    protected override void OnClosed(EventArgs e)
    {
        _clickSubscription.Dispose();
        base.OnClosed(e);
    }
}
