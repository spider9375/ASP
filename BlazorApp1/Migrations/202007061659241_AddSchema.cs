namespace BlazorApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSchema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Schemata",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Schemata");
        }
    }
}
