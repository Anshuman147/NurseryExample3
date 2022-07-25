namespace NurseryExample3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeInDatabase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NurseryProducts", "IsAvailable", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.NurseryProducts", "IsAvailable");
        }
    }
}
