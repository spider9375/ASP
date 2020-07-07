namespace BlazorApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarDealershipForeignKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cars", "Dealership_Id", "dbo.Dealerships");
            DropIndex("dbo.Cars", new[] { "Dealership_Id" });
            RenameColumn(table: "dbo.Cars", name: "Dealership_Id", newName: "DealershipId");
            AlterColumn("dbo.Cars", "DealershipId", c => c.Int(nullable: false));
            CreateIndex("dbo.Cars", "DealershipId");
            AddForeignKey("dbo.Cars", "DealershipId", "dbo.Dealerships", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "DealershipId", "dbo.Dealerships");
            DropIndex("dbo.Cars", new[] { "DealershipId" });
            AlterColumn("dbo.Cars", "DealershipId", c => c.Int());
            RenameColumn(table: "dbo.Cars", name: "DealershipId", newName: "Dealership_Id");
            CreateIndex("dbo.Cars", "Dealership_Id");
            AddForeignKey("dbo.Cars", "Dealership_Id", "dbo.Dealerships", "Id");
        }
    }
}
