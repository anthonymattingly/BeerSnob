using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerSnob.Models
{
    public class Beer
    {
        public int BeerId { get; set; }

        public string BeerName { get; set; }

        public string Country { get; set; }

        public double PercentABV { get; set; }

        public double Rating { get; set; }

        public string Description { get; set; }
    }
}