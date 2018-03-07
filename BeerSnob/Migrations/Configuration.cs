namespace BeerSnob.Migrations
{
    using BeerSnob.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BeerSnob.BeerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BeerSnob.BeerContext context)
        {
            context.Beers.AddOrUpdate(
                new Beer { BeerId = 1, BeerName = "Test Beer from Seed Method", WhereTried = "Sergio's", Country = "Murica", PercentABV = 8.1,
                Rating = 4.5, Description = "Decent"
                }
                );
        }
    }
}
