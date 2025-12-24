using System.ComponentModel.DataAnnotations;

namespace MovieApi.Models;

public class Movie
{
    public int Id { get; set; }

    [Required]
    [MaxLength(150)]
    public string Title { get; set; }

    [Required]
    [MaxLength(100)]
    public string Director { get; set; }

    [Range(1900, 2100)]
    public int ReleaseYear { get; set; }

    public int GenreId { get; set; }
    public Genre Genre { get; set; }
}
