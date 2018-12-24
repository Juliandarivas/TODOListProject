using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TODOList.Repositories.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "TDL");

            migrationBuilder.CreateTable(
                name: "Categories",
                schema: "TDL",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Color = table.Column<string>(type: "VARCHAR(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                });

            migrationBuilder.CreateTable(
                name: "Lists",
                schema: "TDL",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Bookmark = table.Column<bool>(type: "BIT", nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ExpirationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lists", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_Lists_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "TDL",
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Elements",
                schema: "TDL",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ListId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Priority = table.Column<int>(nullable: false),
                    IsDone = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elements", x => x.Id)
                        .Annotation("SqlServer:Clustered", true);
                    table.ForeignKey(
                        name: "FK_Elements_Lists_ListId",
                        column: x => x.ListId,
                        principalSchema: "TDL",
                        principalTable: "Lists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Elements_ListId",
                schema: "TDL",
                table: "Elements",
                column: "ListId");

            migrationBuilder.CreateIndex(
                name: "IX_Lists_CategoryId",
                schema: "TDL",
                table: "Lists",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Elements",
                schema: "TDL");

            migrationBuilder.DropTable(
                name: "Lists",
                schema: "TDL");

            migrationBuilder.DropTable(
                name: "Categories",
                schema: "TDL");
        }
    }
}
