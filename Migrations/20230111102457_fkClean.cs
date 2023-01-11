using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Granota.Migrations
{
    /// <inheritdoc />
    public partial class fkClean : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Owner_Restaurant_RestaurantId",
                table: "Owner");

            migrationBuilder.DropForeignKey(
                name: "FK_Restaurant_Owner_OwnerId",
                table: "Restaurant");

            migrationBuilder.DropIndex(
                name: "IX_Owner_RestaurantId",
                table: "Owner");

            migrationBuilder.DropColumn(
                name: "RestaurantId",
                table: "Owner");

            migrationBuilder.AlterColumn<int>(
                name: "OwnerId",
                table: "Restaurant",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurant_Owner_OwnerId",
                table: "Restaurant",
                column: "OwnerId",
                principalTable: "Owner",
                principalColumn: "OwnerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurant_Owner_OwnerId",
                table: "Restaurant");

            migrationBuilder.AlterColumn<int>(
                name: "OwnerId",
                table: "Restaurant",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RestaurantId",
                table: "Owner",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Owner_RestaurantId",
                table: "Owner",
                column: "RestaurantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Owner_Restaurant_RestaurantId",
                table: "Owner",
                column: "RestaurantId",
                principalTable: "Restaurant",
                principalColumn: "RestaurantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurant_Owner_OwnerId",
                table: "Restaurant",
                column: "OwnerId",
                principalTable: "Owner",
                principalColumn: "OwnerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
