using CodiNova.PagginModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodiNova.Services
{
    public interface IPaggination
    {
        Task< EmpPagging> GetEmpPagging(int page = 1, int pagesize = 10);
    }
}
