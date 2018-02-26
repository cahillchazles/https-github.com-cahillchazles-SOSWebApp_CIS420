namespace SOSWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_ViewModels_SetBool : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClinicalVolunteersViewModels", "IsClinical", c => c.Boolean(nullable: false));
            AddColumn("dbo.InterpreterViewModels", "IsInterpreter", c => c.Boolean(nullable: false));
            AddColumn("dbo.PhysicianVolunteerViewModels", "IsPhysician", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PhysicianVolunteerViewModels", "IsPhysician");
            DropColumn("dbo.InterpreterViewModels", "IsInterpreter");
            DropColumn("dbo.ClinicalVolunteersViewModels", "IsClinical");
        }
    }
}
