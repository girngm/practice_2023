using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace reader2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ECNs",
                table: "ECNs");

            migrationBuilder.DropColumn(
                name: "ECNId",
                table: "ECNs");

            migrationBuilder.AddColumn<string>(
                name: "Dgabarit",
                table: "SHVN_NasosCollection",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Freq",
                table: "SHVN_NasosCollection",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "H",
                table: "SHVN_NasosCollection",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Hopt",
                table: "SHVN_NasosCollection",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "L",
                table: "SHVN_NasosCollection",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Maker",
                table: "SHVN_NasosCollection",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "SHVN_NasosCollection",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nju",
                table: "SHVN_NasosCollection",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "d",
                table: "SHVN_NasosCollection",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "q100",
                table: "SHVN_NasosCollection",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cos",
                table: "Motors",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Freq",
                table: "Motors",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "I",
                table: "Motors",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "L",
                table: "Motors",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Maker",
                table: "Motors",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "N",
                table: "Motors",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Omega",
                table: "Motors",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Polus",
                table: "Motors",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Slide",
                table: "Motors",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "T",
                table: "Motors",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TYPE",
                table: "Motors",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "U",
                table: "Motors",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "d",
                table: "Motors",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "nju",
                table: "Motors",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "w",
                table: "Motors",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ID",
                table: "ECNs",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "H",
                table: "ECNs",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "L",
                table: "ECNs",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "N",
                table: "ECNs",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ECNs",
                table: "ECNs",
                column: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ECNs",
                table: "ECNs");

            migrationBuilder.DropColumn(
                name: "Dgabarit",
                table: "SHVN_NasosCollection");

            migrationBuilder.DropColumn(
                name: "Freq",
                table: "SHVN_NasosCollection");

            migrationBuilder.DropColumn(
                name: "H",
                table: "SHVN_NasosCollection");

            migrationBuilder.DropColumn(
                name: "Hopt",
                table: "SHVN_NasosCollection");

            migrationBuilder.DropColumn(
                name: "L",
                table: "SHVN_NasosCollection");

            migrationBuilder.DropColumn(
                name: "Maker",
                table: "SHVN_NasosCollection");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "SHVN_NasosCollection");

            migrationBuilder.DropColumn(
                name: "Nju",
                table: "SHVN_NasosCollection");

            migrationBuilder.DropColumn(
                name: "d",
                table: "SHVN_NasosCollection");

            migrationBuilder.DropColumn(
                name: "q100",
                table: "SHVN_NasosCollection");

            migrationBuilder.DropColumn(
                name: "Cos",
                table: "Motors");

            migrationBuilder.DropColumn(
                name: "Freq",
                table: "Motors");

            migrationBuilder.DropColumn(
                name: "I",
                table: "Motors");

            migrationBuilder.DropColumn(
                name: "L",
                table: "Motors");

            migrationBuilder.DropColumn(
                name: "Maker",
                table: "Motors");

            migrationBuilder.DropColumn(
                name: "N",
                table: "Motors");

            migrationBuilder.DropColumn(
                name: "Omega",
                table: "Motors");

            migrationBuilder.DropColumn(
                name: "Polus",
                table: "Motors");

            migrationBuilder.DropColumn(
                name: "Slide",
                table: "Motors");

            migrationBuilder.DropColumn(
                name: "T",
                table: "Motors");

            migrationBuilder.DropColumn(
                name: "TYPE",
                table: "Motors");

            migrationBuilder.DropColumn(
                name: "U",
                table: "Motors");

            migrationBuilder.DropColumn(
                name: "d",
                table: "Motors");

            migrationBuilder.DropColumn(
                name: "nju",
                table: "Motors");

            migrationBuilder.DropColumn(
                name: "w",
                table: "Motors");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "ECNs");

            migrationBuilder.DropColumn(
                name: "H",
                table: "ECNs");

            migrationBuilder.DropColumn(
                name: "L",
                table: "ECNs");

            migrationBuilder.DropColumn(
                name: "N",
                table: "ECNs");

            migrationBuilder.AddColumn<int>(
                name: "ECNId",
                table: "ECNs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ECNs",
                table: "ECNs",
                column: "ECNId");
        }
    }
}
