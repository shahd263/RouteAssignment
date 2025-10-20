using Demo.DAL.Data.Contexts;
using Demo.DAL.Models;
using Demo.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Repositories.Classes
{
    public class DepartmentRepository :IDepartmentRepository
    {
        private readonly AppDbContext _dbContext;

        public DepartmentRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Add(Department department)
        {
            if(department is null) return 0;
            _dbContext.Departments.Add(department);
            return _dbContext.SaveChanges();
        }

        public int Delete(Department department)
        {
            if (department is null) return 0;
            _dbContext.Departments.Remove(department);
            return _dbContext.SaveChanges();
        }

        public IEnumerable<Department> GetAll() => _dbContext.Departments.ToList();


        public Department? GetById(int Id) => _dbContext.Departments.Find(Id);

        public int Update(Department department)
        {
            if (department is null) return 0;
            _dbContext.Departments.Update(department);
            return _dbContext.SaveChanges();
        }
    }
}
