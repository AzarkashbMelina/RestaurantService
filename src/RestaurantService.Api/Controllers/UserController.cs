using Microsoft.AspNetCore.Mvc;
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

    //[HttpGet]
    //public async Task<IActionResult> GetById([FromQuery] int id)
    //{
    //    if (id <= 0)
    //    {
    //        return result
    //    }
    //}
}
