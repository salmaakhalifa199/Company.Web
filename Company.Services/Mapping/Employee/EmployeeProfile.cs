﻿using AutoMapper;
using Company.Data.Entities;
using Company.Services.Interfaces.Employee.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Services.Mapping
{ 
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee,EmployeeDto>().ReverseMap();
            // employee da el source w employeedto el destination
            // lw el mapping rayah gy yb'a astghdam ReverseMap() 
        }
    }
}
