using Final_DAL._GenericRepository;
using Final_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_DAL.Repositories.Reservations
{
    public class ReservationRepository : GenericRepository<Reservation>, IReservationRepository
    {
        public ReservationRepository(AirplaneSystemContext airplaneContext) : base(airplaneContext)
        {
        }
    }
}
