namespace Hospitals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dbupdates : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Appoitments", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Attendences", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Beds", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Bills", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Categories", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Departments", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Employees", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.EmployeeSalarySlips", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Hospitals", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Leaves", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Medicines", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.PatientDoctors", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.PatientMedicines", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.PatientResults", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Patients", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Prescriptions", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Registrations", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Reports", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Roles", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Rooms", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.SalaryDetails", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Shifts", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.TimeTables", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Appoitments", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Employees", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Departments", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Roles", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Patients", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Attendences", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Leaves", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.TimeTables", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Shifts", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Beds", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Rooms", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Bills", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Categories", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.EmployeeSalarySlips", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Hospitals", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Medicines", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.PatientDoctors", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.PatientMedicines", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Registrations", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.PatientResults", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Reports", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Prescriptions", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.SalaryDetails", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropColumn("dbo.Appoitments", "ApplicationUser_Id");
            DropColumn("dbo.Employees", "ApplicationUser_Id");
            DropColumn("dbo.Departments", "ApplicationUser_Id");
            DropColumn("dbo.Roles", "ApplicationUser_Id");
            DropColumn("dbo.Patients", "ApplicationUser_Id");
            DropColumn("dbo.Attendences", "ApplicationUser_Id");
            DropColumn("dbo.Leaves", "ApplicationUser_Id");
            DropColumn("dbo.TimeTables", "ApplicationUser_Id");
            DropColumn("dbo.Shifts", "ApplicationUser_Id");
            DropColumn("dbo.Beds", "ApplicationUser_Id");
            DropColumn("dbo.Rooms", "ApplicationUser_Id");
            DropColumn("dbo.Bills", "ApplicationUser_Id");
            DropColumn("dbo.Categories", "ApplicationUser_Id");
            DropColumn("dbo.EmployeeSalarySlips", "ApplicationUser_Id");
            DropColumn("dbo.Hospitals", "ApplicationUser_Id");
            DropColumn("dbo.Medicines", "ApplicationUser_Id");
            DropColumn("dbo.PatientDoctors", "ApplicationUser_Id");
            DropColumn("dbo.PatientMedicines", "ApplicationUser_Id");
            DropColumn("dbo.Registrations", "ApplicationUser_Id");
            DropColumn("dbo.PatientResults", "ApplicationUser_Id");
            DropColumn("dbo.Reports", "ApplicationUser_Id");
            DropColumn("dbo.Prescriptions", "ApplicationUser_Id");
            DropColumn("dbo.SalaryDetails", "ApplicationUser_Id");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUserLogins");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId });
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Hometown = c.String(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId });
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.SalaryDetails", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Prescriptions", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Reports", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.PatientResults", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Registrations", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.PatientMedicines", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.PatientDoctors", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Medicines", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Hospitals", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.EmployeeSalarySlips", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Categories", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Bills", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Rooms", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Beds", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Shifts", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.TimeTables", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Leaves", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Attendences", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Patients", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Roles", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Departments", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Employees", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Appoitments", "ApplicationUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.AspNetUserLogins", "UserId");
            CreateIndex("dbo.AspNetUserClaims", "UserId");
            CreateIndex("dbo.AspNetUsers", "UserName", unique: true, name: "UserNameIndex");
            CreateIndex("dbo.SalaryDetails", "ApplicationUser_Id");
            CreateIndex("dbo.AspNetUserRoles", "RoleId");
            CreateIndex("dbo.AspNetUserRoles", "UserId");
            CreateIndex("dbo.AspNetRoles", "Name", unique: true, name: "RoleNameIndex");
            CreateIndex("dbo.Prescriptions", "ApplicationUser_Id");
            CreateIndex("dbo.Reports", "ApplicationUser_Id");
            CreateIndex("dbo.PatientResults", "ApplicationUser_Id");
            CreateIndex("dbo.Registrations", "ApplicationUser_Id");
            CreateIndex("dbo.PatientMedicines", "ApplicationUser_Id");
            CreateIndex("dbo.PatientDoctors", "ApplicationUser_Id");
            CreateIndex("dbo.Medicines", "ApplicationUser_Id");
            CreateIndex("dbo.Hospitals", "ApplicationUser_Id");
            CreateIndex("dbo.EmployeeSalarySlips", "ApplicationUser_Id");
            CreateIndex("dbo.Categories", "ApplicationUser_Id");
            CreateIndex("dbo.Bills", "ApplicationUser_Id");
            CreateIndex("dbo.Rooms", "ApplicationUser_Id");
            CreateIndex("dbo.Beds", "ApplicationUser_Id");
            CreateIndex("dbo.Shifts", "ApplicationUser_Id");
            CreateIndex("dbo.TimeTables", "ApplicationUser_Id");
            CreateIndex("dbo.Leaves", "ApplicationUser_Id");
            CreateIndex("dbo.Attendences", "ApplicationUser_Id");
            CreateIndex("dbo.Patients", "ApplicationUser_Id");
            CreateIndex("dbo.Roles", "ApplicationUser_Id");
            CreateIndex("dbo.Departments", "ApplicationUser_Id");
            CreateIndex("dbo.Employees", "ApplicationUser_Id");
            CreateIndex("dbo.Appoitments", "ApplicationUser_Id");
            AddForeignKey("dbo.TimeTables", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Shifts", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.SalaryDetails", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Rooms", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Roles", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Reports", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Registrations", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Prescriptions", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Patients", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.PatientResults", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.PatientMedicines", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.PatientDoctors", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Medicines", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Leaves", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Hospitals", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.EmployeeSalarySlips", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Employees", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Departments", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Categories", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Bills", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Beds", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Attendences", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Appoitments", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles", "Id", cascadeDelete: true);
        }
    }
}
