using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerSnob.Models
{
    public class BeerListViewModel
    {

        public ICollection<BeerViewModel> Beers { get; set; }

    }
}