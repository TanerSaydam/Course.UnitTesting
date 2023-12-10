﻿using Microsoft.AspNetCore.Mvc;
using UnderstandingDependecies.Api.Services;

namespace UnderstandingDependecies.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly UserService _userService;

    public UsersController()
    {
        _userService = new UserService();
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var users = await _userService.GetAllAsync();
        return Ok(users);
    }
}
