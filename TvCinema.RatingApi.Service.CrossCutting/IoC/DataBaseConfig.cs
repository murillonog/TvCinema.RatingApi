using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TvCinema.RatingApi.Service.Infrastructure.Context;

namespace TvCinema.RatingApi.Service.CrossCutting.IoC
{
    public static class DataBaseConfig
    {
        public static void ConfigureDataBase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("ConnectionRatings")));
        }
    }
}
