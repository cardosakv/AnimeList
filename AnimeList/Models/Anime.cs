using AnimeList.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimeList.Models
{
    public class Anime
    {
        [Key]
        public int Id { get; set; }

        public string? ImageUrl { get; set; }

        public string? Title { get; set; }

        public string? Synopsis { get; set; }

        public string? Genre { get; set; }

        public string? Status { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public AnimeFormat? Format { get; set; }

        public string? TrailerUrl { get; set; }

        // Relationships
        public List<Anime_VoiceActor>? Animes_VoiceActors { get; set; }

        public int StudioId { get; set; }
        [ForeignKey("StudioId")]
        public Studio? Studio { get; set; }

        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer? Producer { get; set; }
    }
}
