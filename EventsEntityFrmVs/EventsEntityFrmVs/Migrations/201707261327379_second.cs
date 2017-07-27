namespace EventsEntityFrmVs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EventModels", "ApplicationUserId", "dbo.AspNetUsers");
            AddColumn("dbo.EventModels", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.EventModels", "ApplicationUser_Id1", c => c.String(maxLength: 128));
            AddColumn("dbo.AspNetUsers", "EventModel_Id", c => c.Int());
            CreateIndex("dbo.EventModels", "ApplicationUser_Id");
            CreateIndex("dbo.EventModels", "ApplicationUser_Id1");
            CreateIndex("dbo.AspNetUsers", "EventModel_Id");
            AddForeignKey("dbo.EventModels", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.AspNetUsers", "EventModel_Id", "dbo.EventModels", "Id");
            AddForeignKey("dbo.EventModels", "ApplicationUser_Id1", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EventModels", "ApplicationUser_Id1", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "EventModel_Id", "dbo.EventModels");
            DropForeignKey("dbo.EventModels", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.AspNetUsers", new[] { "EventModel_Id" });
            DropIndex("dbo.EventModels", new[] { "ApplicationUser_Id1" });
            DropIndex("dbo.EventModels", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.AspNetUsers", "EventModel_Id");
            DropColumn("dbo.EventModels", "ApplicationUser_Id1");
            DropColumn("dbo.EventModels", "ApplicationUser_Id");
            AddForeignKey("dbo.EventModels", "ApplicationUserId", "dbo.AspNetUsers", "Id");
        }
    }
}
