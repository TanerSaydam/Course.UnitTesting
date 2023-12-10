using Microsoft.EntityFrameworkCore;
using UnderstandingDependecies.Api.Context;
using UnderstandingDependecies.Api.Models;

namespace UnderstandingDependecies.Api.Repositories;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _context;

    public UserRepository()
    {
        _context = new();
    }

    public async Task<IEnumerable<User>> GetAllAsync()
    {
        return await _context.Users.ToListAsync();
    }
}
