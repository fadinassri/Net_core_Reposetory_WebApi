namespace NetWebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialDBCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Applicants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Resume = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobTitle = c.String(),
                        SalaryRange = c.String(),
                        Deadline = c.DateTime(nullable: false),
                        MaximumApplicant = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Jobs");
            DropTable("dbo.Applicants");
        }
    }
}
