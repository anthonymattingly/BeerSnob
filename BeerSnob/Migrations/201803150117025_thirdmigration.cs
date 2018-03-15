namespace BeerSnob.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thirdmigration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Beers", "Style");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Beers", "Style", c => c.String());
        }
    }
}
