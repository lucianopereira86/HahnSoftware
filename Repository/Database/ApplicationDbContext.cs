using Domain.Models.Anime.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Database.Configurations;

namespace Repository.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<AnimeData> AnimeDatas { get; set; }
        public DbSet<AnimeTitle> AnimeTitles { get; set; }
        public DbSet<AnimePosterImage> AnimePosterImages { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            base.Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AnimeDataConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AnimeTitleConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AnimePosterImageConfiguration).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
