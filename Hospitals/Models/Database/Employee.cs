using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hospitals.Models.Database
{
    public class Employee
    {
        [Key]
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeePhoneNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Status { set; get; }

        [ForeignKey("Department")]
        public string DepartmentId { get; set; }
        public Department Department { get; set; }

        [ForeignKey("Role")]
        public string RoleId { get; set; }
        public Role Role { get; set; }
       



    }
}