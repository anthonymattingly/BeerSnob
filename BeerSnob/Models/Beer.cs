using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeerSnob.Models
{
    public class Beer
    {
        public int BeerId { get; set; }

        //Defines Relationship between Beer and BeerStyle Entities
        public virtual IEnumerable<BeerStyle> BeerStyles { get; set; }

        public int BeerStyleId { get; set; }

        
        public virtual BeerStyle BeerStyle { get; set; }

        public string BeerName { get; set; }

        public string WhereTried { get; set; }

        //Attributes below all datepicker formatting when in edit view
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime WhenTried { get; set; }

        public string Country { get; set; }

        //public string Style { get; set; }

        public double PercentABV { get; set; }

        public double Rating { get; set; }

        public string Description { get; set; }

    }
}