﻿// <auto-generated />
using System;
using EmployeesManagement.Data.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Employees.Management.Data.Migrations
{
    [DbContext(typeof(EmployeesDataContext))]
    [Migration("20180929151731_seedingdata")]
    partial class seedingdata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeesManagement.Models.DataModels.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate");

                    b.Property<DateTime>("DateTimeCreated");

                    b.Property<DateTime?>("DateTimeLastUpdated");

                    b.Property<byte[]>("EmployeeImage");

                    b.Property<string>("EmployeeName")
                        .HasMaxLength(250);

                    b.Property<int>("EmployeeTypeId");

                    b.Property<DateTime>("EmploymentDate");

                    b.Property<int>("GenderId");

                    b.Property<int?>("ManagerId");

                    b.Property<int>("NationalityId");

                    b.Property<DateTime?>("ResignDate");

                    b.HasKey("EmployeeId");

                    b.HasIndex("EmployeeTypeId");

                    b.HasIndex("GenderId");

                    b.HasIndex("ManagerId");

                    b.HasIndex("NationalityId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EmployeesManagement.Models.DataModels.EmployeePosition", b =>
                {
                    b.Property<int>("EmployeeId");

                    b.Property<int>("PositionId");

                    b.Property<DateTime>("DateTimeCreated");

                    b.Property<DateTime?>("DateTimeLastUpdated");

                    b.HasKey("EmployeeId", "PositionId");

                    b.HasIndex("PositionId");

                    b.ToTable("EmployeesPositions");
                });

            modelBuilder.Entity("EmployeesManagement.Models.DataModels.Lookups.EmployeeType", b =>
                {
                    b.Property<int>("EmployeeTypeId");

                    b.Property<string>("EmployeeTypeAName");

                    b.Property<string>("EmployeeTypeEName");

                    b.HasKey("EmployeeTypeId");

                    b.ToTable("EmployeeTypes");

                    b.HasData(
                        new { EmployeeTypeId = 1, EmployeeTypeAName = "عقد داخلي", EmployeeTypeEName = "Internal Employee" },
                        new { EmployeeTypeId = 2, EmployeeTypeAName = "عقد توظيف من الخارج", EmployeeTypeEName = "Outsourced" }
                    );
                });

            modelBuilder.Entity("EmployeesManagement.Models.DataModels.Lookups.Gender", b =>
                {
                    b.Property<int>("GenderId");

                    b.Property<string>("GenderAName")
                        .HasMaxLength(100);

                    b.Property<string>("GenderEName")
                        .HasMaxLength(100);

                    b.HasKey("GenderId");

                    b.ToTable("Genders");

                    b.HasData(
                        new { GenderId = 1, GenderAName = "ذكر", GenderEName = "Male" },
                        new { GenderId = 2, GenderAName = "أنثى", GenderEName = "Female" }
                    );
                });

            modelBuilder.Entity("EmployeesManagement.Models.DataModels.Lookups.Nationality", b =>
                {
                    b.Property<int>("NationalityId");

                    b.Property<string>("NationalityAName");

                    b.Property<string>("NationalityEName");

                    b.HasKey("NationalityId");

                    b.ToTable("Nationalities");

                    b.HasData(
                        new { NationalityId = 1, NationalityAName = "سوداني", NationalityEName = "Sudanese" },
                        new { NationalityId = 2, NationalityAName = "مصري", NationalityEName = "Egyption" },
                        new { NationalityId = 3, NationalityAName = "سوري", NationalityEName = "Syrian" },
                        new { NationalityId = 4, NationalityAName = "أردني", NationalityEName = "Jordanian" },
                        new { NationalityId = 5, NationalityAName = "سعودي", NationalityEName = "Saudi" },
                        new { NationalityId = 6, NationalityAName = "تونسي", NationalityEName = "Tunisian" },
                        new { NationalityId = 7, NationalityAName = "أماراتي", NationalityEName = "Emirate" },
                        new { NationalityId = 8, NationalityAName = "عماني", NationalityEName = "Omani" },
                        new { NationalityId = 9, NationalityAName = "يمني", NationalityEName = "Yemeni" },
                        new { NationalityId = 10, NationalityAName = "عراقي", NationalityEName = "Iraqi" },
                        new { NationalityId = 11, NationalityAName = "لبناني", NationalityEName = "Lebanese" }
                    );
                });

            modelBuilder.Entity("EmployeesManagement.Models.DataModels.Lookups.SalaryComponentType", b =>
                {
                    b.Property<int>("SalaryComponentTypeId");

                    b.Property<decimal>("MaxSalaryComponentValue");

                    b.Property<decimal>("MinSalaryComponentValue");

                    b.Property<string>("SalaryComponentTypeAName")
                        .HasMaxLength(200);

                    b.Property<string>("SalaryComponentTypeEName")
                        .HasMaxLength(200);

                    b.HasKey("SalaryComponentTypeId");

                    b.ToTable("SalaryComponentTypes");

                    b.HasData(
                        new { SalaryComponentTypeId = 1, MaxSalaryComponentValue = 100000m, MinSalaryComponentValue = 3000m, SalaryComponentTypeAName = "مرتب أساسي", SalaryComponentTypeEName = "Base Salary" },
                        new { SalaryComponentTypeId = 2, MaxSalaryComponentValue = 100000m, MinSalaryComponentValue = 3000m, SalaryComponentTypeAName = "مرتب اضافي", SalaryComponentTypeEName = "Additional Salary" },
                        new { SalaryComponentTypeId = 3, MaxSalaryComponentValue = 6000m, MinSalaryComponentValue = 1000m, SalaryComponentTypeAName = "بدل مواصلات", SalaryComponentTypeEName = "Transportation Fee" },
                        new { SalaryComponentTypeId = 4, MaxSalaryComponentValue = 30000m, MinSalaryComponentValue = 5000m, SalaryComponentTypeAName = "بدل سكن", SalaryComponentTypeEName = "Residence Fee" },
                        new { SalaryComponentTypeId = 5, MaxSalaryComponentValue = 10000m, MinSalaryComponentValue = 1000m, SalaryComponentTypeAName = " بدل تأمين صحي", SalaryComponentTypeEName = "Healthcare Fee" }
                    );
                });

            modelBuilder.Entity("EmployeesManagement.Models.DataModels.Position", b =>
                {
                    b.Property<int>("PositionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTimeCreated")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime?>("DateTimeLastUpdated");

                    b.Property<decimal?>("MaxSalary");

                    b.Property<decimal?>("MinSalary");

                    b.Property<string>("PositionAName");

                    b.Property<string>("PositionEName");

                    b.HasKey("PositionId");

                    b.ToTable("Positions");

                    b.HasData(
                        new { PositionId = 1, DateTimeCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), PositionAName = "المدير التنفيذي", PositionEName = "CEO" },
                        new { PositionId = 2, DateTimeCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), PositionAName = "نائب المدير التنفيذي", PositionEName = "VPO" },
                        new { PositionId = 3, DateTimeCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), PositionAName = "رئيس قطاع", PositionEName = "CXO" },
                        new { PositionId = 4, DateTimeCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), PositionAName = "مدير ادارة", PositionEName = "Director" },
                        new { PositionId = 5, DateTimeCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), PositionAName = "مدير أول", PositionEName = "Senior Manager" },
                        new { PositionId = 6, DateTimeCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), PositionAName = "مدير", PositionEName = "Manager" },
                        new { PositionId = 7, DateTimeCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), PositionAName = "كبير مهندسين", PositionEName = "Senior Engineer" },
                        new { PositionId = 8, DateTimeCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), PositionAName = "مهندس أول", PositionEName = "First Engineer" },
                        new { PositionId = 9, DateTimeCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), PositionAName = "مهندس", PositionEName = "Engineer" },
                        new { PositionId = 10, DateTimeCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), PositionAName = "عامل", PositionEName = "Worker" }
                    );
                });

            modelBuilder.Entity("EmployeesManagement.Models.DataModels.SalaryComponent", b =>
                {
                    b.Property<int>("SalaryComponentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTimeCreated");

                    b.Property<DateTime?>("DateTimeLastUpdated");

                    b.Property<int>("EmployeeId");

                    b.Property<int>("PositionId");

                    b.Property<int>("SalaryComponentTypeId");

                    b.Property<decimal>("SalaryComponentValue");

                    b.HasKey("SalaryComponentId");

                    b.HasIndex("SalaryComponentTypeId");

                    b.HasIndex("PositionId", "EmployeeId");

                    b.ToTable("SalaryComponents");
                });

            modelBuilder.Entity("EmployeesManagement.Models.DataModels.Employee", b =>
                {
                    b.HasOne("EmployeesManagement.Models.DataModels.Lookups.EmployeeType", "EmployeeType")
                        .WithMany()
                        .HasForeignKey("EmployeeTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EmployeesManagement.Models.DataModels.Lookups.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EmployeesManagement.Models.DataModels.Employee", "Manager")
                        .WithMany("SubOrdinates")
                        .HasForeignKey("ManagerId");

                    b.HasOne("EmployeesManagement.Models.DataModels.Lookups.Nationality", "Nationality")
                        .WithMany()
                        .HasForeignKey("NationalityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EmployeesManagement.Models.DataModels.EmployeePosition", b =>
                {
                    b.HasOne("EmployeesManagement.Models.DataModels.Employee", "Employee")
                        .WithMany("EmployeePositions")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EmployeesManagement.Models.DataModels.Position", "Position")
                        .WithMany("EmployeePositions")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EmployeesManagement.Models.DataModels.SalaryComponent", b =>
                {
                    b.HasOne("EmployeesManagement.Models.DataModels.Lookups.SalaryComponentType", "SalaryComponentType")
                        .WithMany()
                        .HasForeignKey("SalaryComponentTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EmployeesManagement.Models.DataModels.EmployeePosition", "EmployeePosition")
                        .WithMany("SalaryComponents")
                        .HasForeignKey("PositionId", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
