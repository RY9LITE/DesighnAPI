using AutoMapper;
using MovieApi.DTOs;
using MovieApi.Models;

namespace MovieApi.Mapping;

/// <summary>
/// Профиль маппирования сущностей и DTO
/// </summary>
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Genre, GenreDto>();

        CreateMap<Movie, MovieDto>()
            .ForMember(dest => dest.GenreName,
                opt => opt.MapFrom(src => src.Genre.Name));
    }
}
