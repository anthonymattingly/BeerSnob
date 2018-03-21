using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeerSnob.Models
{
    public class BeerStyleViewModel
    {

        public BeerStyleViewModel()
        {
            Beers = new List<BeerViewModel>();
        }

        public int BeerStyleId { get; set; }

        [DisplayName("Style")]
        [StringLength(50)]
        public string StyleOfBeer { get; set; }

        public virtual ICollection<BeerViewModel> Beers { get; set; }


    }
}