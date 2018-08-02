using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospitals.Models.Database
{
    public class Hospital
    {
        [Key]
        public string HospitalId { set; get; }
        public string HospitalName { set; get; }
        public string Website { set; get; }
        public string Email { set; get; }
        public DateTime CreatedDate { set; get; }
    }
}