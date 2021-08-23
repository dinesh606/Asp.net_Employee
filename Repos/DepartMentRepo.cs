using CodiNova.DataContext;
using CodiNova.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodiNova.Repos
{
    public class DepartMentRepo : IDepartMentRepo
    {
        private readonly ApplicationDbContext _Context;
        public DepartMentRepo(ApplicationDbContext Context)
        {
            _Context = Context;
        }

        public async Task<IEnumerable<Department>> GetDeprtment()
        {
            return await _Context.Department.ToListAsync();
        }
    }
}
