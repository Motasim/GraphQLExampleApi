using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Employees.Management.Data.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeTypes",
                columns: table => new
                {
                    EmployeeTypeId = table.Column<int>(nullable: false),
                    EmployeeTypeEName = table.Column<string>(nullable: true),
                    EmployeeTypeAName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTypes", x => x.EmployeeTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    GenderId = table.Column<int>(nullable: false),
                    GenderAName = table.Column<string>(maxLength: 100, nullable: true),
                    GenderEName = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.GenderId);
                });

            migrationBuilder.CreateTable(
                name: "Nationalities",
                columns: table => new
                {
                    NationalityId = table.Column<int>(nullable: false),
                    NationalityAName = table.Column<string>(nullable: true),
                    NationalityEName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationalities", x => x.NationalityId);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    PositionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PositionEName = table.Column<string>(nullable: true),
                    PositionAName = table.Column<string>(nullable: true),
                    MinSalary = table.Column<decimal>(nullable: true),
                    MaxSalary = table.Column<decimal>(nullable: true),
                    DateTimeCreated = table.Column<DateTime>(nullable: false),
                    DateTimeLastUpdated = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.PositionId);
                });

            migrationBuilder.CreateTable(
                name: "SalaryComponentTypes",
                columns: table => new
                {
                    SalaryComponentTypeId = table.Column<int>(nullable: false),
                    SalaryComponentTypeAName = table.Column<string>(maxLength: 200, nullable: true),
                    SalaryComponentTypeEName = table.Column<string>(maxLength: 200, nullable: true),
                    MinSalaryComponentValue = table.Column<decimal>(nullable: false),
                    MaxSalaryComponentValue = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryComponentTypes", x => x.SalaryComponentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeTypeId = table.Column<int>(nullable: false),
                    EmployeeName = table.Column<string>(maxLength: 250, nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    GenderId = table.Column<int>(nullable: false),
                    EmployeeImage = table.Column<byte[]>(nullable: true),
                    ManagerId = table.Column<int>(nullable: true),
                    EmploymentDate = table.Column<DateTime>(nullable: false),
                    ResignDate = table.Column<DateTime>(nullable: true),
                    NationalityId = table.Column<int>(nullable: false),
                    DateTimeCreated = table.Column<DateTime>(nullable: false),
                    DateTimeLastUpdated = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_EmployeeTypes_EmployeeTypeId",
                        column: x => x.EmployeeTypeId,
                        principalTable: "EmployeeTypes",
                        principalColumn: "EmployeeTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "GenderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Employees_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Nationalities_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "Nationalities",
                        principalColumn: "NationalityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeesPositions",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false),
                    PositionId = table.Column<int>(nullable: false),
                    DateTimeCreated = table.Column<DateTime>(nullable: false),
                    DateTimeLastUpdated = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesPositions", x => new { x.EmployeeId, x.PositionId });
                    table.ForeignKey(
                        name: "FK_EmployeesPositions_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeesPositions_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "PositionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalaryComponents",
                columns: table => new
                {
                    SalaryComponentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeId = table.Column<int>(nullable: false),
                    PositionId = table.Column<int>(nullable: false),
                    SalaryComponentTypeId = table.Column<int>(nullable: false),
                    SalaryComponentValue = table.Column<decimal>(nullable: false),
                    DateTimeCreated = table.Column<DateTime>(nullable: false),
                    DateTimeLastUpdated = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryComponents", x => x.SalaryComponentId);
                    table.ForeignKey(
                        name: "FK_SalaryComponents_SalaryComponentTypes_SalaryComponentTypeId",
                        column: x => x.SalaryComponentTypeId,
                        principalTable: "SalaryComponentTypes",
                        principalColumn: "SalaryComponentTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalaryComponents_EmployeesPositions_PositionId_EmployeeId",
                        columns: x => new { x.PositionId, x.EmployeeId },
                        principalTable: "EmployeesPositions",
                        principalColumns: new[] { "EmployeeId", "PositionId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeTypeId",
                table: "Employees",
                column: "EmployeeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_GenderId",
                table: "Employees",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ManagerId",
                table: "Employees",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_NationalityId",
                table: "Employees",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesPositions_PositionId",
                table: "EmployeesPositions",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_SalaryComponents_SalaryComponentTypeId",
                table: "SalaryComponents",
                column: "SalaryComponentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SalaryComponents_PositionId_EmployeeId",
                table: "SalaryComponents",
                columns: new[] { "PositionId", "EmployeeId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalaryComponents");

            migrationBuilder.DropTable(
                name: "SalaryComponentTypes");

            migrationBuilder.DropTable(
                name: "EmployeesPositions");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "EmployeeTypes");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Nationalities");
        }
    }
}
