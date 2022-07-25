namespace NurseryExample3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NurseryProductTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NurseryCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NurseryProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SKU_NO = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        NurseryCategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.NurseryCategories", t => t.NurseryCategoryId, cascadeDelete: true)
                .Index(t => t.NurseryCategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NurseryProducts", "NurseryCategoryId", "dbo.NurseryCategories");
            DropIndex("dbo.NurseryProducts", new[] { "NurseryCategoryId" });
            DropTable("dbo.NurseryProducts");
            DropTable("dbo.NurseryCategories");
        }
    }
}
