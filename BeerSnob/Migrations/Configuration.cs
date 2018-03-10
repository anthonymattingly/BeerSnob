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
                new Beer { BeerId = 1, BeerName = "Test Beer from Seed Method", WhereTried = "Sergio's",
                WhenTried = DateTime.Today,
                Country = "Murica",
                Style = "IPA",
                PercentABV = 8.1,
                Rating = 4.5,
                Description = "Decent"
                },
                 new Beer
                 {
                     BeerId = 2,
                     BeerName = "Test Beer #2 from Seed Method",
                     WhereTried = "At my house",
                     WhenTried = DateTime.Today,
                     Country = "Canada",
                     Style = "Nut Brown Ale",
                     PercentABV = 6.1,
                     Rating = 8.5,
                     Description = "Good"
                 }
                );
        }
    }
}
