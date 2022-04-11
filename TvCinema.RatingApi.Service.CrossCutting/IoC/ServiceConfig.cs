using Microsoft.Extensions.DependencyInjection;
using TvCinema.RatingApi.Service.Application.Interfaces;
using TvCinema.RatingApi.Service.Application.Services;

namespace TvCinema.RatingApi.Service.CrossCutting.IoC
{
    public static class ServiceConfig
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IRatingService, RatingService>();
        }
    }
}
