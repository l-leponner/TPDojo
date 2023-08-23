using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TPDojo.Migrations
{
    /// <inheritdoc />
    public partial class ArtsMartiaux : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArtsMartiaux",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtsMartiaux", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArtMartialSamourai",
                columns: table => new
                {
                    ArtsMartiauxId = table.Column<int>(type: "int", nullable: false),
                    SamouraisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtMartialSamourai", x => new { x.ArtsMartiauxId, x.SamouraisId });
                    table.ForeignKey(
                        name: "FK_ArtMartialSamourai_ArtsMartiaux_ArtsMartiauxId",
                        column: x => x.ArtsMartiauxId,
                        principalTable: "ArtsMartiaux",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtMartialSamourai_Samourais_SamouraisId",
                        column: x => x.SamouraisId,
                        principalTable: "Samourais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 100,
                column: "Force",
                value: 851);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 101,
                column: "Force",
                value: 1495);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 102,
                column: "Force",
                value: 1079);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 103,
                column: "Force",
                value: 619);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 104,
                column: "Force",
                value: 1088);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 105,
                column: "Force",
                value: 1739);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 106,
                column: "Force",
                value: 424);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 107,
                column: "Force",
                value: 1372);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 108,
                column: "Force",
                value: 827);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 109,
                column: "Force",
                value: 214);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 110,
                column: "Force",
                value: 784);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 111,
                column: "Force",
                value: 457);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 112,
                column: "Force",
                value: 247);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 113,
                column: "Force",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 114,
                column: "Force",
                value: 1284);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 115,
                column: "Force",
                value: 1030);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 116,
                column: "Force",
                value: 958);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 117,
                column: "Force",
                value: 45);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 118,
                column: "Force",
                value: 1325);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 119,
                column: "Force",
                value: 742);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 120,
                column: "Force",
                value: 187);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 121,
                column: "Force",
                value: 1341);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 122,
                column: "Force",
                value: 1043);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 123,
                column: "Force",
                value: 695);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 124,
                column: "Force",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 125,
                column: "Force",
                value: 313);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 126,
                column: "Force",
                value: 483);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 127,
                column: "Force",
                value: 1064);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 128,
                column: "Force",
                value: 398);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 129,
                column: "Force",
                value: 1573);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 130,
                column: "Force",
                value: 293);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 131,
                column: "Force",
                value: 1768);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 132,
                column: "Force",
                value: 715);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 133,
                column: "Force",
                value: 581);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 134,
                column: "Force",
                value: 626);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 135,
                column: "Force",
                value: 1081);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 136,
                column: "Force",
                value: 1981);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 137,
                column: "Force",
                value: 118);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 138,
                column: "Force",
                value: 1615);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 139,
                column: "Force",
                value: 1093);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 140,
                column: "Force",
                value: 1676);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 141,
                column: "Force",
                value: 494);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 142,
                column: "Force",
                value: 1982);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 143,
                column: "Force",
                value: 348);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 144,
                column: "Force",
                value: 1979);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 145,
                column: "Force",
                value: 1666);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 146,
                column: "Force",
                value: 1825);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 147,
                column: "Force",
                value: 1142);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 148,
                column: "Force",
                value: 233);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 149,
                column: "Force",
                value: 942);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 150,
                column: "Force",
                value: 1673);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 151,
                column: "Force",
                value: 1923);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 152,
                column: "Force",
                value: 1462);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 153,
                column: "Force",
                value: 1795);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 154,
                column: "Force",
                value: 434);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 155,
                column: "Force",
                value: 1537);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 156,
                column: "Force",
                value: 68);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 157,
                column: "Force",
                value: 248);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 158,
                column: "Force",
                value: 1562);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 159,
                column: "Force",
                value: 1340);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 160,
                column: "Force",
                value: 927);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 161,
                column: "Force",
                value: 355);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 162,
                column: "Force",
                value: 712);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 163,
                column: "Force",
                value: 1575);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 164,
                column: "Force",
                value: 1485);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 165,
                column: "Force",
                value: 1618);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 166,
                column: "Force",
                value: 799);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 167,
                column: "Force",
                value: 1739);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 168,
                column: "Force",
                value: 1548);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 169,
                column: "Force",
                value: 1932);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 170,
                column: "Force",
                value: 1195);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 171,
                column: "Force",
                value: 838);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 172,
                column: "Force",
                value: 1140);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 173,
                column: "Force",
                value: 1249);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 174,
                column: "Force",
                value: 1675);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 175,
                column: "Force",
                value: 325);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 176,
                column: "Force",
                value: 500);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 177,
                column: "Force",
                value: 577);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 178,
                column: "Force",
                value: 649);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 179,
                column: "Force",
                value: 518);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 180,
                column: "Force",
                value: 1576);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 181,
                column: "Force",
                value: 1919);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 182,
                column: "Force",
                value: 845);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 183,
                column: "Force",
                value: 156);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 184,
                column: "Force",
                value: 845);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 185,
                column: "Force",
                value: 1097);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 186,
                column: "Force",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 187,
                column: "Force",
                value: 136);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 188,
                column: "Force",
                value: 1289);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 189,
                column: "Force",
                value: 830);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 190,
                column: "Force",
                value: 771);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 191,
                column: "Force",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 192,
                column: "Force",
                value: 1098);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 193,
                column: "Force",
                value: 1961);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 194,
                column: "Force",
                value: 712);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 195,
                column: "Force",
                value: 174);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 196,
                column: "Force",
                value: 1622);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 197,
                column: "Force",
                value: 1481);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 198,
                column: "Force",
                value: 1826);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 199,
                column: "Force",
                value: 1024);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 200,
                column: "Force",
                value: 1621);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 201,
                column: "Force",
                value: 136);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 202,
                column: "Force",
                value: 809);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 203,
                column: "Force",
                value: 1140);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 204,
                column: "Force",
                value: 656);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 205,
                column: "Force",
                value: 779);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 206,
                column: "Force",
                value: 223);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 207,
                column: "Force",
                value: 268);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 208,
                column: "Force",
                value: 1850);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 209,
                column: "Force",
                value: 603);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 210,
                column: "Force",
                value: 138);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 211,
                column: "Force",
                value: 135);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 212,
                column: "Force",
                value: 1348);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 213,
                column: "Force",
                value: 80);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 214,
                column: "Force",
                value: 539);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 215,
                column: "Force",
                value: 1770);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 216,
                column: "Force",
                value: 1558);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 217,
                column: "Force",
                value: 1466);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 218,
                column: "Force",
                value: 1767);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 219,
                column: "Force",
                value: 173);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 220,
                column: "Force",
                value: 1365);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 221,
                column: "Force",
                value: 1520);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 222,
                column: "Force",
                value: 1864);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 223,
                column: "Force",
                value: 1572);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 224,
                column: "Force",
                value: 575);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 225,
                column: "Force",
                value: 88);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 226,
                column: "Force",
                value: 776);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 227,
                column: "Force",
                value: 1987);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 228,
                column: "Force",
                value: 1920);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 229,
                column: "Force",
                value: 928);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 230,
                column: "Force",
                value: 314);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 231,
                column: "Force",
                value: 1785);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 232,
                column: "Force",
                value: 616);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 233,
                column: "Force",
                value: 1429);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 234,
                column: "Force",
                value: 1591);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 235,
                column: "Force",
                value: 1891);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 236,
                column: "Force",
                value: 1903);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 237,
                column: "Force",
                value: 116);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 238,
                column: "Force",
                value: 811);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 239,
                column: "Force",
                value: 1265);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 240,
                column: "Force",
                value: 142);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 241,
                column: "Force",
                value: 1372);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 242,
                column: "Force",
                value: 561);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 243,
                column: "Force",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 244,
                column: "Force",
                value: 1445);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 245,
                column: "Force",
                value: 167);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 246,
                column: "Force",
                value: 1713);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 247,
                column: "Force",
                value: 1028);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 248,
                column: "Force",
                value: 884);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 249,
                column: "Force",
                value: 1432);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 250,
                column: "Force",
                value: 879);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 251,
                column: "Force",
                value: 1487);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 252,
                column: "Force",
                value: 659);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 253,
                column: "Force",
                value: 650);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 254,
                column: "Force",
                value: 1091);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 255,
                column: "Force",
                value: 1567);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 256,
                column: "Force",
                value: 1251);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 257,
                column: "Force",
                value: 1132);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 258,
                column: "Force",
                value: 458);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 259,
                column: "Force",
                value: 1949);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 260,
                column: "Force",
                value: 1585);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 261,
                column: "Force",
                value: 455);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 262,
                column: "Force",
                value: 799);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 263,
                column: "Force",
                value: 664);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 264,
                column: "Force",
                value: 1429);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 265,
                column: "Force",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 266,
                column: "Force",
                value: 630);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 267,
                column: "Force",
                value: 1293);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 268,
                column: "Force",
                value: 1269);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 269,
                column: "Force",
                value: 69);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 270,
                column: "Force",
                value: 765);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 271,
                column: "Force",
                value: 944);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 272,
                column: "Force",
                value: 1657);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 273,
                column: "Force",
                value: 596);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 274,
                column: "Force",
                value: 1735);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 275,
                column: "Force",
                value: 795);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 276,
                column: "Force",
                value: 1311);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 277,
                column: "Force",
                value: 108);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 278,
                column: "Force",
                value: 1080);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 279,
                column: "Force",
                value: 906);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 280,
                column: "Force",
                value: 565);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 281,
                column: "Force",
                value: 1698);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 282,
                column: "Force",
                value: 1048);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 283,
                column: "Force",
                value: 1794);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 284,
                column: "Force",
                value: 606);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 285,
                column: "Force",
                value: 577);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 286,
                column: "Force",
                value: 1875);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 287,
                column: "Force",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 288,
                column: "Force",
                value: 1113);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 289,
                column: "Force",
                value: 749);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 290,
                column: "Force",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 291,
                column: "Force",
                value: 455);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 292,
                column: "Force",
                value: 1372);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 293,
                column: "Force",
                value: 598);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 294,
                column: "Force",
                value: 684);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 295,
                column: "Force",
                value: 603);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 296,
                column: "Force",
                value: 619);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 297,
                column: "Force",
                value: 1522);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 298,
                column: "Force",
                value: 481);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 299,
                column: "Force",
                value: 1752);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 300,
                column: "Force",
                value: 528);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 301,
                column: "Force",
                value: 613);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 302,
                column: "Force",
                value: 1079);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 303,
                column: "Force",
                value: 66);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 304,
                column: "Force",
                value: 57);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 305,
                column: "Force",
                value: 180);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 306,
                column: "Force",
                value: 242);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 307,
                column: "Force",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 308,
                column: "Force",
                value: 980);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 309,
                column: "Force",
                value: 1517);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 310,
                column: "Force",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 311,
                column: "Force",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 312,
                column: "Force",
                value: 360);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 313,
                column: "Force",
                value: 757);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 314,
                column: "Force",
                value: 1524);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 315,
                column: "Force",
                value: 1147);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 316,
                column: "Force",
                value: 573);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 317,
                column: "Force",
                value: 1566);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 318,
                column: "Force",
                value: 1136);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 319,
                column: "Force",
                value: 235);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 320,
                column: "Force",
                value: 1211);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 321,
                column: "Force",
                value: 1240);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 322,
                column: "Force",
                value: 1727);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 323,
                column: "Force",
                value: 492);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 324,
                column: "Force",
                value: 932);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 325,
                column: "Force",
                value: 836);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 326,
                column: "Force",
                value: 188);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 327,
                column: "Force",
                value: 1465);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 328,
                column: "Force",
                value: 39);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 329,
                column: "Force",
                value: 639);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 330,
                column: "Force",
                value: 1908);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 331,
                column: "Force",
                value: 1091);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 332,
                column: "Force",
                value: 536);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 333,
                column: "Force",
                value: 639);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 334,
                column: "Force",
                value: 495);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 335,
                column: "Force",
                value: 524);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 336,
                column: "Force",
                value: 932);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 337,
                column: "Force",
                value: 1409);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 338,
                column: "Force",
                value: 95);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 339,
                column: "Force",
                value: 1877);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 340,
                column: "Force",
                value: 1246);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 341,
                column: "Force",
                value: 299);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 342,
                column: "Force",
                value: 792);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 343,
                column: "Force",
                value: 1241);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 344,
                column: "Force",
                value: 1668);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 345,
                column: "Force",
                value: 160);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 346,
                column: "Force",
                value: 583);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 347,
                column: "Force",
                value: 811);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 348,
                column: "Force",
                value: 1957);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 349,
                column: "Force",
                value: 1422);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 350,
                column: "Force",
                value: 1620);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 351,
                column: "Force",
                value: 581);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 352,
                column: "Force",
                value: 1910);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 353,
                column: "Force",
                value: 123);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 354,
                column: "Force",
                value: 1272);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 355,
                column: "Force",
                value: 1187);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 356,
                column: "Force",
                value: 1087);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 357,
                column: "Force",
                value: 243);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 358,
                column: "Force",
                value: 406);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 359,
                column: "Force",
                value: 1718);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 360,
                column: "Force",
                value: 1271);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 361,
                column: "Force",
                value: 367);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 362,
                column: "Force",
                value: 647);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 363,
                column: "Force",
                value: 944);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 364,
                column: "Force",
                value: 1393);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 365,
                column: "Force",
                value: 1346);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 366,
                column: "Force",
                value: 1458);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 367,
                column: "Force",
                value: 467);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 368,
                column: "Force",
                value: 375);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 369,
                column: "Force",
                value: 1405);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 370,
                column: "Force",
                value: 39);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 371,
                column: "Force",
                value: 1365);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 372,
                column: "Force",
                value: 1781);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 373,
                column: "Force",
                value: 1658);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 374,
                column: "Force",
                value: 219);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 375,
                column: "Force",
                value: 1121);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 376,
                column: "Force",
                value: 1338);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 377,
                column: "Force",
                value: 55);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 378,
                column: "Force",
                value: 1412);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 379,
                column: "Force",
                value: 1527);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 380,
                column: "Force",
                value: 1460);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 381,
                column: "Force",
                value: 1060);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 382,
                column: "Force",
                value: 734);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 383,
                column: "Force",
                value: 669);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 384,
                column: "Force",
                value: 226);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 385,
                column: "Force",
                value: 1387);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 386,
                column: "Force",
                value: 1396);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 387,
                column: "Force",
                value: 961);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 388,
                column: "Force",
                value: 992);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 389,
                column: "Force",
                value: 1233);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 390,
                column: "Force",
                value: 1745);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 391,
                column: "Force",
                value: 1858);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 392,
                column: "Force",
                value: 1436);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 393,
                column: "Force",
                value: 1295);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 394,
                column: "Force",
                value: 1386);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 395,
                column: "Force",
                value: 1036);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 396,
                column: "Force",
                value: 1765);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 397,
                column: "Force",
                value: 1464);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 398,
                column: "Force",
                value: 747);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 399,
                column: "Force",
                value: 952);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 400,
                column: "Force",
                value: 1734);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 401,
                column: "Force",
                value: 891);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 402,
                column: "Force",
                value: 1725);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 403,
                column: "Force",
                value: 1186);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 404,
                column: "Force",
                value: 1622);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 405,
                column: "Force",
                value: 1558);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 406,
                column: "Force",
                value: 1056);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 407,
                column: "Force",
                value: 440);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 408,
                column: "Force",
                value: 1854);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 409,
                column: "Force",
                value: 395);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 410,
                column: "Force",
                value: 1161);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 411,
                column: "Force",
                value: 1401);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 412,
                column: "Force",
                value: 567);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 413,
                column: "Force",
                value: 509);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 414,
                column: "Force",
                value: 1115);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 415,
                column: "Force",
                value: 1184);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 416,
                column: "Force",
                value: 1735);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 417,
                column: "Force",
                value: 953);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 418,
                column: "Force",
                value: 1680);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 419,
                column: "Force",
                value: 404);

            migrationBuilder.CreateIndex(
                name: "IX_ArtMartialSamourai_SamouraisId",
                table: "ArtMartialSamourai",
                column: "SamouraisId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtMartialSamourai");

            migrationBuilder.DropTable(
                name: "ArtsMartiaux");

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 100,
                column: "Force",
                value: 755);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 101,
                column: "Force",
                value: 1298);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 102,
                column: "Force",
                value: 1120);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 103,
                column: "Force",
                value: 1160);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 104,
                column: "Force",
                value: 1987);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 105,
                column: "Force",
                value: 1367);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 106,
                column: "Force",
                value: 1293);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 107,
                column: "Force",
                value: 1015);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 108,
                column: "Force",
                value: 372);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 109,
                column: "Force",
                value: 1624);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 110,
                column: "Force",
                value: 352);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 111,
                column: "Force",
                value: 156);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 112,
                column: "Force",
                value: 395);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 113,
                column: "Force",
                value: 1460);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 114,
                column: "Force",
                value: 1514);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 115,
                column: "Force",
                value: 431);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 116,
                column: "Force",
                value: 841);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 117,
                column: "Force",
                value: 1280);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 118,
                column: "Force",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 119,
                column: "Force",
                value: 755);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 120,
                column: "Force",
                value: 1431);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 121,
                column: "Force",
                value: 410);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 122,
                column: "Force",
                value: 605);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 123,
                column: "Force",
                value: 603);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 124,
                column: "Force",
                value: 1717);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 125,
                column: "Force",
                value: 1843);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 126,
                column: "Force",
                value: 115);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 127,
                column: "Force",
                value: 1784);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 128,
                column: "Force",
                value: 1620);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 129,
                column: "Force",
                value: 1465);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 130,
                column: "Force",
                value: 290);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 131,
                column: "Force",
                value: 492);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 132,
                column: "Force",
                value: 497);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 133,
                column: "Force",
                value: 1586);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 134,
                column: "Force",
                value: 1686);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 135,
                column: "Force",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 136,
                column: "Force",
                value: 1893);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 137,
                column: "Force",
                value: 694);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 138,
                column: "Force",
                value: 1648);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 139,
                column: "Force",
                value: 511);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 140,
                column: "Force",
                value: 1523);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 141,
                column: "Force",
                value: 1227);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 142,
                column: "Force",
                value: 777);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 143,
                column: "Force",
                value: 812);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 144,
                column: "Force",
                value: 1923);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 145,
                column: "Force",
                value: 1908);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 146,
                column: "Force",
                value: 1324);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 147,
                column: "Force",
                value: 1305);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 148,
                column: "Force",
                value: 408);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 149,
                column: "Force",
                value: 895);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 150,
                column: "Force",
                value: 1132);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 151,
                column: "Force",
                value: 1929);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 152,
                column: "Force",
                value: 403);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 153,
                column: "Force",
                value: 277);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 154,
                column: "Force",
                value: 1606);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 155,
                column: "Force",
                value: 1755);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 156,
                column: "Force",
                value: 861);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 157,
                column: "Force",
                value: 1110);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 158,
                column: "Force",
                value: 1118);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 159,
                column: "Force",
                value: 87);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 160,
                column: "Force",
                value: 1585);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 161,
                column: "Force",
                value: 1688);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 162,
                column: "Force",
                value: 1881);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 163,
                column: "Force",
                value: 1257);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 164,
                column: "Force",
                value: 1079);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 165,
                column: "Force",
                value: 295);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 166,
                column: "Force",
                value: 1567);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 167,
                column: "Force",
                value: 1070);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 168,
                column: "Force",
                value: 1871);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 169,
                column: "Force",
                value: 1347);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 170,
                column: "Force",
                value: 1824);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 171,
                column: "Force",
                value: 1203);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 172,
                column: "Force",
                value: 216);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 173,
                column: "Force",
                value: 224);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 174,
                column: "Force",
                value: 153);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 175,
                column: "Force",
                value: 1884);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 176,
                column: "Force",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 177,
                column: "Force",
                value: 206);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 178,
                column: "Force",
                value: 398);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 179,
                column: "Force",
                value: 1176);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 180,
                column: "Force",
                value: 514);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 181,
                column: "Force",
                value: 1296);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 182,
                column: "Force",
                value: 1785);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 183,
                column: "Force",
                value: 1881);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 184,
                column: "Force",
                value: 1953);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 185,
                column: "Force",
                value: 1605);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 186,
                column: "Force",
                value: 910);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 187,
                column: "Force",
                value: 880);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 188,
                column: "Force",
                value: 1988);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 189,
                column: "Force",
                value: 1055);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 190,
                column: "Force",
                value: 444);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 191,
                column: "Force",
                value: 1586);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 192,
                column: "Force",
                value: 271);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 193,
                column: "Force",
                value: 1137);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 194,
                column: "Force",
                value: 284);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 195,
                column: "Force",
                value: 1027);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 196,
                column: "Force",
                value: 1323);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 197,
                column: "Force",
                value: 183);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 198,
                column: "Force",
                value: 1313);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 199,
                column: "Force",
                value: 808);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 200,
                column: "Force",
                value: 1010);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 201,
                column: "Force",
                value: 1243);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 202,
                column: "Force",
                value: 494);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 203,
                column: "Force",
                value: 1493);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 204,
                column: "Force",
                value: 171);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 205,
                column: "Force",
                value: 1885);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 206,
                column: "Force",
                value: 777);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 207,
                column: "Force",
                value: 1972);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 208,
                column: "Force",
                value: 1969);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 209,
                column: "Force",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 210,
                column: "Force",
                value: 463);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 211,
                column: "Force",
                value: 1125);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 212,
                column: "Force",
                value: 1582);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 213,
                column: "Force",
                value: 1750);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 214,
                column: "Force",
                value: 805);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 215,
                column: "Force",
                value: 804);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 216,
                column: "Force",
                value: 1240);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 217,
                column: "Force",
                value: 1640);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 218,
                column: "Force",
                value: 363);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 219,
                column: "Force",
                value: 141);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 220,
                column: "Force",
                value: 1158);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 221,
                column: "Force",
                value: 568);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 222,
                column: "Force",
                value: 1548);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 223,
                column: "Force",
                value: 306);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 224,
                column: "Force",
                value: 710);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 225,
                column: "Force",
                value: 223);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 226,
                column: "Force",
                value: 1678);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 227,
                column: "Force",
                value: 1279);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 228,
                column: "Force",
                value: 532);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 229,
                column: "Force",
                value: 146);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 230,
                column: "Force",
                value: 1194);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 231,
                column: "Force",
                value: 543);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 232,
                column: "Force",
                value: 1545);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 233,
                column: "Force",
                value: 219);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 234,
                column: "Force",
                value: 510);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 235,
                column: "Force",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 236,
                column: "Force",
                value: 1326);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 237,
                column: "Force",
                value: 1076);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 238,
                column: "Force",
                value: 1478);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 239,
                column: "Force",
                value: 1202);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 240,
                column: "Force",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 241,
                column: "Force",
                value: 737);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 242,
                column: "Force",
                value: 1742);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 243,
                column: "Force",
                value: 1004);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 244,
                column: "Force",
                value: 828);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 245,
                column: "Force",
                value: 715);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 246,
                column: "Force",
                value: 1530);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 247,
                column: "Force",
                value: 133);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 248,
                column: "Force",
                value: 1470);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 249,
                column: "Force",
                value: 1180);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 250,
                column: "Force",
                value: 333);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 251,
                column: "Force",
                value: 802);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 252,
                column: "Force",
                value: 325);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 253,
                column: "Force",
                value: 342);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 254,
                column: "Force",
                value: 863);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 255,
                column: "Force",
                value: 85);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 256,
                column: "Force",
                value: 1001);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 257,
                column: "Force",
                value: 411);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 258,
                column: "Force",
                value: 628);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 259,
                column: "Force",
                value: 297);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 260,
                column: "Force",
                value: 511);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 261,
                column: "Force",
                value: 1118);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 262,
                column: "Force",
                value: 62);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 263,
                column: "Force",
                value: 220);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 264,
                column: "Force",
                value: 1577);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 265,
                column: "Force",
                value: 1280);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 266,
                column: "Force",
                value: 1605);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 267,
                column: "Force",
                value: 1776);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 268,
                column: "Force",
                value: 1543);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 269,
                column: "Force",
                value: 1514);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 270,
                column: "Force",
                value: 1293);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 271,
                column: "Force",
                value: 1695);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 272,
                column: "Force",
                value: 1432);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 273,
                column: "Force",
                value: 1895);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 274,
                column: "Force",
                value: 561);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 275,
                column: "Force",
                value: 1937);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 276,
                column: "Force",
                value: 1052);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 277,
                column: "Force",
                value: 1259);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 278,
                column: "Force",
                value: 1609);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 279,
                column: "Force",
                value: 1704);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 280,
                column: "Force",
                value: 130);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 281,
                column: "Force",
                value: 1015);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 282,
                column: "Force",
                value: 938);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 283,
                column: "Force",
                value: 1261);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 284,
                column: "Force",
                value: 1260);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 285,
                column: "Force",
                value: 421);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 286,
                column: "Force",
                value: 1393);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 287,
                column: "Force",
                value: 1517);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 288,
                column: "Force",
                value: 1662);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 289,
                column: "Force",
                value: 549);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 290,
                column: "Force",
                value: 1116);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 291,
                column: "Force",
                value: 129);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 292,
                column: "Force",
                value: 397);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 293,
                column: "Force",
                value: 330);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 294,
                column: "Force",
                value: 826);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 295,
                column: "Force",
                value: 1253);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 296,
                column: "Force",
                value: 1679);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 297,
                column: "Force",
                value: 1980);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 298,
                column: "Force",
                value: 879);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 299,
                column: "Force",
                value: 1284);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 300,
                column: "Force",
                value: 1100);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 301,
                column: "Force",
                value: 751);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 302,
                column: "Force",
                value: 962);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 303,
                column: "Force",
                value: 309);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 304,
                column: "Force",
                value: 597);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 305,
                column: "Force",
                value: 1541);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 306,
                column: "Force",
                value: 604);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 307,
                column: "Force",
                value: 828);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 308,
                column: "Force",
                value: 219);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 309,
                column: "Force",
                value: 820);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 310,
                column: "Force",
                value: 1575);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 311,
                column: "Force",
                value: 1479);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 312,
                column: "Force",
                value: 1848);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 313,
                column: "Force",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 314,
                column: "Force",
                value: 235);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 315,
                column: "Force",
                value: 1648);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 316,
                column: "Force",
                value: 1948);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 317,
                column: "Force",
                value: 120);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 318,
                column: "Force",
                value: 1829);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 319,
                column: "Force",
                value: 1771);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 320,
                column: "Force",
                value: 714);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 321,
                column: "Force",
                value: 117);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 322,
                column: "Force",
                value: 1134);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 323,
                column: "Force",
                value: 150);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 324,
                column: "Force",
                value: 787);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 325,
                column: "Force",
                value: 148);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 326,
                column: "Force",
                value: 34);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 327,
                column: "Force",
                value: 940);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 328,
                column: "Force",
                value: 1742);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 329,
                column: "Force",
                value: 1446);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 330,
                column: "Force",
                value: 150);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 331,
                column: "Force",
                value: 549);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 332,
                column: "Force",
                value: 1795);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 333,
                column: "Force",
                value: 931);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 334,
                column: "Force",
                value: 533);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 335,
                column: "Force",
                value: 566);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 336,
                column: "Force",
                value: 1830);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 337,
                column: "Force",
                value: 1715);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 338,
                column: "Force",
                value: 1690);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 339,
                column: "Force",
                value: 1965);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 340,
                column: "Force",
                value: 711);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 341,
                column: "Force",
                value: 754);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 342,
                column: "Force",
                value: 242);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 343,
                column: "Force",
                value: 167);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 344,
                column: "Force",
                value: 1837);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 345,
                column: "Force",
                value: 1017);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 346,
                column: "Force",
                value: 649);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 347,
                column: "Force",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 348,
                column: "Force",
                value: 824);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 349,
                column: "Force",
                value: 805);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 350,
                column: "Force",
                value: 1307);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 351,
                column: "Force",
                value: 943);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 352,
                column: "Force",
                value: 1231);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 353,
                column: "Force",
                value: 1024);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 354,
                column: "Force",
                value: 1450);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 355,
                column: "Force",
                value: 1590);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 356,
                column: "Force",
                value: 1220);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 357,
                column: "Force",
                value: 1573);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 358,
                column: "Force",
                value: 571);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 359,
                column: "Force",
                value: 527);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 360,
                column: "Force",
                value: 481);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 361,
                column: "Force",
                value: 646);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 362,
                column: "Force",
                value: 1869);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 363,
                column: "Force",
                value: 1095);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 364,
                column: "Force",
                value: 855);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 365,
                column: "Force",
                value: 55);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 366,
                column: "Force",
                value: 1574);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 367,
                column: "Force",
                value: 1030);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 368,
                column: "Force",
                value: 702);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 369,
                column: "Force",
                value: 238);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 370,
                column: "Force",
                value: 1976);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 371,
                column: "Force",
                value: 1966);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 372,
                column: "Force",
                value: 1937);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 373,
                column: "Force",
                value: 397);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 374,
                column: "Force",
                value: 583);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 375,
                column: "Force",
                value: 184);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 376,
                column: "Force",
                value: 1234);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 377,
                column: "Force",
                value: 1303);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 378,
                column: "Force",
                value: 1375);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 379,
                column: "Force",
                value: 1305);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 380,
                column: "Force",
                value: 320);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 381,
                column: "Force",
                value: 61);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 382,
                column: "Force",
                value: 1883);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 383,
                column: "Force",
                value: 206);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 384,
                column: "Force",
                value: 970);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 385,
                column: "Force",
                value: 520);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 386,
                column: "Force",
                value: 1737);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 387,
                column: "Force",
                value: 1185);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 388,
                column: "Force",
                value: 1855);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 389,
                column: "Force",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 390,
                column: "Force",
                value: 1059);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 391,
                column: "Force",
                value: 1748);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 392,
                column: "Force",
                value: 832);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 393,
                column: "Force",
                value: 991);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 394,
                column: "Force",
                value: 419);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 395,
                column: "Force",
                value: 153);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 396,
                column: "Force",
                value: 1399);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 397,
                column: "Force",
                value: 192);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 398,
                column: "Force",
                value: 1539);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 399,
                column: "Force",
                value: 516);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 400,
                column: "Force",
                value: 1057);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 401,
                column: "Force",
                value: 1054);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 402,
                column: "Force",
                value: 1587);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 403,
                column: "Force",
                value: 624);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 404,
                column: "Force",
                value: 351);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 405,
                column: "Force",
                value: 1343);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 406,
                column: "Force",
                value: 453);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 407,
                column: "Force",
                value: 937);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 408,
                column: "Force",
                value: 979);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 409,
                column: "Force",
                value: 902);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 410,
                column: "Force",
                value: 656);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 411,
                column: "Force",
                value: 1723);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 412,
                column: "Force",
                value: 1354);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 413,
                column: "Force",
                value: 1967);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 414,
                column: "Force",
                value: 143);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 415,
                column: "Force",
                value: 1576);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 416,
                column: "Force",
                value: 1741);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 417,
                column: "Force",
                value: 699);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 418,
                column: "Force",
                value: 407);

            migrationBuilder.UpdateData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 419,
                column: "Force",
                value: 1069);
        }
    }
}
