using CodiNova.DataContext;
using CodiNova.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodiNova.Repos
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly ApplicationDbContext _Context;
        public EmployeeRepo(ApplicationDbContext Context)
        {
            _Context = Context;
        }

        public async Task<IEnumerable<Employee>> GetEmployee()
        {
            return await _Context.Employee.ToListAsync();
        }
    }
}
