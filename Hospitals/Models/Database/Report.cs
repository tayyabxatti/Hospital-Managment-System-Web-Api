using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospitals.Models.Database
{
    public class Report
    {
        [Key]
        public string ReportId { get; set; }
        public string ReportResult { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime ReportDate { get; set; }
        public int ReportFee { get; set; }
    }
}