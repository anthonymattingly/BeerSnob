using BeerSnob.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace BeerSnob
{
   

    public class BeerContext : DbContext
    {
    
        public BeerContext()
            : base("name=Beer")
        {

        }

        public virtual DbSet<Beer> Beers { get; set; }

    }

}