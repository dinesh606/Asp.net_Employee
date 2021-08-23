using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodiNova.Models
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        public int EmpID { get; set; }
        public string DeptName { get; set; }




    }
}
