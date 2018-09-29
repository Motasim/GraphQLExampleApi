using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Employees.Management.Data.Migrations
{
    public partial class seedingdataValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EmployeeTypes",
                columns: new[] { "EmployeeTypeId", "EmployeeTypeAName", "EmployeeTypeEName" },
                values: new object[,]
                {
                    { 1, "عقد داخلي", "Internal Employee" },
                    { 2, "عقد توظيف من الخارج", "Outsourced" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderId", "GenderAName", "GenderEName" },
                values: new object[,]
                {
                    { 1, "ذكر", "Male" },
                    { 2, "أنثى", "Female" }
                });

            migrationBuilder.InsertData(
                table: "Nationalities",
                columns: new[] { "NationalityId", "NationalityAName", "NationalityEName" },
                values: new object[,]
                {
                    { 10, "عراقي", "Iraqi" },
                    { 9, "يمني", "Yemeni" },
                    { 8, "عماني", "Omani" },
                    { 7, "أماراتي", "Emirate" },
                    { 6, "تونسي", "Tunisian" },
                    { 11, "لبناني", "Lebanese" },
                    { 4, "أردني", "Jordanian" },
                    { 3, "سوري", "Syrian" },
                    { 2, "مصري", "Egyption" },
                    { 1, "سوداني", "Sudanese" },
                    { 5, "سعودي", "Saudi" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "PositionId", "DateTimeCreated", "DateTimeLastUpdated", "MaxSalary", "MinSalary", "PositionAName", "PositionEName" },
                values: new object[,]
                {
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "مهندس أول", "First Engineer" },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "كبير مهندسين", "Senior Engineer" },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "مدير", "Manager" },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "مدير أول", "Senior Manager" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "مدير ادارة", "Director" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "رئيس قطاع", "CXO" },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "عامل", "Worker" },
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "المدير التنفيذي", "CEO" },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "مهندس", "Engineer" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "نائب المدير التنفيذي", "VPO" }
                });

            migrationBuilder.InsertData(
                table: "SalaryComponentTypes",
                columns: new[] { "SalaryComponentTypeId", "MaxSalaryComponentValue", "MinSalaryComponentValue", "SalaryComponentTypeAName", "SalaryComponentTypeEName" },
                values: new object[,]
                {
                    { 4, 30000m, 5000m, "بدل سكن", "Residence Fee" },
                    { 3, 6000m, 1000m, "بدل مواصلات", "Transportation Fee" },
                    { 2, 100000m, 3000m, "مرتب اضافي", "Additional Salary" },
                    { 1, 100000m, 3000m, "مرتب أساسي", "Base Salary" },
                    { 5, 10000m, 1000m, " بدل تأمين صحي", "Healthcare Fee" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeTypes",
                keyColumn: "EmployeeTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EmployeeTypes",
                keyColumn: "EmployeeTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "GenderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Nationalities",
                keyColumn: "NationalityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Nationalities",
                keyColumn: "NationalityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Nationalities",
                keyColumn: "NationalityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Nationalities",
                keyColumn: "NationalityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Nationalities",
                keyColumn: "NationalityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Nationalities",
                keyColumn: "NationalityId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Nationalities",
                keyColumn: "NationalityId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Nationalities",
                keyColumn: "NationalityId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Nationalities",
                keyColumn: "NationalityId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Nationalities",
                keyColumn: "NationalityId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Nationalities",
                keyColumn: "NationalityId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PositionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PositionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PositionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PositionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PositionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PositionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PositionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PositionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PositionId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "PositionId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SalaryComponentTypes",
                keyColumn: "SalaryComponentTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SalaryComponentTypes",
                keyColumn: "SalaryComponentTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SalaryComponentTypes",
                keyColumn: "SalaryComponentTypeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SalaryComponentTypes",
                keyColumn: "SalaryComponentTypeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SalaryComponentTypes",
                keyColumn: "SalaryComponentTypeId",
                keyValue: 5);
        }
    }
}
