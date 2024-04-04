using AnimeList.Models;

namespace AnimeList.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            var serviceScope = applicationBuilder.ApplicationServices.CreateScope();
            var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

            context.Database.EnsureCreated();

            if (!context.VoiceActors.Any())
            {
                context.AddRange(new List<VoiceActor>()
                {
                    new VoiceActor
                    {
                        Name = "Junko Takeuchi",
                        ImageUrl = "https://cdn.myanimelist.net/images/voiceactors/1/54677.jpg",
                        Language = "Japanese",
                        
                    },
                    new VoiceActor
                    {
                        Name = "Kappei Yamaguchi",
                        ImageUrl = "https://cdn.myanimelist.net/images/voiceactors/3/65308.jpg",
                        Language = "Japanese"
                    },
                    new VoiceActor
                    {
                        Name = "Masako Nozawa",
                        ImageUrl = "https://cdn.myanimelist.net/images/voiceactors/2/77340.jpg",
                        Language = "Japanese"
                    },
                    new VoiceActor
                    {
                        Name = "Johnny Yong Bosch",
                        ImageUrl = "https://cdn.myanimelist.net/images/voiceactors/1/49718.jpg",
                        Language = "English"
                    }
                });

                context.SaveChanges();
            }

            if (!context.Studios.Any())
            {
                context.AddRange(new List<Studio>()
                {
                    new Studio
                    {
                        Name = "Studio Pierrot",
                        ImageUrl = "https://static.wikia.nocookie.net/nintendo/images/b/b3/TV_Tokyo.svg/revision/latest?cb=20230401175733&path-prefix=en"
					}
                });

                context.SaveChanges();
            }

            if (!context.Producers.Any())
            {
                context.AddRange(new List<Producer>()
                {
                    new Producer
                    {
                        Name = "TV Tokyo",
                        ImageUrl = "https://static.wikia.nocookie.net/shinkalion/images/5/5f/TVTokyologo.png"
					}
                });

                context.SaveChanges();
            }

            if (!context.Animes.Any())
            {
                context.Animes.AddRange(new List<Anime>()
                {
                    new Anime()
                    {
                        Title = "Naruto",
                        Synopsis = "Naruto Uzumaki, a mischievous adolescent ninja, struggles as he searches for recognition and dreams of becoming the Hokage, the village's leader and strongest ninja.",
                        ImageUrl = "https://cdn.myanimelist.net/images/anime/13/17405.jpg",
                        Status = "Finished",
                        ReleaseDate = DateTime.Now,
                        Format = Enum.AnimeFormat.TV,
                        Genre = "Action",
                        TrailerUrl = "https://www.youtube.com/watch?v=dzStNmQpzBA",
                        StudioId = 4,
                        ProducerId = 4,
                        Price = 25.99
                    },
                    new Anime()
                    {
                        Title = "One Piece",
                        Synopsis = "Seeking to be the greatest pirate in the world, young Monkey D. Luffy, endowed with stretching powers from the legendary Gomu Gomu Devil's fruit, travels towards the Grand Line in search of One Piece, the greatest treasure in the world.",
                        ImageUrl = "https://cdn.myanimelist.net/images/anime/6/73245.jpg",
                        Status = "Finished",
                        ReleaseDate = DateTime.Now,
                        Format = Enum.AnimeFormat.TV,
                        Genre = "Action",
                        TrailerUrl = "https://www.youtube.com/watch?v=Ades3pQbeh8",
                        StudioId = 4,
                        ProducerId = 4,
                        Price = 29.99
                    },
                    new Anime()
                    {
                        Title = "Bleach",
                        Synopsis = "Ichigo Kurosaki, a teenager gifted with the ability to see spirits, unwittingly takes on the duties of a Soul Reaper, dedicating his life to protecting the innocent and helping the tortured spirits find peace.",
                        ImageUrl = "https://cdn.myanimelist.net/images/anime/3/40451.jpg",
                        Status = "Finished",
                        ReleaseDate = DateTime.Now,
                        Format = Enum.AnimeFormat.TV,
                        Genre = "Action",
                        TrailerUrl = "https://www.youtube.com/watch?v=2Q_o9j8W9d8",
                        StudioId = 4,
                        ProducerId = 4,
                        Price = 27.99
                    }
                });

                context.SaveChanges();
            }

            if (!context.Animes_VoiceActors.Any())
            {
                context.AddRange(new List<Anime_VoiceActor>()
                {
                    new Anime_VoiceActor
                    {
                        AnimeId = 7,
                        VoiceActorId = 5
                    },
                    new Anime_VoiceActor
                    {
                        AnimeId = 8,
                        VoiceActorId = 6
                    },
                    new Anime_VoiceActor
                    {
                        AnimeId = 9,
                        VoiceActorId = 7
                    },
                    new Anime_VoiceActor
                    {
                        AnimeId = 9,
                        VoiceActorId = 8
                    }
                });

                context.SaveChanges();
            }
        }
    }
}
