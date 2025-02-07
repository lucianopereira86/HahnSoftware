using Domain.Models.Anime.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Database.Configurations;

namespace Repository.Database
{
    /// <summary>
    /// Represents the database context for the Anime repository.
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        /// <summary>
        /// Gets or sets the DbSet for anime datas.
        /// </summary>
        public DbSet<AnimeData> AnimeDatas { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for anime titles.
        /// </summary>
        public DbSet<AnimeTitle> AnimeTitles { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for anime poster images.
        /// </summary>
        public DbSet<AnimePosterImage> AnimePosterImages { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationDbContext"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            base.Database.Migrate();
        }

        /// <inheritdoc/>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AnimeDataConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AnimeTitleConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AnimePosterImageConfiguration).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
