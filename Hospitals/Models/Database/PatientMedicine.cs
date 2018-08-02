using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hospitals.Models.Database
{
    public class PatientMedicine
    {
        [Key]
        public string PatientMedicineId { get; set; }
        [ForeignKey("Patient")]
        public string PatientId { get; set; }
        public Patient Patient { get; set; }

        [ForeignKey("Registration")]
        public string RegistrationId { get; set; }
        public Registration Registration { get; set; }

        [ForeignKey("Medicine")]
        public string MedicineId { get; set; }
        public Medicine Medicine { get; set; }
    }
}