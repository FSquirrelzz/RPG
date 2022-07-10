using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    public partial class ProfessionAddition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfessionId",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Profession",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Gold = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    HP = table.Column<int>(type: "INTEGER", nullable: false),
                    MP = table.Column<int>(type: "INTEGER", nullable: false),
                    Attack = table.Column<int>(type: "INTEGER", nullable: false),
                    Defense = table.Column<int>(type: "INTEGER", nullable: false),
                    MagicAttack = table.Column<int>(type: "INTEGER", nullable: false),
                    MagicDefense = table.Column<int>(type: "INTEGER", nullable: false),
                    Speed = table.Column<int>(type: "INTEGER", nullable: false),
                    Critical = table.Column<int>(type: "INTEGER", nullable: false),
                    CriticalDamage = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profession", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_ProfessionId",
                table: "Users",
                column: "ProfessionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Profession_ProfessionId",
                table: "Users",
                column: "ProfessionId",
                principalTable: "Profession",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Profession_ProfessionId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Profession");

            migrationBuilder.DropIndex(
                name: "IX_Users_ProfessionId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ProfessionId",
                table: "Users");
        }
    }
}
