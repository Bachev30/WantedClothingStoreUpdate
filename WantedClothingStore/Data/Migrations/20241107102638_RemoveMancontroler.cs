using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WantedClothingStore.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveMancontroler : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategorySpecificAttribute",
                table: "WomenProducts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "WomenProducts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DressType",
                table: "WomenProducts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FabricType",
                table: "WomenProducts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ClothingType",
                table: "MenProducts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "MenProducts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FitType",
                table: "MenProducts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsPopularItem",
                table: "MenProducts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Material",
                table: "MenProducts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategorySpecificAttribute",
                table: "WomenProducts");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "WomenProducts");

            migrationBuilder.DropColumn(
                name: "DressType",
                table: "WomenProducts");

            migrationBuilder.DropColumn(
                name: "FabricType",
                table: "WomenProducts");

            migrationBuilder.DropColumn(
                name: "ClothingType",
                table: "MenProducts");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "MenProducts");

            migrationBuilder.DropColumn(
                name: "FitType",
                table: "MenProducts");

            migrationBuilder.DropColumn(
                name: "IsPopularItem",
                table: "MenProducts");

            migrationBuilder.DropColumn(
                name: "Material",
                table: "MenProducts");
        }
    }
}
