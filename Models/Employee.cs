using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodiNova.Models
{
    public class Employee
    {
        [Key]
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpEmail { get; set; }
        public DateTime EmpDOJ { get; set; }
        [NotMapped]
        public string ProjName { get; set; }
        [NotMapped]
        public DateTime ProjStartDate { get; set; }
        [NotMapped]
        public DateTime ProjEndDate { get; set; }
        [NotMapped]
        public string MangerName { get; set; }
        [NotMapped]
        public string Email { get; set; }
        [NotMapped]
        public string DeptName { get; set; }



    }
}
