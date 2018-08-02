namespace Hospitals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appoitments",
                c => new
                    {
                        AppoitmentId = c.Int(nullable: false, identity: true),
                        Time = c.DateTime(nullable: false),
                        Status = c.String(),
                        AppoitmentFee = c.Int(nullable: false),
                        EmployeeID_EmployeeId = c.String(maxLength: 128),
                        PatientId_PatientId = c.String(maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.AppoitmentId)
                .ForeignKey("dbo.Employees", t => t.EmployeeID_EmployeeId)
                .ForeignKey("dbo.Patients", t => t.PatientId_PatientId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.EmployeeID_EmployeeId)
                .Index(t => t.PatientId_PatientId)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.String(nullable: false, maxLength: 128),
                        EmployeeName = c.String(),
                        EmployeeAddress = c.String(),
                        EmployeePhoneNumber = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        Status = c.String(),
                        Department_DepartmentId = c.String(maxLength: 128),
                        Role_RoleId = c.String(maxLength: 128),
                        Attendence_AttendenceId = c.String(maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Departments", t => t.Department_DepartmentId)
                .ForeignKey("dbo.Roles", t => t.Role_RoleId)
                .ForeignKey("dbo.Attendences", t => t.Attendence_AttendenceId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.Department_DepartmentId)
                .Index(t => t.Role_RoleId)
                .Index(t => t.Attendence_AttendenceId)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentId = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        Status = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.DepartmentId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleId = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Status = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.RoleId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        PatientId = c.String(nullable: false, maxLength: 128),
                        PatientName = c.String(),
                        PatientAge = c.Int(nullable: false),
                        PatientGender = c.String(),
                        PatientEmergencyNumber = c.String(),
                        PatientDisease = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PatientId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.Attendences",
                c => new
                    {
                        AttendenceId = c.String(nullable: false, maxLength: 128),
                        Day = c.DateTime(nullable: false),
                        TimeIn = c.DateTime(nullable: false),
                        TimeOut = c.DateTime(nullable: false),
                        Date = c.DateTime(nullable: false),
                        LeaveId_LeaveId = c.String(maxLength: 128),
                        TimeTableId_TimeTableId = c.String(maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.AttendenceId)
                .ForeignKey("dbo.Leaves", t => t.LeaveId_LeaveId)
                .ForeignKey("dbo.TimeTables", t => t.TimeTableId_TimeTableId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.LeaveId_LeaveId)
                .Index(t => t.TimeTableId_TimeTableId)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.Leaves",
                c => new
                    {
                        LeaveId = c.String(nullable: false, maxLength: 128),
                        Detail = c.String(),
                        Absent = c.String(),
                        EmployeeId_EmployeeId = c.String(maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.LeaveId)
                .ForeignKey("dbo.Employees", t => t.EmployeeId_EmployeeId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.EmployeeId_EmployeeId)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.TimeTables",
                c => new
                    {
                        TimeTableId = c.String(nullable: false, maxLength: 128),
                        EmployeeId = c.String(maxLength: 128),
                        ShiftId = c.String(maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.TimeTableId)
                .ForeignKey("dbo.Employees", t => t.EmployeeId)
                .ForeignKey("dbo.Shifts", t => t.ShiftId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.EmployeeId)
                .Index(t => t.ShiftId)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.Shifts",
                c => new
                    {
                        ShiftId = c.String(nullable: false, maxLength: 128),
                        ShiftName = c.String(),
                        ShiftTime = c.DateTime(nullable: false),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ShiftId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.Beds",
                c => new
                    {
                        BedId = c.String(nullable: false, maxLength: 128),
                        BedNumber = c.String(),
                        BedFee = c.Int(nullable: false),
                        RoomID_RoomId = c.String(maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.BedId)
                .ForeignKey("dbo.Rooms", t => t.RoomID_RoomId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.RoomID_RoomId)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomId = c.String(nullable: false, maxLength: 128),
                        RoomNumber = c.String(),
                        DepartmentId_DepartmentId = c.String(maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.RoomId)
                .ForeignKey("dbo.Departments", t => t.DepartmentId_DepartmentId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.DepartmentId_DepartmentId)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        BillId = c.String(nullable: false, maxLength: 128),
                        VisitCharges = c.Int(nullable: false),
                        AdmitCharges = c.Int(nullable: false),
                        TestCharges = c.Int(nullable: false),
                        OtherCharges = c.Int(nullable: false),
                        TotalCharges = c.Int(nullable: false),
                        paidCharges = c.Int(nullable: false),
                        Balance = c.Int(nullable: false),
                        BillType = c.String(),
                        Discount = c.Int(nullable: false),
                        Tax = c.Int(nullable: false),
                        PatientId_PatientId = c.String(maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.BillId)
                .ForeignKey("dbo.Patients", t => t.PatientId_PatientId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.PatientId_PatientId)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.String(nullable: false, maxLength: 128),
                        CategoryName = c.String(),
                        Medicine_MedicineId = c.String(maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.CategoryId)
                .ForeignKey("dbo.Medicines", t => t.Medicine_MedicineId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.Medicine_MedicineId)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.EmployeeSalarySlips",
                c => new
                    {
                        EmployeeSalarySlipId = c.String(nullable: false, maxLength: 128),
                        Deductions = c.Int(nullable: false),
                        ShortLeaves = c.Int(nullable: false),
                        Total = c.Int(nullable: false),
                        isPaid = c.Boolean(nullable: false),
                        EmployeeId_EmployeeId = c.String(maxLength: 128),
                        LeaveId_LeaveId = c.String(maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.EmployeeSalarySlipId)
                .ForeignKey("dbo.Employees", t => t.EmployeeId_EmployeeId)
                .ForeignKey("dbo.Leaves", t => t.LeaveId_LeaveId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.EmployeeId_EmployeeId)
                .Index(t => t.LeaveId_LeaveId)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.Hospitals",
                c => new
                    {
                        HospitalId = c.String(nullable: false, maxLength: 128),
                        HospitalName = c.String(),
                        Website = c.String(),
                        Email = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.HospitalId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.Medicines",
                c => new
                    {
                        MedicineId = c.String(nullable: false, maxLength: 128),
                        MedicineName = c.String(),
                        Stock = c.Int(nullable: false),
                        MedicineExpiryDate = c.DateTime(nullable: false),
                        EntryDate = c.DateTime(nullable: false),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.MedicineId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.PatientDoctors",
                c => new
                    {
                        PatientDoctorId = c.String(nullable: false, maxLength: 128),
                        EmployeeId_EmployeeId = c.String(maxLength: 128),
                        PatientID_PatientId = c.String(maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PatientDoctorId)
                .ForeignKey("dbo.Employees", t => t.EmployeeId_EmployeeId)
                .ForeignKey("dbo.Patients", t => t.PatientID_PatientId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.EmployeeId_EmployeeId)
                .Index(t => t.PatientID_PatientId)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.PatientMedicines",
                c => new
                    {
                        PatientMedicineId = c.String(nullable: false, maxLength: 128),
                        MedicineId_MedicineId = c.String(maxLength: 128),
                        PatientId_PatientId = c.String(maxLength: 128),
                        RegistrationId_RegistrationId = c.String(maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PatientMedicineId)
                .ForeignKey("dbo.Medicines", t => t.MedicineId_MedicineId)
                .ForeignKey("dbo.Patients", t => t.PatientId_PatientId)
                .ForeignKey("dbo.Registrations", t => t.RegistrationId_RegistrationId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.MedicineId_MedicineId)
                .Index(t => t.PatientId_PatientId)
                .Index(t => t.RegistrationId_RegistrationId)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.Registrations",
                c => new
                    {
                        RegistrationId = c.String(nullable: false, maxLength: 128),
                        AdmitDate = c.DateTime(nullable: false),
                        DischargeDate = c.DateTime(nullable: false),
                        Bed_BedId = c.String(maxLength: 128),
                        DepartmentId_DepartmentId = c.String(maxLength: 128),
                        PatientId_PatientId = c.String(maxLength: 128),
                        RoomId_RoomId = c.String(maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.RegistrationId)
                .ForeignKey("dbo.Beds", t => t.Bed_BedId)
                .ForeignKey("dbo.Departments", t => t.DepartmentId_DepartmentId)
                .ForeignKey("dbo.Patients", t => t.PatientId_PatientId)
                .ForeignKey("dbo.Rooms", t => t.RoomId_RoomId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.Bed_BedId)
                .Index(t => t.DepartmentId_DepartmentId)
                .Index(t => t.PatientId_PatientId)
                .Index(t => t.RoomId_RoomId)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.PatientResults",
                c => new
                    {
                        PatientResultId = c.String(nullable: false, maxLength: 128),
                        PatientId_PatientId = c.String(maxLength: 128),
                        ReportId_ReportId = c.String(maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PatientResultId)
                .ForeignKey("dbo.Patients", t => t.PatientId_PatientId)
                .ForeignKey("dbo.Reports", t => t.ReportId_ReportId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.PatientId_PatientId)
                .Index(t => t.ReportId_ReportId)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.Reports",
                c => new
                    {
                        ReportId = c.String(nullable: false, maxLength: 128),
                        ReportResult = c.String(),
                        DeliveryDate = c.DateTime(nullable: false),
                        ReportDate = c.DateTime(nullable: false),
                        ReportFee = c.Int(nullable: false),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ReportId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.Prescriptions",
                c => new
                    {
                        PrescriptionId = c.String(nullable: false, maxLength: 128),
                        PrescriptionDetail = c.String(),
                        PrescriptionAdvice = c.String(),
                        IsRegistered = c.Boolean(nullable: false),
                        EmployeeId_EmployeeId = c.String(maxLength: 128),
                        PatientId_PatientId = c.String(maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PrescriptionId)
                .ForeignKey("dbo.Employees", t => t.EmployeeId_EmployeeId)
                .ForeignKey("dbo.Patients", t => t.PatientId_PatientId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.EmployeeId_EmployeeId)
                .Index(t => t.PatientId_PatientId)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.SalaryDetails",
                c => new
                    {
                        SalaryDetailsID = c.Int(nullable: false, identity: true),
                        Pay = c.Int(nullable: false),
                        DepartmentId_DepartmentId = c.String(maxLength: 128),
                        RoleId_RoleId = c.String(maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.SalaryDetailsID)
                .ForeignKey("dbo.Departments", t => t.DepartmentId_DepartmentId)
                .ForeignKey("dbo.Roles", t => t.RoleId_RoleId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.DepartmentId_DepartmentId)
                .Index(t => t.RoleId_RoleId)
                .Index(t => t.ApplicationUser_Id);
            
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
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TimeTables", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Shifts", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.SalaryDetails", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Rooms", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Roles", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Reports", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Registrations", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Prescriptions", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Patients", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.PatientResults", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.PatientMedicines", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.PatientDoctors", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Medicines", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Leaves", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Hospitals", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.EmployeeSalarySlips", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Employees", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Departments", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Categories", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Bills", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Beds", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Attendences", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Appoitments", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.SalaryDetails", "RoleId_RoleId", "dbo.Roles");
            DropForeignKey("dbo.SalaryDetails", "DepartmentId_DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Prescriptions", "PatientId_PatientId", "dbo.Patients");
            DropForeignKey("dbo.Prescriptions", "EmployeeId_EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.PatientResults", "ReportId_ReportId", "dbo.Reports");
            DropForeignKey("dbo.PatientResults", "PatientId_PatientId", "dbo.Patients");
            DropForeignKey("dbo.PatientMedicines", "RegistrationId_RegistrationId", "dbo.Registrations");
            DropForeignKey("dbo.Registrations", "RoomId_RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Registrations", "PatientId_PatientId", "dbo.Patients");
            DropForeignKey("dbo.Registrations", "DepartmentId_DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Registrations", "Bed_BedId", "dbo.Beds");
            DropForeignKey("dbo.PatientMedicines", "PatientId_PatientId", "dbo.Patients");
            DropForeignKey("dbo.PatientMedicines", "MedicineId_MedicineId", "dbo.Medicines");
            DropForeignKey("dbo.PatientDoctors", "PatientID_PatientId", "dbo.Patients");
            DropForeignKey("dbo.PatientDoctors", "EmployeeId_EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Categories", "Medicine_MedicineId", "dbo.Medicines");
            DropForeignKey("dbo.EmployeeSalarySlips", "LeaveId_LeaveId", "dbo.Leaves");
            DropForeignKey("dbo.EmployeeSalarySlips", "EmployeeId_EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Bills", "PatientId_PatientId", "dbo.Patients");
            DropForeignKey("dbo.Beds", "RoomID_RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Rooms", "DepartmentId_DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Attendences", "TimeTableId_TimeTableId", "dbo.TimeTables");
            DropForeignKey("dbo.TimeTables", "ShiftId", "dbo.Shifts");
            DropForeignKey("dbo.TimeTables", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Attendences", "LeaveId_LeaveId", "dbo.Leaves");
            DropForeignKey("dbo.Leaves", "EmployeeId_EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Employees", "Attendence_AttendenceId", "dbo.Attendences");
            DropForeignKey("dbo.Appoitments", "PatientId_PatientId", "dbo.Patients");
            DropForeignKey("dbo.Appoitments", "EmployeeID_EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Employees", "Role_RoleId", "dbo.Roles");
            DropForeignKey("dbo.Employees", "Department_DepartmentId", "dbo.Departments");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.SalaryDetails", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.SalaryDetails", new[] { "RoleId_RoleId" });
            DropIndex("dbo.SalaryDetails", new[] { "DepartmentId_DepartmentId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Prescriptions", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Prescriptions", new[] { "PatientId_PatientId" });
            DropIndex("dbo.Prescriptions", new[] { "EmployeeId_EmployeeId" });
            DropIndex("dbo.Reports", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.PatientResults", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.PatientResults", new[] { "ReportId_ReportId" });
            DropIndex("dbo.PatientResults", new[] { "PatientId_PatientId" });
            DropIndex("dbo.Registrations", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Registrations", new[] { "RoomId_RoomId" });
            DropIndex("dbo.Registrations", new[] { "PatientId_PatientId" });
            DropIndex("dbo.Registrations", new[] { "DepartmentId_DepartmentId" });
            DropIndex("dbo.Registrations", new[] { "Bed_BedId" });
            DropIndex("dbo.PatientMedicines", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.PatientMedicines", new[] { "RegistrationId_RegistrationId" });
            DropIndex("dbo.PatientMedicines", new[] { "PatientId_PatientId" });
            DropIndex("dbo.PatientMedicines", new[] { "MedicineId_MedicineId" });
            DropIndex("dbo.PatientDoctors", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.PatientDoctors", new[] { "PatientID_PatientId" });
            DropIndex("dbo.PatientDoctors", new[] { "EmployeeId_EmployeeId" });
            DropIndex("dbo.Medicines", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Hospitals", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.EmployeeSalarySlips", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.EmployeeSalarySlips", new[] { "LeaveId_LeaveId" });
            DropIndex("dbo.EmployeeSalarySlips", new[] { "EmployeeId_EmployeeId" });
            DropIndex("dbo.Categories", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Categories", new[] { "Medicine_MedicineId" });
            DropIndex("dbo.Bills", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Bills", new[] { "PatientId_PatientId" });
            DropIndex("dbo.Rooms", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Rooms", new[] { "DepartmentId_DepartmentId" });
            DropIndex("dbo.Beds", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Beds", new[] { "RoomID_RoomId" });
            DropIndex("dbo.Shifts", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.TimeTables", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.TimeTables", new[] { "ShiftId" });
            DropIndex("dbo.TimeTables", new[] { "EmployeeId" });
            DropIndex("dbo.Leaves", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Leaves", new[] { "EmployeeId_EmployeeId" });
            DropIndex("dbo.Attendences", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Attendences", new[] { "TimeTableId_TimeTableId" });
            DropIndex("dbo.Attendences", new[] { "LeaveId_LeaveId" });
            DropIndex("dbo.Patients", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Roles", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Departments", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Employees", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Employees", new[] { "Attendence_AttendenceId" });
            DropIndex("dbo.Employees", new[] { "Role_RoleId" });
            DropIndex("dbo.Employees", new[] { "Department_DepartmentId" });
            DropIndex("dbo.Appoitments", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Appoitments", new[] { "PatientId_PatientId" });
            DropIndex("dbo.Appoitments", new[] { "EmployeeID_EmployeeId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.SalaryDetails");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Prescriptions");
            DropTable("dbo.Reports");
            DropTable("dbo.PatientResults");
            DropTable("dbo.Registrations");
            DropTable("dbo.PatientMedicines");
            DropTable("dbo.PatientDoctors");
            DropTable("dbo.Medicines");
            DropTable("dbo.Hospitals");
            DropTable("dbo.EmployeeSalarySlips");
            DropTable("dbo.Categories");
            DropTable("dbo.Bills");
            DropTable("dbo.Rooms");
            DropTable("dbo.Beds");
            DropTable("dbo.Shifts");
            DropTable("dbo.TimeTables");
            DropTable("dbo.Leaves");
            DropTable("dbo.Attendences");
            DropTable("dbo.Patients");
            DropTable("dbo.Roles");
            DropTable("dbo.Departments");
            DropTable("dbo.Employees");
            DropTable("dbo.Appoitments");
        }
    }
}
