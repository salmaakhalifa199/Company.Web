using Company.Data.Contexts;
using Company.Data.Entities;
using Company.Repository.Interfaces;

namespace Company.Repository.Repositories
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        private readonly CompanyDbContext _context;

        public DepartmentRepository(CompanyDbContext Context) : base(Context)
        { 
        }
    
        //public void Add(Department department) => _context.Add(department);

        //public void Delete(Department department) => _context.Remove(department);

        //public IEnumerable<Department> GetAll() => _context.Departments.ToList();

        //public Department GetById(int id) => _context.Departments.FirstOrDefault(x => x.Id == id);
        //// or _context.Departments.Find(id);
        //public void Update(Department department) => _context.Update(department);

    }
}
