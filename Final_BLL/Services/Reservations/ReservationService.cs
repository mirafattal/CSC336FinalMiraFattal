using AutoMapper;
using Final_BLL._GenericService;
using Final_BLL.DTOs;
using Final_DAL._GenericRepository;
using Final_DAL.Models;
using Final_DAL.Repositories.Flights;
using Final_DAL.Repositories.Passengers;
using Final_DAL.Repositories.Reservations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Final_BLL.Services.Reservations
{
    public class ReservationService: GenericService<Reservation, ReservationDto>,IReservationService
    {
        public readonly IReservationRepository _reservationRepository;
        public readonly IFlightRepository _flightRepository;
        public readonly IPassengerRepository _passengerRepository;
        public readonly IMapper _mapper;

        public ReservationService(IReservationRepository repository, IMapper mapper,
            IFlightRepository flightRepository, IPassengerRepository passengerRepository) : 
            base(repository, mapper)
        {
            _reservationRepository = repository;
            _mapper = mapper;
            _flightRepository = flightRepository;
            _passengerRepository = passengerRepository;
        }

        public void AddResPassFlight(ResWithPassAndFlight add)
        {
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var reservation = _mapper.Map<Reservation>(add);

                     var flight_Dto = add.FlightDto;
                     var flight = _mapper.Map<Flight>(flight_Dto);
                     reservation.FlightId = flight.FlightId;
                     _flightRepository.Add(flight);

                    var passenger_Dto = add.PassengerDto;
                    var passenger = _mapper.Map<Passenger>(passenger_Dto);
                    
                    reservation.PassengerId = passenger.PassengerId;
                    _passengerRepository.Add(passenger);
                    
                    _reservationRepository.Add(reservation);

                    scope.Complete();
                }
                catch
                {

                    scope.Dispose();
                    throw;
                }
            }
        }
    }
}
