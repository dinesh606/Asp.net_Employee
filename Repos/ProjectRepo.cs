using CodiNova.DataContext;
using CodiNova.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodiNova.Repos
{
    public class ProjectRepo : IProjectRepo
    {
        private readonly ApplicationDbContext _Context;
        public ProjectRepo(ApplicationDbContext Context)
        {
            _Context = Context;
        }

        public async Task<IEnumerable<Project>> GetProject()
        {
            return await _Context.Project.ToListAsync();
        }
    }
}
