using AutoMapper;
using Final_BLL._GenericService;
using Final_BLL.DTOs;
using Final_DAL.Models;
using Final_DAL.Repositories.Airplanes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_BLL.Services.Airplanes
{
    public class AirplaneService: GenericService<Airplane, AirplaneDto>, IAirplaneService
    {
        public readonly IAirplaneRepository _airplaneRepository;
        
        public readonly IMapper _mapper;


        public AirplaneService(IAirplaneRepository airplaneRepository, IMapper mapper
             ) :
            base(airplaneRepository, mapper)
        {
            _airplaneRepository = airplaneRepository;
            _mapper = mapper;
        }
            
    }
}
