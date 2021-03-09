namespace PersonnelApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departmen",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Personels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Lastname = c.String(),
                        DepartmanId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departmen", t => t.DepartmanId, cascadeDelete: true)
                .Index(t => t.DepartmanId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Personels", "DepartmanId", "dbo.Departmen");
            DropIndex("dbo.Personels", new[] { "DepartmanId" });
            DropTable("dbo.Personels");
            DropTable("dbo.Departmen");
        }
    }
}
