using FluentAssertions;
using UnderstandingDependecies.Api.Context;
using UnderstandingDependecies.Api.Repositories;
using UnderstandingDependecies.Api.Services;

namespace UnderstandingDependencies.Api.Tests.Unit;
public class UserServiceTests
{
    private readonly UserService _sut = new(new UserRepository(new ApplicationDbContext()));

    [Fact]
    public async Task GetAllAsync_ShouldReturnEmptyList_WhenNoUsersExist()
    {
        // Arrange

        // Act
        var users = await _sut.GetAllAsync();

        // Assert
        users.Should().BeEmpty();
    }
}
