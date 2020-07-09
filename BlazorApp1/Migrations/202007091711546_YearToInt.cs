namespace BlazorApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class YearToInt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ManufactureDetails", "Year", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ManufactureDetails", "Year", c => c.String());
        }
    }
}
