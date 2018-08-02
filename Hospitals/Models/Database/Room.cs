using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hospitals.Models.Database
{
    public class Room
    {
        [Key]
        public string RoomId { get; set; }
        public string RoomNumber { get; set; }


        [ForeignKey("Department")]
        public string DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}