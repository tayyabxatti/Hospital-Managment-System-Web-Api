using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hospitals.Models.Database
{
    public class Appoitment
    {
        [Key]
        public int AppoitmentId { get; set; }

        [ForeignKey("Employee")]
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [ForeignKey("Patient")]
        public string PatientId { get; set; }
        public Patient Patient { get; set; }
        public DateTime Time { get; set; }
        public string Status { get; set; }
        public int AppoitmentFee { get; set; }
    }
}