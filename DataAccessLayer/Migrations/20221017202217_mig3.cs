using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MenuSubCategoryID",
                table: "MenuCategories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BlogId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Services_ServiceCategoryID",
                table: "Services",
                column: "ServiceCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuCategories_MenuSubCategoryID",
                table: "MenuCategories",
                column: "MenuSubCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BlogId",
                table: "Comments",
                column: "BlogId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Blogs_BlogId",
                table: "Comments",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "BlogID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuCategories_MenuSubCategories_MenuSubCategoryID",
                table: "MenuCategories",
                column: "MenuSubCategoryID",
                principalTable: "MenuSubCategories",
                principalColumn: "MenuSubCategoryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_ServiceCategories_ServiceCategoryID",
                table: "Services",
                column: "ServiceCategoryID",
                principalTable: "ServiceCategories",
                principalColumn: "ServiceCategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Blogs_BlogId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuCategories_MenuSubCategories_MenuSubCategoryID",
                table: "MenuCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_ServiceCategories_ServiceCategoryID",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_ServiceCategoryID",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_MenuCategories_MenuSubCategoryID",
                table: "MenuCategories");

            migrationBuilder.DropIndex(
                name: "IX_Comments_BlogId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "MenuSubCategoryID",
                table: "MenuCategories");

            migrationBuilder.DropColumn(
                name: "BlogId",
                table: "Comments");
        }
    }
}
