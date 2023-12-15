using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModel
{
    public class TourAddViewModel
    {
        [Required]
        public string TourName { get; set; }
        public string TourShortDescription { get; set; }
        public string TourDescription { get; set; }
        public double TourPrice { get; set; }

    }
}
