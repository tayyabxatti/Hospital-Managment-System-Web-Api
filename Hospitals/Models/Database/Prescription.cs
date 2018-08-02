using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hospitals.Models.Database
{
    public class Prescription
    {
        [Key]
        public string PrescriptionId { get; set; }
        public string PrescriptionDetail { get; set; }
        public string PrescriptionAdvice { get; set; }
        public bool IsRegistered { get; set; }

        [ForeignKey("Employee")]
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; }


        [ForeignKey("Patient")]
        public string PatientId { get; set; }
        public Patient Patient { get; set; }

    }
}