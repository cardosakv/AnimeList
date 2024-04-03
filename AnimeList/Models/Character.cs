using System.ComponentModel.DataAnnotations;

namespace AnimeList.Models
{
    public class Character
    {
        [Key]
        public int Id { get; set; }

        public string? ImageUrl { get; set; }

        public string? Name { get; set; }

        public string? Species { get; set; }

        public string? Occupation { get; set; }
    }
}
