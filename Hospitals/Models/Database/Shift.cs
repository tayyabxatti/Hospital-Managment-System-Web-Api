
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospitals.Models.Database
{
    public class Shift
    {
        [Key]
        public string ShiftId { get; set; }
        public string ShiftName { get; set; }
        public DateTime ShiftTime { get; set; }
    }
}