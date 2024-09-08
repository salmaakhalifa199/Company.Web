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
            _context = Context;
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

        //public IEnumerable<Employee> GetEmployeesByAddress(string address)
        //   => _context.Employees.Where(x => x.Name.Trim().ToLower().Contains(address.Trim().ToLower())).ToList();

        public IEnumerable<Employee> GetEmployeesByName(string name)
          => _context.Employees.Where(x => x.Name.Trim().ToLower().Contains(name.Trim().ToLower()) ||
           x.Email.Trim().ToLower().Contains(name.Trim().ToLower()) ||
           x.Address.Trim().ToLower().Contains(name.Trim().ToLower())

            ).ToList();
    }
}
