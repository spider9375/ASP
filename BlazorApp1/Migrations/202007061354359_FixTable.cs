namespace BlazorApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Cars", "TransmissionDetails_TransmissionType");
            DropColumn("dbo.Cars", "TransmissionDetails_GearCount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cars", "TransmissionDetails_GearCount", c => c.Int(nullable: false));
            AddColumn("dbo.Cars", "TransmissionDetails_TransmissionType", c => c.String());
        }
    }
}
