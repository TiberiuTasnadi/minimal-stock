using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinimalStock.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Oid = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Oid);
                });

            migrationBuilder.CreateTable(
                name: "Fields",
                columns: table => new
                {
                    Oid = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fields", x => x.Oid);
                });

            migrationBuilder.CreateTable(
                name: "CategoriesConfiguration",
                columns: table => new
                {
                    Oid = table.Column<Guid>(type: "TEXT", nullable: false),
                    CategoryOid = table.Column<Guid>(type: "TEXT", nullable: false),
                    FieldOid = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriesConfiguration", x => x.Oid);
                    table.ForeignKey(
                        name: "FK_CategoriesConfiguration_Categories_CategoryOid",
                        column: x => x.CategoryOid,
                        principalTable: "Categories",
                        principalColumn: "Oid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriesConfiguration_Fields_FieldOid",
                        column: x => x.FieldOid,
                        principalTable: "Fields",
                        principalColumn: "Oid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoriesConfiguration_CategoryOid",
                table: "CategoriesConfiguration",
                column: "CategoryOid");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriesConfiguration_FieldOid",
                table: "CategoriesConfiguration",
                column: "FieldOid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriesConfiguration");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Fields");
        }
    }
}
