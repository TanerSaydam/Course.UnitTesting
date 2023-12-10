using System.Diagnostics;
using UnderstandingDependecies.Api.Models;
using UnderstandingDependecies.Api.Repositories;

namespace UnderstandingDependecies.Api.Services;

public class UserService
{
    private readonly IUserRepository _userRepository;
    private readonly ILogger<UserService> _logger;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
        _logger = new Logger<UserService>(new LoggerFactory());
    }

    public async Task<IEnumerable<User>> GetAllAsync()
    {
        _logger.LogInformation("Retrieving all users");
        var stopWatch = Stopwatch.StartNew();
        try
        {
            var users = await _userRepository.GetAllAsync();
            return users;
        }
        finally
        {
            stopWatch.Stop();
            _logger.LogInformation("All users retrieved in {0}ms", stopWatch.ElapsedMilliseconds);
        }
    }
}
