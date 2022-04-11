using TvCinema.RatingApi.Service.Application.DTOs;

namespace TvCinema.RatingApi.Service.Application.Interfaces
{
    public interface IRatingService
    {
        Task<RatingsDto> GetByImdbId(string imdbId);
    }
}
