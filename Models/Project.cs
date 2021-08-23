using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodiNova.Models
{
    public class Project
    {
        [Key]
        public int ProjId { get; set; }
        public string ProjName { get; set; }
        public DateTime ProjStartDate { get; set; }
        public DateTime ProjEndDate { get; set; }
        public string MangerName { get; set; }
        public string Email { get; set; }
        public int DeptId { get; set; }
        public int EmpID { get; set; }




    }
}
