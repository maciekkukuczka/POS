using Microsoft.EntityFrameworkCore.Migrations;


namespace POS.Migrations
{

    public partial class addClassToBaseEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "Ranks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "Newses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "Images",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "GamesGroups",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "Galleries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "ContactTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "CmsPages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "Bloods",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Class",
                table: "Ranks");

            migrationBuilder.DropColumn(
                name: "Class",
                table: "Newses");

            migrationBuilder.DropColumn(
                name: "Class",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "Class",
                table: "GamesGroups");

            migrationBuilder.DropColumn(
                name: "Class",
                table: "Galleries");

            migrationBuilder.DropColumn(
                name: "Class",
                table: "ContactTypes");

            migrationBuilder.DropColumn(
                name: "Class",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Class",
                table: "CmsPages");

            migrationBuilder.DropColumn(
                name: "Class",
                table: "Bloods");

            migrationBuilder.DropColumn(
                name: "Class",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "Class",
                table: "Addresses");
        }
    }

}