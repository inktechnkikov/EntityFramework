namespace EntityFrameworkRelations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.StudentAddresses", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.StudentAddresses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "ID", "dbo.StudentAddresses");
            DropIndex("dbo.Students", new[] { "ID" });
            DropTable("dbo.StudentAddresses");
            DropTable("dbo.Students");
        }
    }
}
