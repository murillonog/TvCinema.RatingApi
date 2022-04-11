using Microsoft.AspNetCore.Mvc;
using TvCinema.RatingApi.Service.Application.DTOs;
using TvCinema.RatingApi.Service.Application.Interfaces;

namespace TvCinema.RatingApi.Service.Api.Controllers
{
    [ApiController]
    [Route("api/rating")]
    public class RatingController : ControllerBase
    {
        private readonly IRatingService _ratingService;

        public RatingController(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }

        [HttpGet("{imdbId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(RatingsDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(List<string>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(List<string>))]
        public async Task<IActionResult> Get(string imdbId)
        {
            try
            {
                var result = await _ratingService.GetByImdbId(imdbId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message, null, null, null, null);
            }
        }
    }
}
