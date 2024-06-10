using Final_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_BLL.DTOs
{
    public class ResWithPassAndFlight
    {
        public int ReservationId { get; set; }

        public int? FlightId { get; set; }

        public int? PassengerId { get; set; }

        public string? SeatNumber { get; set; }

        public DateTime? ReservationDate { get; set; }

        public virtual FlightDto? FlightDto { get; set; }

        public virtual PassengerDto? PassengerDto { get; set; }
    }
}
