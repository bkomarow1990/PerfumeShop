using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class CategoriesRename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Ctaegories_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ctaegories",
                table: "Ctaegories");

            migrationBuilder.RenameTable(
                name: "Ctaegories",
                newName: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Ctaegories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ctaegories",
                table: "Ctaegories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Ctaegories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Ctaegories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
