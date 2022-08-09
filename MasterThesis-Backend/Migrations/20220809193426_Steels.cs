using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MasterThesis_Backend.Migrations
{
    public partial class Steels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Steels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SteelGrade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instruction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CastingType = table.Column<int>(type: "int", nullable: false),
                    maxAmountOfCasting = table.Column<int>(type: "int", nullable: false),
                    waitTime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Steels", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Steels");
        }
    }
}
