using Company.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Repository.Interfaces
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        //Employee GetById(int id);
        //IEnumerable<Employee> GetAll();
        //void Add(Employee employee);
        //void Update(Employee employee);
        //void Delete(Employee employee);

        // five operations maybe we needs them in all entities

        //IEnumerable<Employee> GetEmployeeByName(string name);
        //IEnumerable<Employee> GetEmployeesByAddress(string address);
    }
}
