using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domain.Models.Anime.Entities;

namespace Repository.Database
{
    /// <summary>
    /// Anime poster image configuration.
    /// </summary>
    internal class AnimePosterImageConfiguration : IEntityTypeConfiguration<AnimePosterImage>
    {
        public void Configure(EntityTypeBuilder<AnimePosterImage> builder)
        {
            builder
                .HasKey(b => b.Id);
        }
    }
}
