using AutoMapper;
using Final_BLL._GenericService;
using Final_BLL.DTOs;
using Final_DAL._GenericRepository;
using Final_DAL.Models;
using Final_DAL.Repositories.Pilots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_BLL.Services.Pilots
{
    public class PilotService: GenericService<Pilot, PilotDto>, IPilotService
    {
        public readonly IPilotRepository _pilotRepository;
        public readonly IMapper _mapper;

        public PilotService(IPilotRepository repository, IMapper mapper) : 
            base(repository, mapper)
        {
            _pilotRepository = repository;
            _mapper = mapper;
        }
    }
}
