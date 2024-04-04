using AnimeList.Models;
using Microsoft.EntityFrameworkCore;

namespace AnimeList.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Anime> Animes { get; set; }
        public DbSet<VoiceActor> VoiceActors { get; set; }
        public DbSet<Studio> Studios { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Anime_VoiceActor> Animes_VoiceActors { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Anime_VoiceActor>()
                .HasKey(av => new { av.AnimeId, av.VoiceActorId });

            modelBuilder.Entity<Anime_VoiceActor>()
                .HasOne(av => av.Anime)
                .WithMany(a => a.Animes_VoiceActors)
                .HasForeignKey(av => av.AnimeId);

            modelBuilder.Entity<Anime_VoiceActor>()
                .HasOne(av => av.VoiceActor)
                .WithMany(v => v.Animes_VoiceActors)
                .HasForeignKey(av => av.VoiceActorId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
