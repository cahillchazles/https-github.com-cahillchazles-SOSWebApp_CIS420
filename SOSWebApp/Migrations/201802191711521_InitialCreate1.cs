namespace SOSWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EventName = c.String(),
                        EventDate = c.DateTime(nullable: false),
                        EventTime = c.DateTime(nullable: false),
                        EventLocation = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Volunteers", "Address", c => c.String());
            AddColumn("dbo.Volunteers", "City", c => c.String());
            AddColumn("dbo.Volunteers", "State", c => c.Int(nullable: false));
            AddColumn("dbo.Volunteers", "ZipCode", c => c.String());
            AddColumn("dbo.Volunteers", "PreferredName", c => c.String());
            AddColumn("dbo.Volunteers", "PhoneNumber", c => c.String());
            AddColumn("dbo.Volunteers", "Email", c => c.String());
            AddColumn("dbo.Volunteers", "Birthday", c => c.DateTime(nullable: false));
            AddColumn("dbo.Volunteers", "Employer", c => c.String());
            AddColumn("dbo.Volunteers", "DescribesYou", c => c.Int());
            AddColumn("dbo.Volunteers", "Interests", c => c.Int());
            AddColumn("dbo.Volunteers", "TShirtSize", c => c.Int());
            AddColumn("dbo.Volunteers", "Language", c => c.Int());
            AddColumn("dbo.Volunteers", "ProfessionalTitle", c => c.Int());
            AddColumn("dbo.Volunteers", "LicensedState", c => c.Int());
            AddColumn("dbo.Volunteers", "ProfessionalLicenseNumber", c => c.String());
            AddColumn("dbo.Volunteers", "TShirtSize1", c => c.Int());
            AddColumn("dbo.Volunteers", "MedicalSpecialty", c => c.String());
            AddColumn("dbo.Volunteers", "LicensedState1", c => c.Int());
            AddColumn("dbo.Volunteers", "LincenseNumber", c => c.String());
            AddColumn("dbo.Volunteers", "ProfessionalAlmaMater", c => c.String());
            AddColumn("dbo.Volunteers", "GraduationDate", c => c.String());
            AddColumn("dbo.Volunteers", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Volunteers", "Age");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Volunteers", "Age", c => c.Int(nullable: false));
            DropColumn("dbo.Volunteers", "Discriminator");
            DropColumn("dbo.Volunteers", "GraduationDate");
            DropColumn("dbo.Volunteers", "ProfessionalAlmaMater");
            DropColumn("dbo.Volunteers", "LincenseNumber");
            DropColumn("dbo.Volunteers", "LicensedState1");
            DropColumn("dbo.Volunteers", "MedicalSpecialty");
            DropColumn("dbo.Volunteers", "TShirtSize1");
            DropColumn("dbo.Volunteers", "ProfessionalLicenseNumber");
            DropColumn("dbo.Volunteers", "LicensedState");
            DropColumn("dbo.Volunteers", "ProfessionalTitle");
            DropColumn("dbo.Volunteers", "Language");
            DropColumn("dbo.Volunteers", "TShirtSize");
            DropColumn("dbo.Volunteers", "Interests");
            DropColumn("dbo.Volunteers", "DescribesYou");
            DropColumn("dbo.Volunteers", "Employer");
            DropColumn("dbo.Volunteers", "Birthday");
            DropColumn("dbo.Volunteers", "Email");
            DropColumn("dbo.Volunteers", "PhoneNumber");
            DropColumn("dbo.Volunteers", "PreferredName");
            DropColumn("dbo.Volunteers", "ZipCode");
            DropColumn("dbo.Volunteers", "State");
            DropColumn("dbo.Volunteers", "City");
            DropColumn("dbo.Volunteers", "Address");
            DropTable("dbo.Events");
        }
    }
}
