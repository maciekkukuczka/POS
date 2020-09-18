using Microsoft.EntityFrameworkCore.Migrations;


namespace POS.Migrations
{

    public partial class removeImageUserRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_AppUsers_AppUserId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_AppUserId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Images");

            migrationBuilder.AddColumn<int>(
                name: "AvatarId",
                table: "AppUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_AvatarId",
                table: "AppUsers",
                column: "AvatarId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUsers_Images_AvatarId",
                table: "AppUsers",
                column: "AvatarId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUsers_Images_AvatarId",
                table: "AppUsers");

            migrationBuilder.DropIndex(
                name: "IX_AppUsers_AvatarId",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "AvatarId",
                table: "AppUsers");

            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "Images",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Images_AppUserId",
                table: "Images",
                column: "AppUserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_AppUsers_AppUserId",
                table: "Images",
                column: "AppUserId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }

}