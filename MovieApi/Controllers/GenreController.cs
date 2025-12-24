using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class GenresController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
        => Ok();

    [HttpPost]
    public IActionResult Create()
        => Ok();
}
