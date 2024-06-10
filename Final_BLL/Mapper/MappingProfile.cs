using AutoMapper;
using Final_BLL.DTOs;
using Final_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_BLL.Mapper
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Airplane, AirplaneDto>().ReverseMap();
            CreateMap<Flight, FlightDto>().ReverseMap();
            CreateMap<Pilot, PilotDto>().ReverseMap();
            CreateMap<Passenger, PassengerDto>().ReverseMap();
            CreateMap<Reservation, ReservationDto>().ReverseMap();
            CreateMap<Reservation, ResWithPassAndFlight>().ReverseMap();


        }
    }
}
