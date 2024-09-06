﻿using Company.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Services.Interfaces
{
    public interface IEmployeeService 
    {
        Employee GetById(int? id);
        IEnumerable<Employee> GetAll();
        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(Employee employee);
        //IEnumerable<Employee> GetEmployeesByAddress(string address);
        //IEnumerable<Employee> GetEmployeesByName(string name);
    }
}
