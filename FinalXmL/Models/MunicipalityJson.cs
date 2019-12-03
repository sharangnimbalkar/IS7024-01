using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalXmL.Models
{
    public class MunicipalityJson
    {
        public int ID { get; set; }
        public string Code { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public long Geonameid { get; set; }

        public string Subcountry { get; set; }

    }
}
