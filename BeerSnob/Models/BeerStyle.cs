using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerSnob.Models
{
    public class BeerStyle
    {
       
        public int BeerStyleId { get; set; }

        //Will be populated with seed data.  User will be able to choose from prepopulated list
        public string StyleOfBeer { get; set; }

    }
}