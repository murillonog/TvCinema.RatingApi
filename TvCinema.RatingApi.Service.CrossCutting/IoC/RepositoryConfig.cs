using Microsoft.Extensions.DependencyInjection;
using TvCinema.RatingApi.Service.Domain.Interfaces;
using TvCinema.RatingApi.Service.Infrastructure.Repositories;

namespace TvCinema.RatingApi.Service.CrossCutting.IoC
{
    public static class RepositoryConfig
    {
        public static void ConfigureRepository(this IServiceCollection services)
        {
            services.AddScoped<IRatingRepository, RatingRepository>();
        }
    }
}
