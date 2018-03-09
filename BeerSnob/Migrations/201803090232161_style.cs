namespace BeerSnob.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class style : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Beers", "Style", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Beers", "Style");
        }
    }
}
