using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hospitals.Models.Database
{
    public class EmployeeSalarySlip
    {
        [Key]
        public string EmployeeSalarySlipId { get; set; }
        public int Deductions { get; set; }
        public int ShortLeaves { get; set; }
        public int Total { get; set; }        
        public bool isPaid { get; set; }

        [ForeignKey("Employee")]
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [ForeignKey("Leave")]
        public string LeaveId { get; set; }
        public Leave Leave { get; set; }
    }
}