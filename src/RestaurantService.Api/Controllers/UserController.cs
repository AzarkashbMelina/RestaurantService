using Microsoft.AspNetCore.Mvc;
using RestaurantService.Application.Common.Results;
using RestaurantService.Application.Contracts;

namespace RestaurantService.Api.Controllers;

[ApiController]
[Route("/[controller]/[action]")] //token based
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly ILogger<UserController> _logger;

    public UserController(IUserService userService, ILogger<UserController> logger)
    {
        _userService = userService;
        _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> GetById([FromQuery] int id)
    {
        if (id <= 0)
        {
            return Result.Failure(Error.UserNotFound).ToActionResult();
        }

        var user = await _userService.GetById(id);

        if(user is not null)
        {
            return Result.Success(user).ToActionResult();
        }
        else
        {
            return Result.Failure(Error.UserNotFound).ToActionResult();
        }
    }
}
