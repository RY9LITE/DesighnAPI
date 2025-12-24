using Microsoft.EntityFrameworkCore;
using MovieApi.Data;
using MovieApi.Models;
using MovieApi.Repositories.Interfaces;

namespace MovieApi.Repositories;

public class MovieRepository : IMovieRepository
{
    private readonly AppDbContext _context;

    public MovieRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Movie>> GetAllAsync()
        => await _context.Movies.ToListAsync();

    public async Task<IEnumerable<Movie>> GetWithGenreAsync()
        => await _context.Movies.Include(m => m.Genre).ToListAsync();

    public async Task<Movie?> GetByIdAsync(int id)
        => await _context.Movies.FindAsync(id);

    public async Task AddAsync(Movie entity)
        => await _context.Movies.AddAsync(entity);

    public void Update(Movie entity)
        => _context.Movies.Update(entity);

    public void Delete(Movie entity)
        => _context.Movies.Remove(entity);

    public async Task SaveAsync()
        => await _context.SaveChangesAsync();
}
