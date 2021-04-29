namespace sligoUniversityProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DateOfBirth = c.Int(nullable: false),
                        PhoneNumber = c.Int(nullable: false),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        PersonType = c.String(),
                        Person_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.People", t => t.Person_ID)
                .Index(t => t.Person_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "Person_ID", "dbo.People");
            DropIndex("dbo.People", new[] { "Person_ID" });
            DropTable("dbo.People");
        }
    }
}
