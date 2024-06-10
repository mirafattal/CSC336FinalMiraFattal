using Final_DAL.Repositories.Airplanes;
using Final_DAL.Repositories.Flights;
using Final_DAL.Repositories.Passengers;
using Final_DAL.Repositories.Pilots;
using Final_DAL.Repositories.Reservations;

namespace CSC336FinalMiraFattal.Extensions
{
    public static class RepositoryExtension
    {
        public static IServiceCollection AddRepository(this IServiceCollection service)
        {
            service.AddScoped<IAirplaneRepository, AirplaneRepository>();
            service.AddScoped<IReservationRepository, ReservationRepository>();
            service.AddScoped<IFlightRepository, FlightRepository>();
            service.AddScoped<IPassengerRepository, PassengerRepository>();
            service.AddScoped<IPilotRepository, PilotRepository>();



            return service;
        }
    }
}
