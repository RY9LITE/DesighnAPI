using Microsoft.AspNetCore.Mvc;
using MovieApi.Services.Interfaces;

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
    public async Task<IActionResult> GetAll()
        => Ok(await _movieService.GetAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
        => Ok($"Movie {id}");

    [HttpPost]
    public IActionResult Create()
        => Ok("Created");

    [HttpPut("{id}")]
    public IActionResult Update(int id)
        => Ok($"Updated {id}");

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
        => Ok($"Deleted {id}");
}
