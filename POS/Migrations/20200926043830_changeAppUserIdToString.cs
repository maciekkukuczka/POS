using Microsoft.EntityFrameworkCore.Migrations;


namespace POS.Migrations
{

    public partial class changeAppUserIdToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_AspNetUsers_AppUserId1",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_AspNetUsers_AppUserId1",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Newses_AspNetUsers_AppUserId1",
                table: "Newses");

            migrationBuilder.DropIndex(
                name: "IX_Newses_AppUserId1",
                table: "Newses");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_AppUserId1",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_AppUserId1",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "AppUserId1",
                table: "Newses");

            migrationBuilder.DropColumn(
                name: "AppUserId1",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "AppUserId1",
                table: "Addresses");

            migrationBuilder.AlterColumn<string>(
                name: "AppUserId",
                table: "Newses",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "AppUserId",
                table: "Contacts",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "AppUserId",
                table: "Addresses",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Newses_AppUserId",
                table: "Newses",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_AppUserId",
                table: "Contacts",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_AppUserId",
                table: "Addresses",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_AspNetUsers_AppUserId",
                table: "Addresses",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_AspNetUsers_AppUserId",
                table: "Contacts",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Newses_AspNetUsers_AppUserId",
                table: "Newses",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_AspNetUsers_AppUserId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_AspNetUsers_AppUserId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Newses_AspNetUsers_AppUserId",
                table: "Newses");

            migrationBuilder.DropIndex(
                name: "IX_Newses_AppUserId",
                table: "Newses");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_AppUserId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_AppUserId",
                table: "Addresses");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "Newses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId1",
                table: "Newses",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId1",
                table: "Contacts",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "Addresses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId1",
                table: "Addresses",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Newses_AppUserId1",
                table: "Newses",
                column: "AppUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_AppUserId1",
                table: "Contacts",
                column: "AppUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_AppUserId1",
                table: "Addresses",
                column: "AppUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_AspNetUsers_AppUserId1",
                table: "Addresses",
                column: "AppUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_AspNetUsers_AppUserId1",
                table: "Contacts",
                column: "AppUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Newses_AspNetUsers_AppUserId1",
                table: "Newses",
                column: "AppUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }

}