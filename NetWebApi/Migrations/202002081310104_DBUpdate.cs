namespace NetWebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Applicants", "AppliedJOB_Id", c => c.Int());
            CreateIndex("dbo.Applicants", "AppliedJOB_Id");
            AddForeignKey("dbo.Applicants", "AppliedJOB_Id", "dbo.Jobs", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Applicants", "AppliedJOB_Id", "dbo.Jobs");
            DropIndex("dbo.Applicants", new[] { "AppliedJOB_Id" });
            DropColumn("dbo.Applicants", "AppliedJOB_Id");
        }
    }
}
