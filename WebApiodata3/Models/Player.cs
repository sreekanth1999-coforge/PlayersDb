using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApiodata3.Models
{
    [Table("Player")]
    public class Player
    {
        [Key]
        public int PId { get; set; }
        public string PName { get; set; }
        public double BattingAvg { get; set; }
        public double BlowingAvg { get; set; }
        public String Team { get; set; }
    }
}