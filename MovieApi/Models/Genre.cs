using System.ComponentModel.DataAnnotations;

namespace MovieApi.Models;

public class Genre
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    [MaxLength(300)]
    public string Description { get; set; }

    public ICollection<Movie> Movies { get; set; }
}
