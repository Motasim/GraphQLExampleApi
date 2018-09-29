using EmployeesManagement.Models.DataModelContracts;
using EmployeesManagement.Models.DataModels;
using EmployeesManagement.Models.DataModels.Lookups;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EmployeesManagement.Data.Persistance
{
    public class EmployeesDataContext : DbContext
    {
        public DbSet<Employee> Employees { set; get; }

        public DbSet<EmployeeType> EmployeeTypes { set; get; }

        public DbSet<Nationality> Nationalities { set; get; }

        public DbSet<Position> Positions { set; get; }

        public DbSet<SalaryComponentType> SalaryComponentTypes { set; get; }

        public DbSet<SalaryComponent> SalaryComponents { set; get; }
        public DbSet<Gender> Genders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder contextOptionsBuilder)
        {
            contextOptionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=EmployeesManagement; Trusted_Connection=True; Integrated Security=True");

            base.OnConfiguring(contextOptionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeePosition>().HasKey(e => new { e.EmployeeId, e.PositionId });
            modelBuilder.Entity<Position>()
           .Property(p => p.DateTimeCreated)
           .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<EmployeeType>().HasData(
                new EmployeeType() { EmployeeTypeId = 1, EmployeeTypeAName = "عقد داخلي", EmployeeTypeEName = "Internal Employee" },
                new EmployeeType() { EmployeeTypeId = 2, EmployeeTypeAName = "عقد توظيف من الخارج", EmployeeTypeEName = "Outsourced" }
                );

            modelBuilder.Entity<Nationality>().HasData(

                new Nationality() { NationalityId = 1, NationalityAName = "سوداني", NationalityEName = "Sudanese" },
                new Nationality() { NationalityId = 2, NationalityAName = "مصري", NationalityEName = "Egyption" },
                new Nationality() { NationalityId = 3, NationalityAName = "سوري", NationalityEName = "Syrian" },
                new Nationality() { NationalityId = 4, NationalityAName = "أردني", NationalityEName = "Jordanian" },
                new Nationality() { NationalityId = 5, NationalityAName = "سعودي", NationalityEName = "Saudi" },
                new Nationality() { NationalityId = 6, NationalityAName = "تونسي", NationalityEName = "Tunisian" },
                new Nationality() { NationalityId = 7, NationalityAName = "أماراتي", NationalityEName = "Emirate" },
                new Nationality() { NationalityId = 8, NationalityAName = "عماني", NationalityEName = "Omani" },
                new Nationality() { NationalityId = 9, NationalityAName = "يمني", NationalityEName = "Yemeni" },
                new Nationality() { NationalityId = 10, NationalityAName = "عراقي", NationalityEName = "Iraqi" },
                new Nationality() { NationalityId = 11, NationalityAName = "لبناني", NationalityEName = "Lebanese" }

            );

            modelBuilder.Entity<Position>().HasData(

                new Position() { PositionId = 1, PositionAName = "المدير التنفيذي", PositionEName = "CEO" },
                new Position() { PositionId = 2, PositionAName = "نائب المدير التنفيذي", PositionEName = "VPO" },
                new Position() { PositionId = 3, PositionAName = "رئيس قطاع", PositionEName = "CXO" },
                new Position() { PositionId = 4, PositionAName = "مدير ادارة", PositionEName = "Director" },
                new Position() { PositionId = 5, PositionAName = "مدير أول", PositionEName = "Senior Manager" },
                new Position() { PositionId = 6, PositionAName = "مدير", PositionEName = "Manager" },
                new Position() { PositionId = 7, PositionAName = "كبير مهندسين", PositionEName = "Senior Engineer" },
                new Position() { PositionId = 8, PositionAName = "مهندس أول", PositionEName = "First Engineer" },
                new Position() { PositionId = 9, PositionAName = "مهندس", PositionEName = "Engineer" },
                new Position() { PositionId = 10, PositionAName = "عامل", PositionEName = "Worker" }

                );

            modelBuilder.Entity<SalaryComponentType>().HasData(

                new SalaryComponentType() { SalaryComponentTypeId = 1, SalaryComponentTypeAName = "مرتب أساسي", SalaryComponentTypeEName = "Base Salary", MinSalaryComponentValue = 3000, MaxSalaryComponentValue = 100000 },
                new SalaryComponentType() { SalaryComponentTypeId = 2, SalaryComponentTypeAName = "مرتب اضافي", SalaryComponentTypeEName = "Additional Salary", MinSalaryComponentValue = 3000, MaxSalaryComponentValue = 100000 },
                new SalaryComponentType() { SalaryComponentTypeId = 3, SalaryComponentTypeAName = "بدل مواصلات", SalaryComponentTypeEName = "Transportation Fee", MinSalaryComponentValue = 1000, MaxSalaryComponentValue = 6000 },
                new SalaryComponentType() { SalaryComponentTypeId = 4, SalaryComponentTypeAName = "بدل سكن", SalaryComponentTypeEName = "Residence Fee", MinSalaryComponentValue = 5000, MaxSalaryComponentValue = 30000 },
                new SalaryComponentType() { SalaryComponentTypeId = 5, SalaryComponentTypeAName = " بدل تأمين صحي", SalaryComponentTypeEName = "Healthcare Fee", MinSalaryComponentValue = 1000, MaxSalaryComponentValue = 10000 }

                );

            modelBuilder.Entity<Gender>().HasData(
                new Gender() { GenderId = 1, GenderAName = "ذكر", GenderEName = "Male" },
                new Gender() { GenderId = 2, GenderAName = "أنثى", GenderEName = "Female" }
                );
        }

        public override int SaveChanges()
        {
            var selectedEntityList = ChangeTracker.Entries()
                                    .Where(x => x.Entity is IAuditable &&
                                    (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in selectedEntityList.Where(e => e.State == EntityState.Added))
            {
                var auditable = entity as IAuditable;
                if (auditable == null) continue;
                auditable.DateTimeCreated = DateTime.Now;
            }

            foreach (var entity in selectedEntityList.Where(e => e.State == EntityState.Modified))
            {
                var auditable = entity as IAuditable;
                if (auditable == null) continue;
                auditable.DateTimeLastUpdated = DateTime.Now;
            }


            return base.SaveChanges();


            //foreach (var eve in e.EntityValidationErrors)
            //{
            //    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
            //        eve.Entry.Entity.GetType().Name, eve.Entry.State);
            //    foreach (var ve in eve.ValidationErrors)
            //    {
            //        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
            //            ve.PropertyName, ve.ErrorMessage);
            //    }


        }

    }

}
