namespace SOSWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInterpreterViewModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClinicalVolunteersViewModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PreferredName = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.Int(nullable: false),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Birthday = c.DateTime(nullable: false),
                        ProfessionalTitle = c.String(),
                        LicensedState = c.String(),
                        LicenseNumber = c.String(),
                        MedicalSpecialty = c.String(),
                        tShirtSize = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ClinicalVolunteersViewModels");
        }
    }
}
