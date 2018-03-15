using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerSnob.Models
{
    public class BeerStyleViewModel
    {
        
            public BeerStyleViewModel()
            {
                Beers = new HashSet<BeerViewModel>();
            }

            public int BeerStyleId { get; set; }

            public string StyleOfBeer { get; set; }

            public virtual ICollection<BeerViewModel> Beers { get; set; }

        
    }
}