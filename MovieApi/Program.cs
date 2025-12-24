using MovieApi.Data;
using MovieApi.Repositories;
using MovieApi.Repositories.Interfaces;
using MovieApi.Services;
using MovieApi.Services.Interfaces;
using MovieApi.Mapping;
using MovieApi.Middleware;
using Microsoft.EntityFrameworkCore;

namespace MovieApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(
                    builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddScoped<IGenreRepository, GenreRepository>();
            builder.Services.AddScoped<IMovieRepository, MovieRepository>();

            builder.Services.AddScoped<IMovieService, MovieService>();

            builder.Services.AddAutoMapper(typeof(MappingProfile));

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            app.UseMiddleware<ExceptionHandlingMiddleware>();

            app.UseSwagger();
            app.UseSwaggerUI();

            app.MapControllers();
            app.Run();
        }
    }
}
