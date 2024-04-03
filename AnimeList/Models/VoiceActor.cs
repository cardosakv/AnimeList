using System.ComponentModel.DataAnnotations;

namespace AnimeList.Models
{
    public class VoiceActor
    {
        [Key]
        public int Id { get; set; }

        public string? ImageUrl { get; set; }

        public string? Name { get; set; }

        public string? Language { get; set; }

        public List<Anime_VoiceActor>? Animes_VoiceActors { get; set; }
    }
}
