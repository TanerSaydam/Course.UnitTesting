using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using Users.Api.Controllers;
using Users.Api.DTOs;
using Users.Api.Models;
using Users.Api.Services;

namespace Users.Api.Tests.Unit;
public class UserControllerTests
{
    private readonly UsersController _sut;
    private readonly IUserService _userService = Substitute.For<IUserService>();

    public UserControllerTests()
    {
        _sut = new(_userService);
    }

    [Fact]
    public async Task GetAll_ShouldReturnUsers()
    {
        // Arrange
        _userService.GetAllAsync().Returns(Enumerable.Empty<User>().ToList());

        // Act
        var result = (OkObjectResult)await _sut.GetAll(default);

        // Assert
        result.StatusCode.Should().Be(200);
    }

    [Fact]
    public async Task GetById_ShouldReturnUser()
    {
        // Arrange
        var userId = Guid.NewGuid();
        var user = new User()
        {
            Id = userId,
            FullName = "Taner Saydam"
        };
        _userService.GetByIdAsync(userId).Returns(user);

        // Act
        var result = (OkObjectResult)await _sut.GetById(userId,default);

        // Assert
        result.StatusCode.Should().Be(200);
    }

    [Fact]
    public async Task Create_ShouldReturnTrue()
    {
        // Arrange
        CreateUserDto request = new("Taner Saydam");
        _userService.CreateAsync(request).Returns(true);

        // Act
        var result = (OkObjectResult)await _sut.Create(request, default);

        // Assert
        result.StatusCode.Should().Be(200);
    }

    [Fact]
    public async Task DeleteById_ShouldReturnTrue()
    {
        // Arrange
        var userId = Guid.NewGuid();
        _userService.DeleteByIdAsync(userId).Returns(true);

        // Act
        var result = (OkObjectResult)await _sut.DeleteById(userId, default);

        // Assert
        result.StatusCode.Should().Be(200);
    }
}
