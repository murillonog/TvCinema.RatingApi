using AutoMapper;
using TvCinema.RatingApi.Service.Application.DTOs;
using TvCinema.RatingApi.Service.Domain.Entities;

namespace TvCinema.RatingApi.Service.CrossCutting.Mapping
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile()
        {
            CreateMap<Ratings, RatingsDto>().ReverseMap();
        }
    }
}
