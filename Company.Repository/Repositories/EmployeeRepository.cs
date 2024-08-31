using Company.Data.Contexts;
using Company.Data.Entities;
using Company.Repository.Interfaces;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Repository.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee> , IEmployeeRepository
    {
        private readonly CompanyDbContext _context;

        #region dependency injection 

        #region Constructor injection
        public EmployeeRepository(CompanyDbContext Context) : base(Context)
        {
        }
        #endregion

        #region Property injection
        ////public CompanyDbContext context { get; set; }
        #endregion

        #region Method injection
        ////public void Add(CompanyDbContext employee)
        ////{
        ////    throw new NotImplementedException();
        ////}
        //// astghdmha bs lw 3andy method wahda bs hya ali mahtaga dbcontext 
        #endregion

        #endregion

        //public void Add(Employee employee) => _context.Add(employee);

        //public void Delete(Employee employee) => _context.Remove(employee);


        //public IEnumerable<Employee> GetAll() => _context.Employees.ToList();


        //public Employee GetById(int id) => _context.Employees.FirstOrDefault(x => x.Id == id);
        //// or _context.Employees.Find(id);
        //public void Update(Employee employee) => _context.Update(employee);

    }
}
