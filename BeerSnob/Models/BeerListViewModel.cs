using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//Model is used with Beer Index view

namespace BeerSnob.Models
{
    public class BeerListViewModel
    {
        
        public ICollection<BeerViewModel> Beers { get; set; }

    }
}