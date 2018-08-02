using Hospitals.Models.Database;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace Hospitals.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Hometown { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public virtual ICollection<Appoitment> Appoitments { get; set; }
        public virtual ICollection<Attendence> Attendences { get; set; }
        public virtual ICollection<Bed> Beds { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<EmployeeSalarySlip> GetEmployeeSalarySlips { get; set; }
        public virtual ICollection<Hospital> Hospitals { get; set; }
        public virtual ICollection<Leave> Leaves { get; set; }

        public virtual ICollection<Medicine> Medicines { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
        public virtual ICollection<PatientDoctor> PatientDoctors { get; set; }
        public virtual ICollection<PatientMedicine> PatientMedicines { get; set; }
        public virtual ICollection<PatientResult> PatientResults { get; set; }
        public virtual ICollection<Prescription> Prescriptions { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
        public virtual ICollection<Role> Role { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
        public virtual ICollection<SalaryDetails> SalaryDetails { get; set; }
        public virtual ICollection<Shift> Shifts { get; set; }
        public virtual ICollection<TimeTable> TimeTables { get; set; }

    }
}