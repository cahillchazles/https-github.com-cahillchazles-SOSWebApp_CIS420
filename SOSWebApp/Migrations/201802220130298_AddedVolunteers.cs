namespace SOSWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedVolunteers : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Volunteers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Volunteers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        State = c.Int(nullable: false),
                        ZipCode = c.String(),
                        PreferredName = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        Birthday = c.DateTime(nullable: false),
                        Employer = c.String(),
                        DescribesYou = c.Int(),
                        Interests = c.Int(),
                        TShirtSize = c.Int(),
                        Language = c.Int(),
                        ProfessionalTitle = c.Int(),
                        LicensedState = c.Int(),
                        ProfessionalLicenseNumber = c.String(),
                        TShirtSize1 = c.Int(),
                        MedicalSpecialty = c.String(),
                        LicensedState1 = c.Int(),
                        LincenseNumber = c.String(),
                        ProfessionalAlmaMater = c.String(),
                        GraduationDate = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ID);
            
        }
    }
}
