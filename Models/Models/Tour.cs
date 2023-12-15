using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Tour
    {
        [Key]
        public int TourId { get; set; }
        [Required]
        public string TourName { get; set; }
        public string TourShortDescription { get; set; }
        public string TourDescription { get; set;}
        public double TourPrice { get; set; }
    }
}
