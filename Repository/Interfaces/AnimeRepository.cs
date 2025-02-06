using Domain.Models.Anime.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Database;

namespace Repository.Interfaces
{
    public class AnimeRepository : IAnimeRepository
    {
        private readonly DbContextOptions<ApplicationDbContext> _dbOptions;

        public AnimeRepository(DbContextOptions<ApplicationDbContext> dbOptions)
        {
            _dbOptions = dbOptions;
        }
        public async Task<IEnumerable<AnimeData>> GetAll(CancellationToken cancellationToken)
        {
            using var db = new ApplicationDbContext(_dbOptions);
            return await db.AnimeDatas
                            .Include(i => i.Title)
                            .Include(i => i.PosterImage)
                            .OrderBy(b => b.Id)
                            .ToListAsync(cancellationToken);
        }

        public async Task Upsert(IEnumerable<AnimeData> entities, CancellationToken cancellationToken)
        {
            using var db = new ApplicationDbContext(_dbOptions);
            db.AnimeDatas.RemoveRange(db.AnimeDatas);
            await db.AnimeDatas.AddRangeAsync(entities, cancellationToken);
            await db.SaveChangesAsync(cancellationToken);
        }
    }
}
