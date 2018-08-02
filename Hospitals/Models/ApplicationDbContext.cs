using Hospitals.Models.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hospitals.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }


        public DbSet<Appoitment> Appoitments { get; set; }
        public DbSet<Attendence> Attendences { get; set; }
        public DbSet<Bed> Beds { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeSalarySlip> GetEmployeeSalarySlips { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Leave> Leaves { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientDoctor> PatientDoctors { get; set; }
        public DbSet<PatientMedicine> PatientMedicines { get; set; }
        public DbSet<PatientResult> PatientResults { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<SalaryDetails> SalaryDetails { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<TimeTable> TimeTables { get; set; }
        

    }
}