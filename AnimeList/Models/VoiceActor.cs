using System.ComponentModel.DataAnnotations;

namespace AnimeList.Models
{
    public class VoiceActor
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "This is required.")]
        public string? ImageUrl { get; set; }

        [Required(ErrorMessage = "This is required.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "This is required.")]
        public string? Language { get; set; }

        public List<Anime_VoiceActor>? Animes_VoiceActors { get; set; }
    }
}
