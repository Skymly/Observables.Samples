using MQTTnet.Client;
using Observables.Mqtt;
using Observables.Samples.Mqtt.Reactive.Api;

namespace Observables.Samples.Mqtt.Reactive.Demos;

/// <summary>
/// Verifies source-generated topic proxy registration without a live MQTT broker (CI-safe).
/// </summary>
internal static class RegistrationDemo
{
    public static void Run()
    {
        Console.WriteLine("-- Topic proxy factory (no live broker) --");
        try
        {
            _ = MqttService.For<ISensorTopicsReactive>((IMqttClient)null!);
            Console.WriteLine("  unexpected: null client accepted");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine(
                "  MqttService.For<ISensorTopicsReactive>: factory registered (ArgumentNullException on null client)");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"  missing generated factory: {ex.Message}");
        }

        Console.WriteLine();
        Console.WriteLine(
            "  Live publish/subscribe demos need IMqttClient connected to a broker; see README.md.");
    }
}
