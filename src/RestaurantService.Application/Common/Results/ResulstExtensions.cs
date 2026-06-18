using Microsoft.AspNetCore.Mvc;

namespace RestaurantService.Application.Common.Results;

public static class ResultExtensions
{
    public static IActionResult ToActionResult(this Result result)
    {
        if (result.IsSuccess)
            return new OkObjectResult(result);

        return new ObjectResult(result)
        {
            StatusCode = (int)result.Status,
        };
    }

    public static IActionResult ToActionResult<T>(this Result<T> result)
    {
        if (result.IsSuccess)
            return new OkObjectResult(result);

        return new ObjectResult(result)
        {
            StatusCode = (int)result.Status,
        };
    }
}
