using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerSnob.Models
{
    public class BeerStyle
    {
        public BeerStyle()
        {
            Beers = new HashSet<Beer>();
        }

        public int BeerStyleId { get; set; }

        public string StyleOfBeer { get; set; }

        public virtual ICollection<Beer> Beers { get; set; }

    }
}