using AutoMapper;
using MovieApi.DTOs;
using MovieApi.Repositories.Interfaces;
using MovieApi.Services.Interfaces;

namespace MovieApi.Services;

public class MovieService : IMovieService
{
    private readonly IMovieRepository _movieRepository;
    private readonly IMapper _mapper;

    public MovieService(IMovieRepository movieRepository, IMapper mapper)
    {
        _movieRepository = movieRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<MovieDto>> GetAllAsync()
    {
        var movies = await _movieRepository.GetWithGenreAsync();
        return _mapper.Map<IEnumerable<MovieDto>>(movies);
    }
}
