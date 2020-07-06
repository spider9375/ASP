namespace BlazorApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TransmissionDetails_TransmissionType = c.String(),
                        TransmissionDetails_GearCount = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        Dealership_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Dealerships", t => t.Dealership_Id)
                .Index(t => t.Dealership_Id);
            
            CreateTable(
                "dbo.EngineDetails",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        EngineType = c.String(),
                        EngineVolume = c.Decimal(nullable: false, precision: 18, scale: 2),
                        HorsePower = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.ManufactureDetails",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Manufacturer = c.String(),
                        Model = c.String(),
                        Year = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.VisualDetails",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Color = c.String(),
                        BodyType = c.String(),
                        DoorCount = c.Int(nullable: false),
                        HasWing = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Wheels",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Rims",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Color = c.String(),
                        RimBrand = c.String(),
                        Model = c.String(),
                        Size = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Wheels", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Tires",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        TireBrand = c.String(),
                        TireSeason = c.String(),
                        Width = c.Int(nullable: false),
                        Diameter = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Wheels", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Dealerships",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TransmissionDetails",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        TransmissionType = c.String(),
                        GearCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TransmissionDetails", "Id", "dbo.Cars");
            DropForeignKey("dbo.Cars", "Dealership_Id", "dbo.Dealerships");
            DropForeignKey("dbo.Tires", "Id", "dbo.Wheels");
            DropForeignKey("dbo.Rims", "Id", "dbo.Wheels");
            DropForeignKey("dbo.Wheels", "Id", "dbo.Cars");
            DropForeignKey("dbo.VisualDetails", "Id", "dbo.Cars");
            DropForeignKey("dbo.ManufactureDetails", "Id", "dbo.Cars");
            DropForeignKey("dbo.EngineDetails", "Id", "dbo.Cars");
            DropIndex("dbo.TransmissionDetails", new[] { "Id" });
            DropIndex("dbo.Tires", new[] { "Id" });
            DropIndex("dbo.Rims", new[] { "Id" });
            DropIndex("dbo.Wheels", new[] { "Id" });
            DropIndex("dbo.VisualDetails", new[] { "Id" });
            DropIndex("dbo.ManufactureDetails", new[] { "Id" });
            DropIndex("dbo.EngineDetails", new[] { "Id" });
            DropIndex("dbo.Cars", new[] { "Dealership_Id" });
            DropTable("dbo.TransmissionDetails");
            DropTable("dbo.Dealerships");
            DropTable("dbo.Tires");
            DropTable("dbo.Rims");
            DropTable("dbo.Wheels");
            DropTable("dbo.VisualDetails");
            DropTable("dbo.ManufactureDetails");
            DropTable("dbo.EngineDetails");
            DropTable("dbo.Cars");
        }
    }
}
