using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hospitals.Models.Database
{
    public class TimeTable
    {
        [Key]
        public string TimeTableId { get; set; }

        [ForeignKey("Employee")]
        public string EmployeeId { set; get; }
        public Employee Employee { get; set; }              

        [ForeignKey("Shift")]
        public string ShiftId { get; set; }
        public Shift Shift { get; set; }
    }
}