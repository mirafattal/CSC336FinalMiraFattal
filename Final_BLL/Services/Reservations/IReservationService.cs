using Final_BLL._GenericService;
using Final_BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_BLL.Services.Reservations
{
    public interface IReservationService: IGenericService<ReservationDto>
    {
        void AddResPassFlight(ResWithPassAndFlight add);
    }
}
