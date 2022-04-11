using Microsoft.EntityFrameworkCore;
using TvCinema.RatingApi.Service.Domain.Entities;
using TvCinema.RatingApi.Service.Domain.Interfaces;
using TvCinema.RatingApi.Service.Infrastructure.Context;

namespace TvCinema.RatingApi.Service.Infrastructure.Repositories
{
    public class RatingRepository : IRatingRepository
    {
        protected ApplicationDbContext Db;
        protected DbSet<Ratings> DbSet;
        public RatingRepository(ApplicationDbContext context)
        {
            Db = context;
            DbSet = Db.Set<Ratings>();
        }

        public async Task<Ratings?> GetByImdbId(string imdbId)
        {
            return await DbSet
                .FirstOrDefaultAsync(x => x.ImdbId == imdbId);
        }
    }
}
