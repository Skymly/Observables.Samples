using Npgsql;
using Observables.Postgres;
#if OBSERVABLES_SAMPLE_REACTIVE
using Observables.Samples.Postgres.Reactive.Api;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
#else
using Observables.Samples.Postgres.Api;
using R3;
#endif

namespace Observables.Samples.Live;

internal static class LiveDemo
{
    static readonly TimeSpan Timeout = TimeSpan.FromSeconds(15);

    /// <summary>
    /// LISTEN/NOTIFY needs a dedicated session per role; disable pooling on the connection string.
    /// </summary>
    public static async Task RunAsync(string? connectionStringFromEnv)
    {
        var builder = new NpgsqlConnectionStringBuilder(
            connectionStringFromEnv
            ?? "Host=127.0.0.1;Port=5432;Database=postgres;Username=postgres;Password=postgres")
        {
            Pooling = false,
        };
        var connectionString = builder.ConnectionString;

        Console.WriteLine("-- Live PostgreSQL LISTEN/NOTIFY (Pooling=false) --");
        using var cancellation = new CancellationTokenSource(Timeout);

        await using var listener = new NpgsqlConnection(connectionString);
        await listener.OpenAsync(cancellation.Token);

        await using var notifier = new NpgsqlConnection(connectionString);
        await notifier.OpenAsync(cancellation.Token);

#if OBSERVABLES_SAMPLE_REACTIVE
        var listenerHub = PostgresService.For<IOrderHubReactive>(listener);
        var notifierHub = PostgresService.For<IOrderHubReactive>(notifier);
        const string payload = "hello-from-sample";
        var received = listenerHub.Ping.Timeout(Timeout).FirstAsync().ToTask(cancellation.Token);
#else
        var listenerHub = PostgresService.For<IOrderHub>(listener);
        var notifierHub = PostgresService.For<IOrderHub>(notifier);
        const string payload = "hello-from-sample";
        var received = listenerHub.Ping.FirstAsync(cancellation.Token);
#endif

        await Task.Delay(250, cancellation.Token);

#if OBSERVABLES_SAMPLE_REACTIVE
        await notifierHub.PublishPing(payload).Timeout(Timeout).FirstAsync().ToTask(cancellation.Token);
#else
        await notifierHub.PublishPing(payload).FirstAsync(cancellation.Token);
#endif

        Console.WriteLine($"  samples_ping -> \"{await received}\"");
    }
}
