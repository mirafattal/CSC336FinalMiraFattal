using Final_BLL.DTOs;
using Final_BLL.Services.Flights;
using Microsoft.AspNetCore.Mvc;

namespace CSC336FinalMiraFattal.Controllers
{
    [Route("api/ [Controller]")]
    [ApiController]
    public class FlightController : _GenericController<FlightDto>
    {
        public readonly IFlightService _flightService;

        public FlightController(IFlightService flightService):base(flightService)
        {
            _flightService = flightService;
        }
    }
}
