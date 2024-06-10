using Final_BLL.DTOs;
using Final_BLL.Services.Passengers;
using Microsoft.AspNetCore.Mvc;

namespace CSC336FinalMiraFattal.Controllers
{
    [Route("api/ [Controller]")]
    [ApiController]
    public class PassengerController : _GenericController<PassengerDto>
    {
        public readonly IPassengerService _passengerService;
        public PassengerController (IPassengerService passengerService): base(passengerService)
        {
            _passengerService = passengerService;
        }
    }
}
