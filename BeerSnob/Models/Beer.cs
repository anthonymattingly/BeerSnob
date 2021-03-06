﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeerSnob.Models
{
    public class Beer
    {

        public int BeerId { get; set; }

        public int BeerStyleId { get; set; }

        //int BeerStyleId and below property define relationship between Beer and BeerStyle Entitites
        public virtual BeerStyle StyleOfBeer { get; set; }

        public string BeerName { get; set; }

        public string WhereTried { get; set; }

        //Attributes below to keep datepicker in preferred format
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime WhenTried { get; set; }

        public string Country { get; set; }

        public double PercentABV { get; set; }

        public double Rating { get; set; }

        public string Description { get; set; }

    }
}