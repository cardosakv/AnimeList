﻿// <auto-generated />
using System;
using AnimeList.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AnimeList.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240403083735_UpdateAnime")]
    partial class UpdateAnime
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AnimeList.Models.Anime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Format")
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProducerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudioId")
                        .HasColumnType("int");

                    b.Property<string>("Synopsis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrailerUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProducerId");

                    b.HasIndex("StudioId");

                    b.ToTable("Animes");
                });

            modelBuilder.Entity("AnimeList.Models.Anime_VoiceActor", b =>
                {
                    b.Property<int>("AnimeId")
                        .HasColumnType("int");

                    b.Property<int>("VoiceActorId")
                        .HasColumnType("int");

                    b.HasKey("AnimeId", "VoiceActorId");

                    b.HasIndex("VoiceActorId");

                    b.ToTable("Animes_VoiceActors");
                });

            modelBuilder.Entity("AnimeList.Models.Producer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Producers");
                });

            modelBuilder.Entity("AnimeList.Models.Studio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Studios");
                });

            modelBuilder.Entity("AnimeList.Models.VoiceActor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VoiceActors");
                });

            modelBuilder.Entity("AnimeList.Models.Anime", b =>
                {
                    b.HasOne("AnimeList.Models.Producer", "Producer")
                        .WithMany("Animes")
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AnimeList.Models.Studio", "Studio")
                        .WithMany("Animes")
                        .HasForeignKey("StudioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producer");

                    b.Navigation("Studio");
                });

            modelBuilder.Entity("AnimeList.Models.Anime_VoiceActor", b =>
                {
                    b.HasOne("AnimeList.Models.Anime", "Anime")
                        .WithMany("Animes_VoiceActors")
                        .HasForeignKey("AnimeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AnimeList.Models.VoiceActor", "VoiceActor")
                        .WithMany("Animes_VoiceActors")
                        .HasForeignKey("VoiceActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Anime");

                    b.Navigation("VoiceActor");
                });

            modelBuilder.Entity("AnimeList.Models.Anime", b =>
                {
                    b.Navigation("Animes_VoiceActors");
                });

            modelBuilder.Entity("AnimeList.Models.Producer", b =>
                {
                    b.Navigation("Animes");
                });

            modelBuilder.Entity("AnimeList.Models.Studio", b =>
                {
                    b.Navigation("Animes");
                });

            modelBuilder.Entity("AnimeList.Models.VoiceActor", b =>
                {
                    b.Navigation("Animes_VoiceActors");
                });
#pragma warning restore 612, 618
        }
    }
}
