using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hospitals.Models.Database
{
    public class Attendence
    {
        [Key]
        public string AttendenceId { get; set; }
        public DateTime Day { get; set; }
        public DateTime TimeIn { get; set; }
        public DateTime TimeOut { get; set; }
        public DateTime Date { get; set; }

        [ForeignKey("Leave")]
        public string LeaveId { get; set; }
        public Leave Leave { get; set; }

        [ForeignKey("Employee")]
        public string EmployeeId { get; set; }
        public Employee Employee { set; get; }
        public TimeTable TimeTableId { get; set; }

    }
}