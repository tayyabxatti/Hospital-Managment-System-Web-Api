namespace Hospitals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class assd : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "Attendence_AttendenceId", "dbo.Attendences");
            DropIndex("dbo.Employees", new[] { "Attendence_AttendenceId" });
            RenameColumn(table: "dbo.Employees", name: "Department_DepartmentId", newName: "DepartmentId");
            RenameColumn(table: "dbo.Employees", name: "Role_RoleId", newName: "RoleId");
            RenameColumn(table: "dbo.Registrations", name: "Bed_BedId", newName: "BedId");
            RenameColumn(table: "dbo.Appoitments", name: "EmployeeID_EmployeeId", newName: "EmployeeId");
            RenameColumn(table: "dbo.Appoitments", name: "PatientId_PatientId", newName: "PatientId");
            RenameColumn(table: "dbo.Leaves", name: "EmployeeId_EmployeeId", newName: "EmployeeId");
            RenameColumn(table: "dbo.Attendences", name: "LeaveId_LeaveId", newName: "LeaveId");
            RenameColumn(table: "dbo.Rooms", name: "DepartmentId_DepartmentId", newName: "DepartmentId");
            RenameColumn(table: "dbo.Beds", name: "RoomID_RoomId", newName: "RoomId");
            RenameColumn(table: "dbo.Bills", name: "PatientId_PatientId", newName: "PatiendId");
            RenameColumn(table: "dbo.EmployeeSalarySlips", name: "EmployeeId_EmployeeId", newName: "EmployeeId");
            RenameColumn(table: "dbo.EmployeeSalarySlips", name: "LeaveId_LeaveId", newName: "LeaveId");
            RenameColumn(table: "dbo.PatientDoctors", name: "EmployeeId_EmployeeId", newName: "EmployeeId");
            RenameColumn(table: "dbo.PatientDoctors", name: "PatientID_PatientId", newName: "PatientId");
            RenameColumn(table: "dbo.PatientMedicines", name: "MedicineId_MedicineId", newName: "MedicineId");
            RenameColumn(table: "dbo.PatientMedicines", name: "PatientId_PatientId", newName: "PatientId");
            RenameColumn(table: "dbo.Registrations", name: "RoomId_RoomId", newName: "RoomId");
            RenameColumn(table: "dbo.PatientMedicines", name: "RegistrationId_RegistrationId", newName: "RegistrationId");
            RenameColumn(table: "dbo.PatientResults", name: "PatientId_PatientId", newName: "PatientId");
            RenameColumn(table: "dbo.PatientResults", name: "ReportId_ReportId", newName: "ReportId");
            RenameColumn(table: "dbo.Prescriptions", name: "EmployeeId_EmployeeId", newName: "EmployeeId");
            RenameColumn(table: "dbo.Prescriptions", name: "PatientId_PatientId", newName: "PatientId");
            RenameColumn(table: "dbo.SalaryDetails", name: "DepartmentId_DepartmentId", newName: "DepartmentId");
            RenameIndex(table: "dbo.Appoitments", name: "IX_EmployeeID_EmployeeId", newName: "IX_EmployeeId");
            RenameIndex(table: "dbo.Appoitments", name: "IX_PatientId_PatientId", newName: "IX_PatientId");
            RenameIndex(table: "dbo.Employees", name: "IX_Department_DepartmentId", newName: "IX_DepartmentId");
            RenameIndex(table: "dbo.Employees", name: "IX_Role_RoleId", newName: "IX_RoleId");
            RenameIndex(table: "dbo.Attendences", name: "IX_LeaveId_LeaveId", newName: "IX_LeaveId");
            RenameIndex(table: "dbo.Leaves", name: "IX_EmployeeId_EmployeeId", newName: "IX_EmployeeId");
            RenameIndex(table: "dbo.Beds", name: "IX_RoomID_RoomId", newName: "IX_RoomId");
            RenameIndex(table: "dbo.Rooms", name: "IX_DepartmentId_DepartmentId", newName: "IX_DepartmentId");
            RenameIndex(table: "dbo.Bills", name: "IX_PatientId_PatientId", newName: "IX_PatiendId");
            RenameIndex(table: "dbo.EmployeeSalarySlips", name: "IX_EmployeeId_EmployeeId", newName: "IX_EmployeeId");
            RenameIndex(table: "dbo.EmployeeSalarySlips", name: "IX_LeaveId_LeaveId", newName: "IX_LeaveId");
            RenameIndex(table: "dbo.PatientDoctors", name: "IX_PatientID_PatientId", newName: "IX_PatientId");
            RenameIndex(table: "dbo.PatientDoctors", name: "IX_EmployeeId_EmployeeId", newName: "IX_EmployeeId");
            RenameIndex(table: "dbo.PatientMedicines", name: "IX_PatientId_PatientId", newName: "IX_PatientId");
            RenameIndex(table: "dbo.PatientMedicines", name: "IX_RegistrationId_RegistrationId", newName: "IX_RegistrationId");
            RenameIndex(table: "dbo.PatientMedicines", name: "IX_MedicineId_MedicineId", newName: "IX_MedicineId");
            RenameIndex(table: "dbo.Registrations", name: "IX_Bed_BedId", newName: "IX_BedId");
            RenameIndex(table: "dbo.Registrations", name: "IX_RoomId_RoomId", newName: "IX_RoomId");
            RenameIndex(table: "dbo.PatientResults", name: "IX_PatientId_PatientId", newName: "IX_PatientId");
            RenameIndex(table: "dbo.PatientResults", name: "IX_ReportId_ReportId", newName: "IX_ReportId");
            RenameIndex(table: "dbo.Prescriptions", name: "IX_EmployeeId_EmployeeId", newName: "IX_EmployeeId");
            RenameIndex(table: "dbo.Prescriptions", name: "IX_PatientId_PatientId", newName: "IX_PatientId");
            RenameIndex(table: "dbo.SalaryDetails", name: "IX_DepartmentId_DepartmentId", newName: "IX_DepartmentId");
            AddColumn("dbo.Attendences", "EmployeeId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Attendences", "EmployeeId");
            AddForeignKey("dbo.Attendences", "EmployeeId", "dbo.Employees", "EmployeeId");
            DropColumn("dbo.Employees", "Attendence_AttendenceId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Attendence_AttendenceId", c => c.String(maxLength: 128));
            DropForeignKey("dbo.Attendences", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.Attendences", new[] { "EmployeeId" });
            DropColumn("dbo.Attendences", "EmployeeId");
            RenameIndex(table: "dbo.SalaryDetails", name: "IX_DepartmentId", newName: "IX_DepartmentId_DepartmentId");
            RenameIndex(table: "dbo.Prescriptions", name: "IX_PatientId", newName: "IX_PatientId_PatientId");
            RenameIndex(table: "dbo.Prescriptions", name: "IX_EmployeeId", newName: "IX_EmployeeId_EmployeeId");
            RenameIndex(table: "dbo.PatientResults", name: "IX_ReportId", newName: "IX_ReportId_ReportId");
            RenameIndex(table: "dbo.PatientResults", name: "IX_PatientId", newName: "IX_PatientId_PatientId");
            RenameIndex(table: "dbo.Registrations", name: "IX_RoomId", newName: "IX_RoomId_RoomId");
            RenameIndex(table: "dbo.Registrations", name: "IX_BedId", newName: "IX_Bed_BedId");
            RenameIndex(table: "dbo.PatientMedicines", name: "IX_MedicineId", newName: "IX_MedicineId_MedicineId");
            RenameIndex(table: "dbo.PatientMedicines", name: "IX_RegistrationId", newName: "IX_RegistrationId_RegistrationId");
            RenameIndex(table: "dbo.PatientMedicines", name: "IX_PatientId", newName: "IX_PatientId_PatientId");
            RenameIndex(table: "dbo.PatientDoctors", name: "IX_EmployeeId", newName: "IX_EmployeeId_EmployeeId");
            RenameIndex(table: "dbo.PatientDoctors", name: "IX_PatientId", newName: "IX_PatientID_PatientId");
            RenameIndex(table: "dbo.EmployeeSalarySlips", name: "IX_LeaveId", newName: "IX_LeaveId_LeaveId");
            RenameIndex(table: "dbo.EmployeeSalarySlips", name: "IX_EmployeeId", newName: "IX_EmployeeId_EmployeeId");
            RenameIndex(table: "dbo.Bills", name: "IX_PatiendId", newName: "IX_PatientId_PatientId");
            RenameIndex(table: "dbo.Rooms", name: "IX_DepartmentId", newName: "IX_DepartmentId_DepartmentId");
            RenameIndex(table: "dbo.Beds", name: "IX_RoomId", newName: "IX_RoomID_RoomId");
            RenameIndex(table: "dbo.Leaves", name: "IX_EmployeeId", newName: "IX_EmployeeId_EmployeeId");
            RenameIndex(table: "dbo.Attendences", name: "IX_LeaveId", newName: "IX_LeaveId_LeaveId");
            RenameIndex(table: "dbo.Employees", name: "IX_RoleId", newName: "IX_Role_RoleId");
            RenameIndex(table: "dbo.Employees", name: "IX_DepartmentId", newName: "IX_Department_DepartmentId");
            RenameIndex(table: "dbo.Appoitments", name: "IX_PatientId", newName: "IX_PatientId_PatientId");
            RenameIndex(table: "dbo.Appoitments", name: "IX_EmployeeId", newName: "IX_EmployeeID_EmployeeId");
            RenameColumn(table: "dbo.SalaryDetails", name: "DepartmentId", newName: "DepartmentId_DepartmentId");
            RenameColumn(table: "dbo.Prescriptions", name: "PatientId", newName: "PatientId_PatientId");
            RenameColumn(table: "dbo.Prescriptions", name: "EmployeeId", newName: "EmployeeId_EmployeeId");
            RenameColumn(table: "dbo.PatientResults", name: "ReportId", newName: "ReportId_ReportId");
            RenameColumn(table: "dbo.PatientResults", name: "PatientId", newName: "PatientId_PatientId");
            RenameColumn(table: "dbo.PatientMedicines", name: "RegistrationId", newName: "RegistrationId_RegistrationId");
            RenameColumn(table: "dbo.Registrations", name: "RoomId", newName: "RoomId_RoomId");
            RenameColumn(table: "dbo.PatientMedicines", name: "PatientId", newName: "PatientId_PatientId");
            RenameColumn(table: "dbo.PatientMedicines", name: "MedicineId", newName: "MedicineId_MedicineId");
            RenameColumn(table: "dbo.PatientDoctors", name: "PatientId", newName: "PatientID_PatientId");
            RenameColumn(table: "dbo.PatientDoctors", name: "EmployeeId", newName: "EmployeeId_EmployeeId");
            RenameColumn(table: "dbo.EmployeeSalarySlips", name: "LeaveId", newName: "LeaveId_LeaveId");
            RenameColumn(table: "dbo.EmployeeSalarySlips", name: "EmployeeId", newName: "EmployeeId_EmployeeId");
            RenameColumn(table: "dbo.Bills", name: "PatiendId", newName: "PatientId_PatientId");
            RenameColumn(table: "dbo.Beds", name: "RoomId", newName: "RoomID_RoomId");
            RenameColumn(table: "dbo.Rooms", name: "DepartmentId", newName: "DepartmentId_DepartmentId");
            RenameColumn(table: "dbo.Attendences", name: "LeaveId", newName: "LeaveId_LeaveId");
            RenameColumn(table: "dbo.Leaves", name: "EmployeeId", newName: "EmployeeId_EmployeeId");
            RenameColumn(table: "dbo.Appoitments", name: "PatientId", newName: "PatientId_PatientId");
            RenameColumn(table: "dbo.Appoitments", name: "EmployeeId", newName: "EmployeeID_EmployeeId");
            RenameColumn(table: "dbo.Registrations", name: "BedId", newName: "Bed_BedId");
            RenameColumn(table: "dbo.Employees", name: "RoleId", newName: "Role_RoleId");
            RenameColumn(table: "dbo.Employees", name: "DepartmentId", newName: "Department_DepartmentId");
            CreateIndex("dbo.Employees", "Attendence_AttendenceId");
            AddForeignKey("dbo.Employees", "Attendence_AttendenceId", "dbo.Attendences", "AttendenceId");
        }
    }
}
