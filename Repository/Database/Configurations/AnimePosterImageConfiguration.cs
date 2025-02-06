using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domain.Models.Anime.Entities;

namespace Repository.Database
{
    internal class AnimePosterImageConfiguration : IEntityTypeConfiguration<AnimePosterImage>
    {
        public void Configure(EntityTypeBuilder<AnimePosterImage> builder)
        {
            builder
                .Property(b => b.Id)
                .UseIdentityColumn();
        }
    }
}
