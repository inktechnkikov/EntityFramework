namespace CarSimulator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Model = c.String(),
                        EngineType = c.String(),
                        Manufacturer = c.String(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Mercedes Cars",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        MaxSpeed = c.Int(nullable: false),
                        AirCondition = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Seat Cars",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        HorsePower = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Seat Cars", "Id", "dbo.Cars");
            DropForeignKey("dbo.Mercedes Cars", "Id", "dbo.Cars");
            DropIndex("dbo.Seat Cars", new[] { "Id" });
            DropIndex("dbo.Mercedes Cars", new[] { "Id" });
            DropTable("dbo.Seat Cars");
            DropTable("dbo.Mercedes Cars");
            DropTable("dbo.Cars");
        }
    }
}
