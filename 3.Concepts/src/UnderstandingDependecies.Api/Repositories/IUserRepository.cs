using UnderstandingDependecies.Api.Models;

namespace UnderstandingDependecies.Api.Repositories;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetAllAsync();
}
