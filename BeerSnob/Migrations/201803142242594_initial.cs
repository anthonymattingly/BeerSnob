namespace BeerSnob.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Beers",
                c => new
                    {
                        BeerId = c.Int(nullable: false, identity: true),
                        BeerStyleId = c.Int(nullable: false),
                        BeerName = c.String(),
                        WhereTried = c.String(),
                        WhenTried = c.DateTime(nullable: false),
                        Country = c.String(),
                        Style = c.String(),
                        PercentABV = c.Double(nullable: false),
                        Rating = c.Double(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.BeerId)
                .ForeignKey("dbo.BeerStyles", t => t.BeerStyleId, cascadeDelete: true)
                .Index(t => t.BeerStyleId);
            
            CreateTable(
                "dbo.BeerStyles",
                c => new
                    {
                        BeerStyleId = c.Int(nullable: false, identity: true),
                        StyleOfBeer = c.String(),
                    })
                .PrimaryKey(t => t.BeerStyleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Beers", "BeerStyleId", "dbo.BeerStyles");
            DropIndex("dbo.Beers", new[] { "BeerStyleId" });
            DropTable("dbo.BeerStyles");
            DropTable("dbo.Beers");
        }
    }
}
