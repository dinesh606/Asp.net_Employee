using CodiNova.Models;
using CodiNova.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodiNova.Services
{
    public class AllDetailService : IAllDetailsService
    {
        private readonly IEmployeeRepo _employeeRepo;
        private readonly IDepartMentRepo _iDepartMentRepo;
        private readonly IProjectRepo _iProjectRepo;

        public AllDetailService(IEmployeeRepo EmployeeRepo, IDepartMentRepo iDepartMentRepo, IProjectRepo iProjectRepo)
        {
            _employeeRepo = EmployeeRepo;
            _iDepartMentRepo = iDepartMentRepo;
            _iProjectRepo = iProjectRepo;

        }
        public async Task<IEnumerable<Employee>> GetDetails()
        {
            try
            {
                var employees = await _employeeRepo.GetEmployee();
                var departments = await _iDepartMentRepo.GetDeprtment();
                var projects = await _iProjectRepo.GetProject();

                var result = (from e in employees
                              join d in departments
                              on e.EmpID equals d.EmpID
                              join p in projects
                              on e.EmpID equals p.EmpID
                              select new Employee()
                              {
                                  ProjName = p.ProjName,
                                  ProjStartDate = p.ProjStartDate,
                                  ProjEndDate = p.ProjEndDate,
                                  MangerName = p.MangerName,
                                  Email = p.Email,
                                  EmpName = e.EmpName,
                                  EmpEmail = e.EmpEmail,
                                  EmpDOJ = e.EmpDOJ,
                                  DeptName = d.DeptName
                              });
                return result;

  
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
