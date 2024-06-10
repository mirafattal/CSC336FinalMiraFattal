using Final_BLL.Services.Airplanes;
using Final_BLL.Services.Flights;
using Final_BLL.Services.Passengers;
using Final_BLL.Services.Pilots;
using Final_BLL.Services.Reservations;

namespace CSC336FinalMiraFattal.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddService(this IServiceCollection service)
        {
            service.AddScoped<IPilotService, PilotService>();
            service.AddScoped<IPassengerService, PassengerService>();
            service.AddScoped<IReservationService, ReservationService>();
            service.AddScoped<IFlightService, FlightService>();
            service.AddScoped<IAirplaneService, AirplaneService>();
            return service;
        }
    }
}
