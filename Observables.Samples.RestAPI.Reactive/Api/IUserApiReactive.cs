using Observables.RestAPI;
using Observables.Samples.RestAPI.Models;

namespace Observables.Samples.RestAPI.Reactive.Api;

public interface IUserApiReactive
{
    [Get("/users/{id}")]
    IObservable<User> GetUserObservable(int id);
}
