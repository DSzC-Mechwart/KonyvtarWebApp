using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KonyvtarWebApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Konyvek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Cim = table.Column<string>(type: "TEXT", nullable: false),
                    Szerzo = table.Column<string>(type: "TEXT", nullable: false),
                    KiadasEve = table.Column<int>(type: "INTEGER", nullable: false),
                    Ar = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Konyvek", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Konyvek");
        }
    }
}
