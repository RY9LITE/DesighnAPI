using Microsoft.EntityFrameworkCore;
using MovieApi.Data;
using MovieApi.Models;
using MovieApi.Repositories.Interfaces;

namespace MovieApi.Repositories;

public class GenreRepository : IGenreRepository
{
    private readonly AppDbContext _context;

    public GenreRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Genre>> GetAllAsync()
        => await _context.Genres.ToListAsync();

    public async Task<Genre?> GetByIdAsync(int id)
        => await _context.Genres.FindAsync(id);

    public async Task AddAsync(Genre entity)
        => await _context.Genres.AddAsync(entity);

    public void Update(Genre entity)
        => _context.Genres.Update(entity);

    public void Delete(Genre entity)
        => _context.Genres.Remove(entity);

    public async Task SaveAsync()
        => await _context.SaveChangesAsync();
}
