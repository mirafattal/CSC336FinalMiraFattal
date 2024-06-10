using Final_BLL.DTOs;
using Final_BLL.Services.Reservations;
using Microsoft.AspNetCore.Mvc;

namespace CSC336FinalMiraFattal.Controllers
{
    [Route("api/ [Controller]")]
    [ApiController]
    public class ReservationController : _GenericController<ReservationDto>
    {
        public readonly IReservationService _reservationService;
       
        public ReservationController(IReservationService reservationService): 
            base (reservationService)
        {
            _reservationService = reservationService;
        }
    }
}
