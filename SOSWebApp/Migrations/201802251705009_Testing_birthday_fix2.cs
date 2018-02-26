namespace SOSWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Testing_birthday_fix2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PhysicianVolunteerViewModels", "GraduationDate", c => c.String());
            AlterColumn("dbo.Volunteers", "GraduationDate", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Volunteers", "GraduationDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PhysicianVolunteerViewModels", "GraduationDate", c => c.DateTime(nullable: false));
        }
    }
}
