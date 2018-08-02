using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hospitals.Models.Database
{
    public class Bed
    {
        [Key]
        public string BedId { get; set; }
        public string BedNumber { set; get; }
        public int BedFee { get; set; }

        [ForeignKey("Room")]
        public string RoomId { get; set; }
        public Room Room { get; set; }
      
    }
}