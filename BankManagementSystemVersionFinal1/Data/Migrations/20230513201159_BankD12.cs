using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankManagementSystemVersionFinal1.Data.Migrations
{
    /// <inheritdoc />
    public partial class BankD12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transfers_Accounts_AccountId",
                table: "Transfers");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "Transfers",
                newName: "SenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Transfers_AccountId",
                table: "Transfers",
                newName: "IX_Transfers_SenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transfers_Accounts_SenderId",
                table: "Transfers",
                column: "SenderId",
                principalTable: "Accounts",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transfers_Accounts_SenderId",
                table: "Transfers");

            migrationBuilder.RenameColumn(
                name: "SenderId",
                table: "Transfers",
                newName: "AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Transfers_SenderId",
                table: "Transfers",
                newName: "IX_Transfers_AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transfers_Accounts_AccountId",
                table: "Transfers",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
