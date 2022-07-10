using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    public partial class IconAddition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Profession_ProfessionId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Profession",
                table: "Profession");

            migrationBuilder.RenameTable(
                name: "Profession",
                newName: "Character");

            migrationBuilder.AlterColumn<int>(
                name: "Gold",
                table: "Character",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Character",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "IconID",
                table: "Character",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Character",
                table: "Character",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Icon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Icon", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Character_IconID",
                table: "Character",
                column: "IconID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Character_Icon_IconID",
                table: "Character",
                column: "IconID",
                principalTable: "Icon",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Character_ProfessionId",
                table: "Users",
                column: "ProfessionId",
                principalTable: "Character",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Character_Icon_IconID",
                table: "Character");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Character_ProfessionId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Icon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Character",
                table: "Character");

            migrationBuilder.DropIndex(
                name: "IX_Character_IconID",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "IconID",
                table: "Character");

            migrationBuilder.RenameTable(
                name: "Character",
                newName: "Profession");

            migrationBuilder.AlterColumn<int>(
                name: "Gold",
                table: "Profession",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profession",
                table: "Profession",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Profession_ProfessionId",
                table: "Users",
                column: "ProfessionId",
                principalTable: "Profession",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
