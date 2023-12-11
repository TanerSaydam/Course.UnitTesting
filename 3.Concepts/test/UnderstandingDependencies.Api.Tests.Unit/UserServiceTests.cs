using FluentAssertions;
using NSubstitute;
using UnderstandingDependecies.Api.Models;
using UnderstandingDependecies.Api.Repositories;
using UnderstandingDependecies.Api.Services;

namespace UnderstandingDependencies.Api.Tests.Unit;
public class UserServiceTests
{
    private readonly UserService _sut;
    private readonly IUserRepository _userRepository = Substitute.For<IUserRepository>();
    //private readonly Mock<IUserRepository> _userRepository = new();
    public UserServiceTests()
    {
        _sut = new(_userRepository);
    }

    [Fact]
    public async Task GetAllAsync_ShouldReturnEmptyList_WhenNoUsersExist()
    {
        // Arrange
        _userRepository.GetAllAsync().Returns(Array.Empty<User>());
        //_userRepository.Setup(s=> s.GetAllAsync()).ReturnsAsync(Array.Empty<User>());

        // Act
        var users = await _sut.GetAllAsync();

        // Assert
        users.Should().BeEmpty();
    }

    [Fact]
    public async Task GetAllAsync_ShouldReturnAListOfUsers_WhenUsersExist()
    {
        // Arrange
        var expectedUsers = new[]
        {
            new User()
            {
                Id = 1,
                FullName = "Taner Saydam",
                Age = 33,
                DateOfBirthDate = new(1989,09,03)
            }
        };
        _userRepository.GetAllAsync().Returns(expectedUsers);

        // Act
        var users = await _sut.GetAllAsync();

        // Assert
        users.Should().NotBeEmpty();
    }
}
