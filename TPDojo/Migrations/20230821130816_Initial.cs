using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TPDojo.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Armes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Degats = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Samourais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Force = table.Column<int>(type: "int", nullable: false),
                    ArmeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Samourais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Samourais_Armes_ArmeId",
                        column: x => x.ArmeId,
                        principalTable: "Armes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Samourais_ArmeId",
                table: "Samourais",
                column: "ArmeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Samourais");

            migrationBuilder.DropTable(
                name: "Armes");
        }
    }
}
