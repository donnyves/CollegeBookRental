namespace CollegeBookRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddMembership : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false),
                    SignUpFee = c.Byte(nullable: false),
                    ChargeRateMonthly = c.Byte(nullable: false),
                    ChargeRateSemiAnnual = c.Byte(nullable: false),
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropTable("dbo.MembershipTypes");
        }
    }
}
