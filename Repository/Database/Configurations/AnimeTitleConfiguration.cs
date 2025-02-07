using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domain.Models.Anime.Entities;

namespace Repository.Database
{
    /// <summary>
    /// Anime title configuration.
    /// </summary>
    internal class AnimeTitleConfiguration : IEntityTypeConfiguration<AnimeTitle>
    {
        public void Configure(EntityTypeBuilder<AnimeTitle> builder)
        {
            builder
                .HasKey(b => b.Id);
        }
    }
}
