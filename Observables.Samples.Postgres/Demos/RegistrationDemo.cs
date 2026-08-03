using Npgsql;
using Observables.Postgres;
using Observables.Samples.Postgres.Api;

namespace Observables.Samples.Postgres.Demos;

/// <summary>
/// Verifies source-generated LISTEN/NOTIFY proxy registration without a live PostgreSQL server (CI-safe when built locally).
/// </summary>
internal static class RegistrationDemo
{
    public static void Run()
    {
        Console.WriteLine("-- Postgres proxy factory (no live server) --");
        try
        {
            _ = PostgresService.For<IOrderHub>((NpgsqlConnection)null!);
            Console.WriteLine("  unexpected: null connection accepted");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine(
                "  PostgresService.For<IOrderHub>: factory registered (ArgumentNullException on null connection)");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"  missing generated factory: {ex.Message}");
        }

        Console.WriteLine();
        Console.WriteLine(
            "  Live LISTEN/NOTIFY demos need PostgreSQL and POSTGRES_CONNECTION_STRING; see README.md.");
    }
}
