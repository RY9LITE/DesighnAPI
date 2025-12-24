using Microsoft.AspNetCore.Mvc;
using MovieApi.Services.Interfaces;

namespace MovieApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MoviesController : ControllerBase
{
    private readonly IMovieService _movieService;

    public MoviesController(IMovieService movieService)
    {
        _movieService = movieService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await _movieService.GetAllAsync();
        return Ok(result);
    }
}
