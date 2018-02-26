namespace SOSWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Testing_birthday_fix : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ClinicalVolunteersViewModels", "Birthday", c => c.String());
            AlterColumn("dbo.GeneralVolunteers", "Birthday", c => c.String());
            AlterColumn("dbo.InterpreterViewModels", "Birthday", c => c.String());
            AlterColumn("dbo.PhysicianVolunteerViewModels", "Birthday", c => c.String());
            AlterColumn("dbo.Volunteers", "Birthday", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Volunteers", "Birthday", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PhysicianVolunteerViewModels", "Birthday", c => c.DateTime(nullable: false));
            AlterColumn("dbo.InterpreterViewModels", "Birthday", c => c.DateTime(nullable: false));
            AlterColumn("dbo.GeneralVolunteers", "Birthday", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ClinicalVolunteersViewModels", "Birthday", c => c.DateTime(nullable: false));
        }
    }
}
