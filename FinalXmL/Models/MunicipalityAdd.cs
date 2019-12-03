using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalXmL.Models
{
    public class MunicipalityAdd
    {
        public int Id { get; set; }

        [Display(Name = "Country")]
        public string country { get; set; }
        [Display(Name = "Sub Country")]
        public string subcountry { get; set; }
        [Display(Name = "Municipality")]
        public string municipality { get; set; }
        [Display(Name = "Geocode")]
        public int geocode { get; set; }



    }
}
