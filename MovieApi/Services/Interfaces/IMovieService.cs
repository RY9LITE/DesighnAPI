using MovieApi.DTOs;

namespace MovieApi.Services.Interfaces;

public interface IMovieService
{
    Task<IEnumerable<MovieDto>> GetAllAsync();
}
