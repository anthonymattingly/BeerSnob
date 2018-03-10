using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeerSnob.Models
{
    public class BeerViewModel
    {
        [DisplayName("Item No.")]
        public int BeerId { get; set; }

        [DisplayName("Beer Name")]
        [StringLength(50)]
        public string BeerName { get; set; }

        [DisplayName("Where You Had It")]
        [StringLength(50)]
        public string WhereTried { get; set; }

        [DisplayName("When You Had It")]
        //Attributes below allow datepicker formatting when in Create View
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime WhenTried { get; set; }

        [DisplayName("Country of Origin")]
        [StringLength(50)]
        public string Country { get; set; }

        [DisplayName("Style")]
        [StringLength(50)]
        public string Style { get; set; }

        [DisplayName("%ABV")]
        [Range(0, 20)]
        public double PercentABV { get; set; }

        [DisplayName("Rating from 1 - 10")]
        [Range(0, 10)]
        public double Rating { get; set; }

        [DisplayName("Describe it")]
        [StringLength(50)]
        public string Description { get; set; }
    }
}