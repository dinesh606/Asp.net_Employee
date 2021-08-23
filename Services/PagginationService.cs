using CodiNova.DataContext;
using CodiNova.PagginModel;
using CodiNova.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodiNova.Services
{
    public class PagginationService :IPaggination
    {
        private readonly IAllDetailsService _allDetailsService;
        
        private readonly ApplicationDbContext _context;
        public PagginationService(IAllDetailsService allDetailsService, ApplicationDbContext context)
        {
            _allDetailsService = allDetailsService;

            _context = context;
        }
        public async Task<EmpPagging> GetEmpPagging(int page = 1,int pagesize = 10)
        {
            var model = new EmpPagging();
            var emplist = await _allDetailsService.GetDetails();
            var data = emplist.Select(x => new
            {
                ProjName = x.ProjName,
                ProjStartDate = x.ProjStartDate,
                ProjEndDate = x.ProjEndDate,
                MangerName = x.MangerName,
                Email = x.Email,
                EmpName = x.EmpName,
                EmpEmail = x.EmpEmail,
                EmpDOJ = x.EmpDOJ,
                DeptName = x.DeptName
            }).Skip((page - 1) * pagesize).Take(pagesize).ToList();

            model.Emp = emplist;
            int total = _context.Employee.Count();
            var page1 = new Paggnation
            {
                totalitems = total,
                page = page,
                pagesize = pagesize,
                totalpages = (int)Math.Ceiling(decimal.Divide(total, pagesize))
            };
            model.Paggnation = page1;
            return model;
            
            
        }
    }
}
