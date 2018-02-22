namespace SOSWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPhysicanViewModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GeneralVolunteers",
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
                        tShirtSize = c.String(),
                        Employer = c.String(),
                        DescribesYou = c.String(),
                        Interest = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PhysicianVolunteerViewModels",
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
                        MedicalSpecialty = c.String(),
                        LicensedState = c.String(),
                        LicenseNumber = c.String(),
                        ProfessionalAlmaMater = c.String(),
                        GraduationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PhysicianVolunteerViewModels");
            DropTable("dbo.GeneralVolunteers");
        }
    }
}
