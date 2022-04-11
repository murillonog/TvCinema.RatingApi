using TvCinema.RatingApi.Service.Domain.Entities;

namespace TvCinema.RatingApi.Service.Domain.Interfaces
{
    public interface IRatingRepository
    {
        Task<Ratings?> GetByImdbId(string imdbId);
    }
}
