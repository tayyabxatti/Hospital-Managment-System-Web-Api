using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospitals.Models.Database
{
    public class Patient
    {
        [Key]
        public string PatientId { get; set; }
        public string PatientName { set; get; }
        public int PatientAge { set; get; }
        public string PatientGender { get; set; }
        public string PatientEmergencyNumber { get; set; }
        public string PatientDisease { get; set; }
    }
}