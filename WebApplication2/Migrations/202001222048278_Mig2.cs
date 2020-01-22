namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Name", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Employees", "FirstName");
            DropColumn("dbo.Employees", "LastName");
            DropColumn("dbo.Employees", "Skills");
            DropColumn("dbo.Employees", "EmailID");
            DropColumn("dbo.Employees", "ContactNo");
            DropColumn("dbo.Employees", "Position");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Position", c => c.String());
            AddColumn("dbo.Employees", "ContactNo", c => c.String());
            AddColumn("dbo.Employees", "EmailID", c => c.String());
            AddColumn("dbo.Employees", "Skills", c => c.String());
            AddColumn("dbo.Employees", "LastName", c => c.String());
            AddColumn("dbo.Employees", "FirstName", c => c.String());
            DropColumn("dbo.Employees", "Name");
        }
    }
}
