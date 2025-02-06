using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domain.Models.Anime.Entities;

namespace Repository.Database
{
    internal class AnimeTitleConfiguration : IEntityTypeConfiguration<AnimeTitle>
    {
        public void Configure(EntityTypeBuilder<AnimeTitle> builder)
        {
            builder
                .Property(b => b.Id)
                .UseIdentityColumn();
        }
    }
}
