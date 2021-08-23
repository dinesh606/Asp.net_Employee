using CodiNova.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodiNova.Services
{
    public interface IAllDetailsService 
    {
        Task<IEnumerable<Employee>> GetDetails();

    }
}
