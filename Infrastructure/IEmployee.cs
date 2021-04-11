using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Infrastructure
{
    public interface IEmployee
    {
        List<Employee> GetAll();
        Employee GetById(int Id);

        void insert(Employee employee);
        void Update(Employee employee);
        void Delete(Employee employee);
        void Save();

    }
}
