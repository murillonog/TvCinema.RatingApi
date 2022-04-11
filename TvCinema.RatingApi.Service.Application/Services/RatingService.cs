using AutoMapper;
using Microsoft.Extensions.Logging;
using TvCinema.RatingApi.Service.Application.DTOs;
using TvCinema.RatingApi.Service.Application.Interfaces;
using TvCinema.RatingApi.Service.Domain.Interfaces;

namespace TvCinema.RatingApi.Service.Application.Services
{
    public class RatingService : IRatingService
    {
        private readonly ILogger<RatingService> _logger;
        private readonly IMapper _mapper;
        private readonly IRatingRepository _ratingRepository;

        public RatingService(
            ILogger<RatingService> logger, 
            IMapper mapper, 
            IRatingRepository ratingRepository)
        {
            _logger = logger;
            _mapper = mapper;
            _ratingRepository = ratingRepository;
        }

        public async Task<RatingsDto> GetById(string imdbId)
        {
            try
            {
                return _mapper.Map<RatingsDto>(await _ratingRepository.GetByImdbId(imdbId));
            }
            catch (Exception exception)
            {
                _logger.LogError(exception.Message);
                throw;
            }
        }
    }
}
