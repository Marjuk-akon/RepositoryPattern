using RepositoryPattern.Data;
using RepositoryPattern.Infrastructure;
using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Services
{
    public class EmployeeRepo : IEmployee

    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Delete(Employee employee)
        {
            _context.Employees.Remove(employee);
        }

        public List<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public Employee GetById(int Id)
        {
            return _context.Employees.Where(x => x.Id == Id).FirstOrDefault();
        }

        public void insert(Employee employee)
        {
            _context.Employees.Add(employee);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Employee employee)
        {
            _context.Employees.Update(employee);
        }
    }
}
