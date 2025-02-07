using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domain.Models.Anime.Entities;

namespace Repository.Database.Configurations
{
    /// <summary>
    /// Anime data configuration.
    /// </summary>
    internal class AnimeDataConfiguration : IEntityTypeConfiguration<AnimeData>
    {
        public void Configure(EntityTypeBuilder<AnimeData> builder)
        {
            builder
                .HasKey(b => b.Id);
            builder
                .HasOne(e => e.Title)
                .WithOne(e => e.AnimeData)
                .HasForeignKey<AnimeTitle>(e => e.Id)
                .IsRequired();
            builder
                .HasOne(e => e.PosterImage)
                .WithOne(e => e.AnimeData)
                .HasForeignKey<AnimePosterImage>(e => e.Id)
                .IsRequired();
        }
    }
}
