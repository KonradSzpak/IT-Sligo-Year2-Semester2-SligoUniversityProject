namespace sligoUniversityProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FullPartOnline : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.People", "Person_ID", "dbo.People");
            DropIndex("dbo.People", new[] { "Person_ID" });
            AddColumn("dbo.People", "FullPartOnline", c => c.String());
            DropColumn("dbo.People", "Person_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "Person_ID", c => c.Int());
            DropColumn("dbo.People", "FullPartOnline");
            CreateIndex("dbo.People", "Person_ID");
            AddForeignKey("dbo.People", "Person_ID", "dbo.People", "ID");
        }
    }
}
