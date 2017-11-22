namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Appoinments", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Patients", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Cities", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Policlinics", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Hospitals", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Towns", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Staffs", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Titles", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "Email", c => c.String());
            AddColumn("dbo.Users", "Role", c => c.String(maxLength: 10));
            AddColumn("dbo.Users", "Lastname", c => c.String(maxLength: 30));
            AddColumn("dbo.Users", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "IsDeleted");
            DropColumn("dbo.Users", "Lastname");
            DropColumn("dbo.Users", "Role");
            DropColumn("dbo.Users", "Email");
            DropColumn("dbo.Titles", "IsDeleted");
            DropColumn("dbo.Staffs", "IsDeleted");
            DropColumn("dbo.Towns", "IsDeleted");
            DropColumn("dbo.Hospitals", "IsDeleted");
            DropColumn("dbo.Policlinics", "IsDeleted");
            DropColumn("dbo.Cities", "IsDeleted");
            DropColumn("dbo.Patients", "IsDeleted");
            DropColumn("dbo.Appoinments", "IsDeleted");
        }
    }
}
