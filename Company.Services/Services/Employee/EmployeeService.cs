using Company.Data.Entities;
using Company.Repository.Interfaces;
using Company.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Services.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(Employee employee)
        {
            var mappedEmployee = new Employee
            {
                Name = employee.Name,
                Age = employee.Age,
                Address = employee.Address,
                Salary = employee.Salary,
                Email = employee.Email,
                PhoneNumber = employee.PhoneNumber,
                HiringDate = employee.HiringDate,
            };
            _unitOfWork.EmployeeRepository.Add(mappedEmployee);
            _unitOfWork.Complete();
        }

        public void Delete(Employee employee)
        {
            _unitOfWork.EmployeeRepository.Delete(employee);
            _unitOfWork.Complete();
        }

        public IEnumerable<Employee> GetAll()
        {
            return _unitOfWork.EmployeeRepository.GetAll();
        }
        public void Update(Employee employee)
        {
            _unitOfWork.EmployeeRepository.Update(employee);
            _unitOfWork.Complete();
        }
        //public IEnumerable<Employee> GetEmployeesByName(string name)
        //{
        //    return _unitOfWork.EmployeeRepository.GetEmployeeByName(name); 
        //}

        //public IEnumerable<Employee> GetEmployeesByAddress(string address)
        //{
        //    return _unitOfWork.EmployeeRepository.GetEmployeesByAddress(address);
        //}


        public Employee GetById(int? id)
        {
            if (id is null)
                return null;
            var employee = _unitOfWork.EmployeeRepository.GetById(id.Value);
            if (employee is null)
                return null;

            return employee;
        }
    }
}

