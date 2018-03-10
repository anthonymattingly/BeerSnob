namespace BeerSnob.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WhenTried : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Beers", "WhenTried", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Beers", "WhenTried");
        }
    }
}
