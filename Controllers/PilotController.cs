using Final_BLL.DTOs;
using Final_BLL.Services.Pilots;
using Microsoft.AspNetCore.Mvc;

namespace CSC336FinalMiraFattal.Controllers
{
    [Route("api/ [Controller]")]
    [ApiController]
    public class PilotController : _GenericController<PilotDto>
    {
       public readonly IPilotService _pilotService;

        public PilotController(IPilotService pilotService): base (pilotService)
        {
            _pilotService = pilotService;
        }
    }
}
