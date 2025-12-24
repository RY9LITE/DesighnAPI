using MovieApi.Models;

namespace MovieApi.Repositories.Interfaces;

public interface IMovieRepository : IRepository<Movie>
{
    Task<IEnumerable<Movie>> GetWithGenreAsync();
}
