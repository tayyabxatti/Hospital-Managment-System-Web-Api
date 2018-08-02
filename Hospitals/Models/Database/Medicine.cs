using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospitals.Models.Database
{
    public class Medicine
    {
        [Key]
        public string MedicineId { get; set; }
        public string MedicineName { get; set; }
        public int Stock { set; get; }

        public DateTime MedicineExpiryDate { get; set; }
        public DateTime EntryDate { get; set; }

        public ICollection<Category> CategoryId { get; set; }
    }
}