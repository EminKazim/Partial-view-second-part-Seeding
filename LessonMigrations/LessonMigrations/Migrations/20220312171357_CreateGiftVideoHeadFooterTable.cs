using Microsoft.EntityFrameworkCore.Migrations;

namespace LessonMigrations.Migrations
{
    public partial class CreateGiftVideoHeadFooterTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GiftFooters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    İsDeleted = table.Column<bool>(nullable: false),
                    Icon = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiftFooters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GiftHeads",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    İsDeleted = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiftHeads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GiftVideos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    İsDeleted = table.Column<bool>(nullable: false),
                    Video = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiftVideos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GiftFooters");

            migrationBuilder.DropTable(
                name: "GiftHeads");

            migrationBuilder.DropTable(
                name: "GiftVideos");
        }
    }
}
