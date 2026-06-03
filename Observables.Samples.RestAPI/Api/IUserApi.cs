using Observables.RestAPI;
using Observables.Samples.RestAPI.Models;
using R3;

namespace Observables.Samples.RestAPI.Api;

public interface IUserApi
{
    [Get("/users/{id}")]
    Task<User> GetUserAsync(int id);

    [Get("/users/{id}")]
    Observable<User> GetUserObservable(int id);

    [Get("/users")]
    Task<IReadOnlyList<User>> ListUsersAsync();
}
