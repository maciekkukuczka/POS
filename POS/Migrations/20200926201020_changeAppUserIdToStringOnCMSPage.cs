using Microsoft.EntityFrameworkCore.Migrations;


namespace POS.Migrations
{

    public partial class changeAppUserIdToStringOnCMSPage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CmsPages_AspNetUsers_AppUserId1",
                table: "CmsPages");

            migrationBuilder.DropIndex(
                name: "IX_CmsPages_AppUserId1",
                table: "CmsPages");

            migrationBuilder.DropColumn(
                name: "AppUserId1",
                table: "CmsPages");

            migrationBuilder.AlterColumn<string>(
                name: "AppUserId",
                table: "CmsPages",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_CmsPages_AppUserId",
                table: "CmsPages",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CmsPages_AspNetUsers_AppUserId",
                table: "CmsPages",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CmsPages_AspNetUsers_AppUserId",
                table: "CmsPages");

            migrationBuilder.DropIndex(
                name: "IX_CmsPages_AppUserId",
                table: "CmsPages");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "CmsPages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId1",
                table: "CmsPages",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CmsPages_AppUserId1",
                table: "CmsPages",
                column: "AppUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CmsPages_AspNetUsers_AppUserId1",
                table: "CmsPages",
                column: "AppUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }

}