using Microsoft.EntityFrameworkCore.Migrations;


namespace POS.Migrations
{

    public partial class TinyModelsChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GamesGroupNews_Newses_BlogPostsId",
                table: "GamesGroupNews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GamesGroupNews",
                table: "GamesGroupNews");

            migrationBuilder.DropIndex(
                name: "IX_GamesGroupNews_GamesGroupsId",
                table: "GamesGroupNews");

            migrationBuilder.RenameColumn(
                name: "BlogPostsId",
                table: "GamesGroupNews",
                newName: "NewsesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GamesGroupNews",
                table: "GamesGroupNews",
                columns: new[] {"GamesGroupsId", "NewsesId"});

            migrationBuilder.CreateIndex(
                name: "IX_GamesGroupNews_NewsesId",
                table: "GamesGroupNews",
                column: "NewsesId");

            migrationBuilder.AddForeignKey(
                name: "FK_GamesGroupNews_Newses_NewsesId",
                table: "GamesGroupNews",
                column: "NewsesId",
                principalTable: "Newses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GamesGroupNews_Newses_NewsesId",
                table: "GamesGroupNews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GamesGroupNews",
                table: "GamesGroupNews");

            migrationBuilder.DropIndex(
                name: "IX_GamesGroupNews_NewsesId",
                table: "GamesGroupNews");

            migrationBuilder.RenameColumn(
                name: "NewsesId",
                table: "GamesGroupNews",
                newName: "BlogPostsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GamesGroupNews",
                table: "GamesGroupNews",
                columns: new[] {"BlogPostsId", "GamesGroupsId"});

            migrationBuilder.CreateIndex(
                name: "IX_GamesGroupNews_GamesGroupsId",
                table: "GamesGroupNews",
                column: "GamesGroupsId");

            migrationBuilder.AddForeignKey(
                name: "FK_GamesGroupNews_Newses_BlogPostsId",
                table: "GamesGroupNews",
                column: "BlogPostsId",
                principalTable: "Newses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }

}