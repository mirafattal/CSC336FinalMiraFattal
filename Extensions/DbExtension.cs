using Final_DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace CSC336FinalMiraFattal.Extensions
{
    public static class DbExtension
    {
        public static IServiceCollection addDb(this IServiceCollection service, ConfigurationManager config)
        {
            var ConnectionString = config.GetConnectionString("DefaultConnection");

            service.AddDbContext<AirplaneSystemContext>(options =>
                                 options.UseSqlServer(ConnectionString));
            return service;
        }
    }
}
