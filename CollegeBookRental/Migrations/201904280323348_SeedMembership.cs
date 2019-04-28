namespace CollegeBookRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedMembership : DbMigration
    {
        public override void Up()
        {
            //I used the Sql() to add values into my membership table.
            Sql("INSERT INTO [dbo].[MembershipTypes]([Name],[SignUpFee],[ChargeRateSemiAnnual],[ChargeRateMonthly]) VALUES ('Pay per Rental',0,50,25)");
            Sql("INSERT INTO [dbo].[MembershipTypes]([Name],[SignUpFee],[ChargeRateSemiAnnual],[ChargeRateMonthly]) VALUES ('Member',150,20,10)");
            Sql("INSERT INTO [dbo].[MembershipTypes]([Name],[SignUpFee],[ChargeRateSemiAnnual],[ChargeRateMonthly]) VALUES ('SuperAdmin',0,0,0)");
        }

        public override void Down()
        {
        }
    }
}
