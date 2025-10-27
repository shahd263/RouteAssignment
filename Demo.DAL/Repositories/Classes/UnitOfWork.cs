using Demo.DAL.Repositories.Classes;
using Demo.DAL.Data.Contexts;
using Demo.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Repositories.Classes
{
    public class UnitOfWork : IUnitOfWork/*, IDisposable*/
    {
        private readonly AppDbContext _dbContext;

        private readonly Lazy<IEmployeeRepository> _employeeRepository;
        private readonly Lazy<IDepartmentRepository> _departmentRepository;

        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _employeeRepository = new Lazy<IEmployeeRepository>(() => new EmployeeRepository(_dbContext));
            _departmentRepository = new Lazy<IDepartmentRepository>(() => new DepartmentRepository(_dbContext));
        }
        public IEmployeeRepository EmployeeRepository => _employeeRepository.Value;

        public IDepartmentRepository DepartmentRepository => _departmentRepository.Value;

        //public void Dispose()
        //{




        //    // some actions
        //    _dbContext.Dispose();
        //}

        public bool SaveChanges()
        {
            return _dbContext.SaveChanges() > 0;
        }
    }
}
