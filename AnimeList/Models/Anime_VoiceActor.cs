namespace AnimeList.Models
{
    public class Anime_VoiceActor
    {
        public int AnimeId { get; set; }
        public Anime? Anime { get; set; }

        public int VoiceActorId { get; set; }
        public VoiceActor? VoiceActor { get; set; }
    }
}
