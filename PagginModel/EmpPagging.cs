using CodiNova.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodiNova.PagginModel
{
    public class EmpPagging
    {
        public Paggnation Paggnation { get; set; }
        public IEnumerable< Employee> Emp { get; set; }
    }
}
