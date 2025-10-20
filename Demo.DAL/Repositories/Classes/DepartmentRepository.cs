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

        public Department? GetById(int Id)
        {
            var Daprtment = _dbContext.Departments.Find(Id);
            return Daprtment;
        }
    }
}
