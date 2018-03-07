namespace BeerSnob.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Beers",
                c => new
                    {
                        BeerId = c.Int(nullable: false, identity: true),
                        BeerName = c.String(),
                        WhereTried = c.String(),
                        Country = c.String(),
                        PercentABV = c.Double(nullable: false),
                        Rating = c.Double(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.BeerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Beers");
        }
    }
}
