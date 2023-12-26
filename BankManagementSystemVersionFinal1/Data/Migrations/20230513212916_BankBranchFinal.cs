using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankManagementSystemVersionFinal1.Data.Migrations
{
    /// <inheritdoc />
    public partial class BankBranchFinal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankBranches_Employees_ManagerId",
                table: "BankBranches");

            migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "Transfers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Transfers");

            migrationBuilder.DropColumn(
                name: "LoginId",
                table: "Transfers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Transfers");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Transfers");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "BankBranches");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    LoginId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.LoginId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.AddColumn<string>(
                name: "ConfirmPassword",
                table: "Transfers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Transfers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "LoginId",
                table: "Transfers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Transfers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Transfers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                table: "BankBranches",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BankBranches_Employees_ManagerId",
                table: "BankBranches",
                column: "ManagerId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
