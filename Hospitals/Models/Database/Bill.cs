using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hospitals.Models.Database
{
    public class Bill
    {
        [Key]
        public string BillId { get; set; }
        public int VisitCharges { get; set; }
        public int AdmitCharges { get; set; }
        public int TestCharges { get; set; }
        public int OtherCharges { get; set; }
        public int TotalCharges { get; set; }
        public int paidCharges { set; get; }
        public int Balance { get; set; }
        public string BillType { get; set; }
        public int Discount { get; set; }
        public int Tax { get; set; }

        [ForeignKey("Patient")]
        public string PatiendId { get; set; }
        public Patient Patient { get; set; }

    }
}