namespace SOSWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test_IsNonClinicalFix : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GeneralVolunteers", "IsNonClinical", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.GeneralVolunteers", "IsNonClinical");
        }
    }
}
