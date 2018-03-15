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

            context.BeerStyles.AddOrUpdate(
                b => b.StyleOfBeer,
                new BeerStyle
                { StyleOfBeer = "Lager" });
                context.SaveChanges();

            var lagerStyle = context.BeerStyles.Where(b => b.StyleOfBeer == "Lager").Single();

            context.Beers.AddOrUpdate(
                c => c.BeerName,
                new Beer
                {
                    BeerName = "Test Beer from Seed Method",
                    WhereTried = "Sergio's",
                    Country = "Murica",
                    WhenTried = DateTime.Today,
                    BeerStyleId = lagerStyle.BeerStyleId,
                    PercentABV = 8.1,
                    Rating = 4.5,
                    Description = "Decent"
                },
                new Beer
                {
                   BeerId = 2,
                   BeerName = "Test Beer from Seed Method2",
                   WhereTried = "Sergio's2",
                   WhenTried = DateTime.Today,
                   Country = "Murica2",
                   BeerStyleId = lagerStyle.BeerStyleId,
                   PercentABV = 8.9,
                   Rating = 1.5,
                   Description = "Decentish"
                }

                );

            
        }
    }
}
