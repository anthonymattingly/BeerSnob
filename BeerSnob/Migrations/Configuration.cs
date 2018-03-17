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
                new BeerStyle { StyleOfBeer = "Altbier" },
                new BeerStyle { StyleOfBeer = "Amber Ale" },
                new BeerStyle { StyleOfBeer = "Barleywine" },
                new BeerStyle { StyleOfBeer = "Berliner Weisse" },
                new BeerStyle { StyleOfBeer = "Bitter" },
                new BeerStyle { StyleOfBeer = "Blonde Ale" },
                new BeerStyle { StyleOfBeer = "Bock" },
                new BeerStyle { StyleOfBeer = "Brown Ale" },
                new BeerStyle { StyleOfBeer = "California Common(Steam Beer)" },
                new BeerStyle { StyleOfBeer = "Cream Ale" },
                new BeerStyle { StyleOfBeer = "Dortmunder" },
                new BeerStyle { StyleOfBeer = "Dunkel" },
                new BeerStyle { StyleOfBeer = "Dunkelweizen" },
                new BeerStyle { StyleOfBeer = "Eisbock" },
                new BeerStyle { StyleOfBeer = "Golden Ale (Summer Ale)" },
                new BeerStyle { StyleOfBeer = "Gose" },
                new BeerStyle { StyleOfBeer = "Hefeweizen" },
                new BeerStyle { StyleOfBeer = "Helles" },
                new BeerStyle { StyleOfBeer = "India Pale Ale" },
                new BeerStyle { StyleOfBeer = "Kolsch" },
                new BeerStyle { StyleOfBeer = "Lambic" },
                new BeerStyle { StyleOfBeer = "Light Ale" },
                new BeerStyle { StyleOfBeer = "Maibock" },
                new BeerStyle { StyleOfBeer = "Malt Liquor" },
                new BeerStyle { StyleOfBeer = "Mild" },
                new BeerStyle { StyleOfBeer = "Oktoberfestbier" },
                new BeerStyle { StyleOfBeer = "Oud Bruin" },
                new BeerStyle { StyleOfBeer = "Pale Ale" },
                new BeerStyle { StyleOfBeer = "Pilsner" },
                new BeerStyle { StyleOfBeer = "Porter" },
                new BeerStyle { StyleOfBeer = "Red Ale" },
                new BeerStyle { StyleOfBeer = "Roggenbier" },
                new BeerStyle { StyleOfBeer = "Saison" },
                new BeerStyle { StyleOfBeer = "Scotch Ale" },
                new BeerStyle { StyleOfBeer = "Stout" },
                new BeerStyle { StyleOfBeer = "Vienna Lager" },
                new BeerStyle { StyleOfBeer = "Witbier" },
                new BeerStyle { StyleOfBeer = "Weissbier" },
                new BeerStyle { StyleOfBeer = "Weizenbock" },
                new BeerStyle { StyleOfBeer = "Other" }
            );
            context.SaveChanges();

            var pilsnerStyle = context.BeerStyles.Where(b => b.StyleOfBeer == "Pilsner").Single();

            context.Beers.AddOrUpdate(
                c => c.BeerName,
                new Beer
                {
                    BeerName = "Test Beer from Seed Method",
                    WhereTried = "Sergio's",
                    Country = "Murica",
                    WhenTried = DateTime.Today,
                    BeerStyleId = pilsnerStyle.BeerStyleId,
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
                   BeerStyleId = pilsnerStyle.BeerStyleId,
                   PercentABV = 8.9,
                   Rating = 1.5,
                   Description = "Decentish"
                }

                );

            
        }
    }
}
