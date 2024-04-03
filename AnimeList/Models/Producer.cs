using System.ComponentModel.DataAnnotations;

namespace AnimeList.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        public string? ImageUrl { get; set; }

        public string? Name { get; set; }

        public List<Anime>? Animes { get; set; }
    }
}
