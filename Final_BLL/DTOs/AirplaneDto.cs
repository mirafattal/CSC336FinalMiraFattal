﻿using Final_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_BLL.DTOs
{
    public class AirplaneDto
    {
        public int AirplaneId { get; set; }

        public string? Model { get; set; }

        public string? Manufacturer { get; set; }

        public int? Year { get; set; }

        public int? Capacity { get; set; }

        
    }
}
