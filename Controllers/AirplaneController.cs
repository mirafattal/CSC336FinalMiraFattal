using Final_BLL.DTOs;
using Final_BLL.Services.Airplanes;
using Microsoft.AspNetCore.Mvc;

namespace CSC336FinalMiraFattal.Controllers
{
    [Route("api/ [Controller]")]
    [ApiController]
    public class AirplaneController : _GenericController<AirplaneDto>
    {
        public readonly IAirplaneService _airplaneService;
        public AirplaneController(IAirplaneService service) : base(service)
        {
            _airplaneService = service;
        }

    }
}
