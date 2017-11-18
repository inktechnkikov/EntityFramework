namespace ConsoleApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentAddressForeignKey : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Schools",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                        School_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Schools", t => t.School_Id)
                .ForeignKey("dbo.StudentAddresses", t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.School_Id);
            
            CreateTable(
                "dbo.StudentAddresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Id", "dbo.StudentAddresses");
            DropForeignKey("dbo.Students", "School_Id", "dbo.Schools");
            DropIndex("dbo.Students", new[] { "School_Id" });
            DropIndex("dbo.Students", new[] { "Id" });
            DropTable("dbo.StudentAddresses");
            DropTable("dbo.Students");
            DropTable("dbo.Schools");
        }
    }
}
