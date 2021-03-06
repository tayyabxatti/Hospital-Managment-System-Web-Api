﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hospitals.Models.Database
{
    public class PatientResult
    {
        [Key]
        public string PatientResultId { get; set; }

        [ForeignKey("Patient")]
        public string PatientId { get; set; }
        public Patient Patient { get; set; }
    
        [ForeignKey("Report")]
        public string ReportId { get; set; }
        public Report Report { get; set; }
    }
}