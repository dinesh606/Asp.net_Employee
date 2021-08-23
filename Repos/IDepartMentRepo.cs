using CodiNova.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodiNova.Repos
{
    public interface IDepartMentRepo
    {
        Task<IEnumerable<Department>> GetDeprtment();

    }
}
