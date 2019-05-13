namespace CollegeBookRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMemberShipFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AddColumn("dbo.AspNetUsers", "Phone", c => c.String());
            AddColumn("dbo.AspNetUsers", "Birthdate", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "Disabled", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "MembershipID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "MembershipID");
            DropColumn("dbo.AspNetUsers", "Disabled");
            DropColumn("dbo.AspNetUsers", "Birthdate");
            DropColumn("dbo.AspNetUsers", "Phone");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}
