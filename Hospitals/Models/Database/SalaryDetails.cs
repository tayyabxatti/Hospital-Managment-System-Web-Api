using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hospitals.Models.Database
{
    public class SalaryDetails
    {
        [Key]
        public int SalaryDetailsID { get; set; }
        public Role RoleId { get; set; }
        public int  Pay { get; set; }

        [ForeignKey("Department")]
        public string DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}