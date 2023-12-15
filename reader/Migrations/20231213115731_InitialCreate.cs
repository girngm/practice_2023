using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace reader2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ECNs",
                columns: table => new
                {
                    ECNId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ECNs", x => x.ECNId);
                });

            migrationBuilder.CreateTable(
                name: "Makers",
                columns: table => new
                {
                    MakerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Makers", x => x.MakerId);
                });

            migrationBuilder.CreateTable(
                name: "Motors",
                columns: table => new
                {
                    MotorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motors", x => x.MotorId);
                });

            migrationBuilder.CreateTable(
                name: "SHVN_NasosCollection",
                columns: table => new
                {
                    SHVN_NasosId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SHVN_NasosCollection", x => x.SHVN_NasosId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ECNs");

            migrationBuilder.DropTable(
                name: "Makers");

            migrationBuilder.DropTable(
                name: "Motors");

            migrationBuilder.DropTable(
                name: "SHVN_NasosCollection");
        }
    }
}
