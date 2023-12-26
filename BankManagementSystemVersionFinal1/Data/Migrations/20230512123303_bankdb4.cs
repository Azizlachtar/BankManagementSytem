using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankManagementSystemVersionFinal1.Data.Migrations
{
    /// <inheritdoc />
    public partial class bankdb4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_BankBranches_BankBranchBranchId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_BankBranches_ManagerId",
                table: "BankBranches");

            migrationBuilder.RenameColumn(
                name: "BankBranchBranchId",
                table: "Customers",
                newName: "BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_BankBranchBranchId",
                table: "Customers",
                newName: "IX_Customers_BranchId");

            migrationBuilder.AlterColumn<int>(
                name: "ManagerId",
                table: "BankBranches",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_BankBranches_ManagerId",
                table: "BankBranches",
                column: "ManagerId",
                unique: true,
                filter: "[ManagerId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_BankBranches_BranchId",
                table: "Customers",
                column: "BranchId",
                principalTable: "BankBranches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_BankBranches_BranchId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_BankBranches_ManagerId",
                table: "BankBranches");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "Customers",
                newName: "BankBranchBranchId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_BranchId",
                table: "Customers",
                newName: "IX_Customers_BankBranchBranchId");

            migrationBuilder.AlterColumn<int>(
                name: "ManagerId",
                table: "BankBranches",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BankBranches_ManagerId",
                table: "BankBranches",
                column: "ManagerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_BankBranches_BankBranchBranchId",
                table: "Customers",
                column: "BankBranchBranchId",
                principalTable: "BankBranches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
