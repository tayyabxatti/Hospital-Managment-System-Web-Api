using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hospitals.Models.Database
{
    public class Registration
    {
        [Key]
        public string RegistrationId { get; set; }
        public Patient PatientId { get; set; }
        public Department DepartmentId { get; set; }
        public DateTime AdmitDate { get; set; }
        public DateTime DischargeDate { get; set; }

        [ForeignKey("Bed")]
        public string BedId { get; set; }
        public Bed Bed { get; set; }

        [ForeignKey("Room")]
        public string RoomId { get; set; }
        public Room Room { set; get; }
        
    }
}