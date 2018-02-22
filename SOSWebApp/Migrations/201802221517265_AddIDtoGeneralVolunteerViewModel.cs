namespace SOSWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIDtoGeneralVolunteerViewModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Volunteers",
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
                        IsPhysician = c.Boolean(nullable: false),
                        IsClinical = c.Boolean(nullable: false),
                        IsNonClinical = c.Boolean(nullable: false),
                        IsInterpreter = c.Boolean(nullable: false),
                        MedicalSpecialty = c.String(),
                        LicensedState = c.String(),
                        LicenseNumber = c.String(),
                        ProfessionalAlmaMater = c.String(),
                        GraduationDate = c.DateTime(nullable: false),
                        ProfessionalTitle = c.String(),
                        tShirtSize = c.String(),
                        Employer = c.String(),
                        DescribesYou = c.String(),
                        Interest = c.String(),
                        Language = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Volunteers");
        }
    }
}
