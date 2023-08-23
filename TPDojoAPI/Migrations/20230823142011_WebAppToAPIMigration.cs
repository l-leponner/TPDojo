using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TPDojoAPI.Migrations
{
    /// <inheritdoc />
    public partial class WebAppToAPIMigration : Migration
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
                    Degats = table.Column<int>(type: "int", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArtsMartiaux",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtsMartiaux", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Samourais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Force = table.Column<int>(type: "int", nullable: false),
                    ArmeId = table.Column<int>(type: "int", nullable: true),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.InsertData(
                table: "Samourais",
                columns: new[] { "Id", "ArmeId", "Force", "Nom" },
                values: new object[,]
                {
                    { 100, null, 500, "Abe Masakatsu" },
                    { 101, null, 1043, "Adachi Yasumori" },
                    { 102, null, 1627, "Adachi Kagemori" },
                    { 103, null, 1963, "Adams William" },
                    { 104, null, 1490, "Aiou Mototsuna" },
                    { 105, null, 396, "Akai Terukage" },
                    { 106, null, 519, "Akao Kiyotsuna" },
                    { 107, null, 1340, "Akechi Mitsuhide" },
                    { 108, null, 252, "Akiyama Nobutomo" },
                    { 109, null, 1656, "Amago Haruhisa" },
                    { 110, null, 185, "Amago Yoshihisa" },
                    { 111, null, 1133, "Andō Morinari" },
                    { 112, null, 190, "Ankokuji Ekei" },
                    { 113, null, 142, "Aochi Shigetsuna" },
                    { 114, null, 1596, "Aokage Takaakira" },
                    { 115, null, 12, "Aoki Kazushige" },
                    { 116, null, 851, "Akahori Chohichi" },
                    { 117, null, 1327, "Arai Hakuseki" },
                    { 118, null, 1352, "Araki Motokiyo" },
                    { 119, null, 87, "Araki Murashige" },
                    { 120, null, 1671, "Araki Muratsugu" },
                    { 121, null, 1279, "Arima Kihei" },
                    { 122, null, 51, "Asakura Yoshikage" },
                    { 123, null, 923, "Ayame Kagekatsu" },
                    { 124, null, 1311, "Azai Hisamasa" },
                    { 125, null, 223, "Azai Nagamasa" },
                    { 126, null, 320, "Azai Sukemasa" },
                    { 127, null, 1455, "Baba Nobufusa" },
                    { 128, null, 1801, "Bessho Nagaharu" },
                    { 129, null, 1649, "Chacha" },
                    { 130, null, 1224, "Chiba Shusaku Narimasa" },
                    { 131, null, 1183, "Chōsokabe Morichika" },
                    { 132, null, 714, "Chōsokabe Kunichika" },
                    { 133, null, 976, "Chōsokabe Motochika" },
                    { 134, null, 542, "Chōsokabe Nobuchika" },
                    { 135, null, 1725, "Collache Eugène" },
                    { 136, null, 1335, "Date Masamune" },
                    { 137, null, 200, "Date Shigezane" },
                    { 138, null, 1166, "Doi Toshikatsu" },
                    { 139, null, 1603, "Etō Shinpei" },
                    { 140, null, 1847, "Endō Naotsune" },
                    { 141, null, 1429, "Enjoji Nobutane" },
                    { 142, null, 832, "Enomoto Takeaki" },
                    { 143, null, 1753, "Era Fusahide" },
                    { 144, null, 1388, "Fūma Kotarō" },
                    { 145, null, 512, "Fuwa Mitsuharu" },
                    { 146, null, 1805, "Fukushima Masanori" },
                    { 147, null, 544, "Gamō Katahide" },
                    { 148, null, 314, "Gamō Ujisato" },
                    { 149, null, 820, "Harada Naomasa" },
                    { 150, null, 283, "Harada Nobutane" },
                    { 151, null, 156, "Harada Sanosuke" },
                    { 152, null, 563, "Hasekura Tsunenaga" },
                    { 153, null, 175, "Hattori Hanzō" },
                    { 154, null, 1294, "Hatano Hideharu" },
                    { 155, null, 594, "Hasegawa Eishin" },
                    { 156, null, 524, "Hayashizaki Jinsuke Shigenobu" },
                    { 157, null, 23, "Hayashi Narinaga" },
                    { 158, null, 28, "Hijikata Toshizo" },
                    { 159, null, 1577, "Hirate Masahide" },
                    { 160, null, 990, "Hitotsubashi Keiki" },
                    { 161, null, 718, "Hōjō Masako" },
                    { 162, null, 1289, "Hōjō Tokimune" },
                    { 163, null, 392, "Hōjō Ujiyasu" },
                    { 164, null, 1427, "Hōjō Ujimasa" },
                    { 165, null, 1449, "Honda Tadakatsu" },
                    { 166, null, 1994, "Honda Tadatomo" },
                    { 167, null, 783, "Honganji Kennyo" },
                    { 168, null, 776, "Horio Yoshiharu" },
                    { 169, null, 23, "Hosokawa Fujitaka" },
                    { 170, null, 340, "Hosokawa Gracia" },
                    { 171, null, 1835, "Hosokawa Tadaoki" },
                    { 172, null, 106, "Hotta Masatoshi" },
                    { 173, null, 746, "Ii Naoaki" },
                    { 174, null, 559, "Ii Naomasa" },
                    { 175, null, 1970, "Ii Naomori" },
                    { 176, null, 1531, "Ii Naonaka" },
                    { 177, null, 1350, "Ii Naosuke" },
                    { 178, null, 781, "Ii Naotaka" },
                    { 179, null, 835, "Ii Naotora" },
                    { 180, null, 393, "Ii Naoyuki" },
                    { 181, null, 818, "Ii Naozumi" },
                    { 182, null, 1866, "Iizasa Ienao" },
                    { 183, null, 1137, "Ijuin Tadaaki" },
                    { 184, null, 352, "Ikeda Tsuneoki" },
                    { 185, null, 1347, "Imagawa Ujizane" },
                    { 186, null, 23, "Imagawa Yoshimoto" },
                    { 187, null, 21, "Imai Kanehira" },
                    { 188, null, 1416, "Inaba Yoshimichi" },
                    { 189, null, 888, "Inugami Nagayasu" },
                    { 190, null, 972, "Ishida Mitsunari" },
                    { 191, null, 123, "Isshiki Fujinaga" },
                    { 192, null, 1850, "Itagaki Nobukata" },
                    { 193, null, 672, "Itō Hirobumi" },
                    { 194, null, 974, "Iwanari Tomomichi" },
                    { 195, null, 646, "Jinbo Nagamoto" },
                    { 196, null, 149, "Jonas Tönse" },
                    { 197, null, 739, "Kannan Kumar(Salem)" },
                    { 198, null, 1165, "Kakeda Toshimune" },
                    { 199, null, 1280, "Kaneko Ietada" },
                    { 200, null, 416, "Katagiri Katsumoto" },
                    { 201, null, 987, "Katakura Kojūro" },
                    { 202, null, 889, "Katakura Shigenaga" },
                    { 203, null, 683, "Kataoka Mitsumasa" },
                    { 204, null, 494, "Katō Kiyomasa" },
                    { 205, null, 3, "Kawakami Gensai" },
                    { 206, null, 1995, "Kido Takayoshi" },
                    { 207, null, 893, "Kikkawa Hiroie" },
                    { 208, null, 1484, "Kimotsuki Kanetsugu" },
                    { 209, null, 1389, "Kitamura Kansuke" },
                    { 210, null, 348, "Kobayakawa Hideaki" },
                    { 211, null, 754, "Kobayakawa Hidekane" },
                    { 212, null, 1913, "Kobayakawa Takakage" },
                    { 213, null, 80, "Konishi Yukinaga" },
                    { 214, null, 106, "Kojima Toyoharu" },
                    { 215, null, 1688, "Kuroda Kanbei" },
                    { 216, null, 1798, "Kuroda Kiyotaka" },
                    { 217, null, 82, "Kusunoki Masashige" },
                    { 218, null, 48, "Kuwana Tarozaemon" },
                    { 219, null, 1261, "Kumagai Naozane" },
                    { 220, null, 305, "Maeda Keiji" },
                    { 221, null, 380, "Maeda Matsu" },
                    { 222, null, 1281, "Maeda Nagatane" },
                    { 223, null, 623, "Maeda Toshiie" },
                    { 224, null, 579, "Maeda Toshinaga" },
                    { 225, null, 1075, "Maeda Toshitsune" },
                    { 226, null, 1524, "Magome Kageyu" },
                    { 227, null, 82, "Manabe Akifusa" },
                    { 228, null, 97, "Matsudaira Katamori" },
                    { 229, null, 405, "Matsudaira Nobutsuna" },
                    { 230, null, 1221, "Matsudaira Nobuyasu" },
                    { 231, null, 991, "Matsudaira Higo no Kami Katamori" },
                    { 232, null, 408, "Matsudaira Sadanobu" },
                    { 233, null, 956, "Matsudaira Tadayoshi" },
                    { 234, null, 1037, "Matsudaira Teru" },
                    { 235, null, 1298, "Matsunaga Hisahide" },
                    { 236, null, 1449, "Matsunaga Hisamichi" },
                    { 237, null, 1189, "Matsuo Bashō" },
                    { 238, null, 1057, "Matsudaira Motoyasu" },
                    { 239, null, 1284, "Minamoto no Mitsunaka" },
                    { 240, null, 392, "Minamoto no Yoshiie" },
                    { 241, null, 131, "Minamoto no Yoshimitsu" },
                    { 242, null, 689, "Minamoto no Yoshinaka" },
                    { 243, null, 1920, "Minamoto no Yoshitomo" },
                    { 244, null, 339, "Minamoto no Yoshitsune" },
                    { 245, null, 1619, "Minamoto no Tameyoshi" },
                    { 246, null, 61, "Minamoto no Yorimasa" },
                    { 247, null, 1172, "Minamoto no Yorimitsu" },
                    { 248, null, 985, "Minamoto no Yoritomo" },
                    { 249, null, 1823, "Minamoto no Noriyori" },
                    { 250, null, 1996, "Minoro Takashi" },
                    { 251, null, 1041, "Miura Anjin" },
                    { 252, null, 1848, "Miura Yoshimoto" },
                    { 253, null, 1806, "Miyamoto Musashi" },
                    { 254, null, 352, "Miyoshi Chōkei" },
                    { 255, null, 1137, "Miyoshi Kazuhide" },
                    { 256, null, 373, "Miyoshi Masaga" },
                    { 257, null, 1122, "Miyoshi Masayasu" },
                    { 258, null, 1837, "Miyoshi Moriyata" },
                    { 259, null, 775, "Miyoshi Nagayuki" },
                    { 260, null, 1382, "Miyoshi Yoshitsugu" },
                    { 261, null, 1983, "Mizuno Tadakuni" },
                    { 262, null, 137, "Moniwa Yoshinao" },
                    { 263, null, 282, "Mōri Motonari" },
                    { 264, null, 662, "Mōri Nagasada" },
                    { 265, null, 1635, "Mori Nagayoshi" },
                    { 266, null, 378, "Mōri Okimoto" },
                    { 267, null, 682, "Mori Ranmaru" },
                    { 268, null, 941, "Mōri Takamoto" },
                    { 269, null, 430, "Mori Tadamasa" },
                    { 270, null, 1861, "Mōri Terumoto" },
                    { 271, null, 1669, "Mori Yoshinari" },
                    { 272, null, 1234, "Murai Sadakatsu" },
                    { 273, null, 1981, "Nagakura Shinpachi" },
                    { 274, null, 40, "Nagao Harukage" },
                    { 275, null, 1025, "Nagao Kagenobu" },
                    { 276, null, 1022, "Nagao Masakage" },
                    { 277, null, 1903, "Nagao Tamekage" },
                    { 278, null, 463, "Nakagawa Kiyohide" },
                    { 279, null, 1115, "Nakaoka Shintarō" },
                    { 280, null, 1621, "Naoe Kagetsuna" },
                    { 281, null, 1237, "Naoe Kanetsugu" },
                    { 282, null, 226, "Narita Kaihime" },
                    { 283, null, 993, "Nene" },
                    { 284, null, 1295, "Nihonmatsu Yoshitsugu" },
                    { 285, null, 640, "Niimi Nishiki" },
                    { 286, null, 562, "Niiro Tadamoto" },
                    { 287, null, 1597, "Niwa Nagahide" },
                    { 288, null, 234, "Niwa Nagashige" },
                    { 289, null, 1256, "Oda Hiroyoshi" },
                    { 290, null, 878, "Oda Nobuhide" },
                    { 291, null, 607, "Oda Nobukata" },
                    { 292, null, 1858, "Oda Nobukiyo" },
                    { 293, null, 28, "Oda Nobunaga" },
                    { 294, null, 1440, "Oda Nobutada" },
                    { 295, null, 1390, "Oda Nobutomo" },
                    { 296, null, 1690, "Oda Nobukatsu" },
                    { 297, null, 1267, "Oda Nobuyasu" },
                    { 298, null, 1727, "Ogasawara Shōsai" },
                    { 299, null, 60, "Ōishi Kuranosuke" },
                    { 300, null, 442, "Okada Izō" },
                    { 301, null, 1886, "Judge Ooka" },
                    { 302, null, 1432, "Ōta Dōkan" },
                    { 303, null, 104, "Ōtani Yoshitsugu" },
                    { 304, null, 347, "Ōtani Yoshiharu" },
                    { 305, null, 1666, "Ōtomo Sōrin" },
                    { 306, null, 216, "Okita Sōji" },
                    { 307, null, 1020, "Ōkubo Toshimichi" },
                    { 308, null, 937, "Okunomiya Masaie" },
                    { 309, null, 0, "Ōuchi Yoshitaka" },
                    { 310, null, 1580, "Omy Yoshika" },
                    { 311, null, 790, "Pore Sufi" },
                    { 312, null, 159, "Reizei Takatoyo" },
                    { 313, null, 405, "Rokkaku Sadayori" },
                    { 314, null, 1250, "Rokkaku Yoshiharu" },
                    { 315, null, 820, "Rokkaku Yoshikata" },
                    { 316, null, 1806, "Rusu Masakage" },
                    { 317, null, 1345, "Ryūzōji Takanobu" },
                    { 318, null, 1091, "Saigo Kiyokazu" },
                    { 319, null, 665, "Saigō Masako" },
                    { 320, null, 1149, "Sagara Taketō" },
                    { 321, null, 1073, "Saigō Takamori" },
                    { 322, null, 538, "Saigo Yoshikatsu" },
                    { 323, null, 550, "Saitō Dōsan" },
                    { 324, null, 1406, "Saitō Hajime" },
                    { 325, null, 1421, "Saito Musashibō Benkei" },
                    { 326, null, 1859, "Saitō Yoshitatsu" },
                    { 327, null, 414, "Sakai Tadakiyo" },
                    { 328, null, 1418, "Sakai Tadashige" },
                    { 329, null, 1034, "Sakai Tadatsugu" },
                    { 330, null, 1889, "Sakai Tadayo" },
                    { 331, null, 17, "Sakakibara Yasumasa" },
                    { 332, null, 1460, "Sakamoto Ryōma" },
                    { 333, null, 118, "Sakuma Morimasa" },
                    { 334, null, 1871, "Sakuma Nobumori" },
                    { 335, null, 1578, "Sanada Akihime" },
                    { 336, null, 438, "Sanada Komatsuhime" },
                    { 337, null, 866, "Sanada Masayuki" },
                    { 338, null, 1696, "Sanada Nobuyuki" },
                    { 339, null, 927, "Sanada Yukimura" },
                    { 340, null, 1695, "Sasaki Kojirō" },
                    { 341, null, 1885, "Sassa Narimasa" },
                    { 342, null, 458, "Sasuke Sarutobi" },
                    { 343, null, 1200, "Serizawa Kamo" },
                    { 344, null, 1453, "Shibata Katsuie" },
                    { 345, null, 371, "Shima Sakon" },
                    { 346, null, 593, "Shimada Ichirō" },
                    { 347, null, 244, "Shimazu Katsuhisa" },
                    { 348, null, 504, "Shimazu Tadahisa" },
                    { 349, null, 567, "Shimazu Tadatsune" },
                    { 350, null, 48, "Shimazu Tadayoshi" },
                    { 351, null, 253, "Shimazu Takahisa" },
                    { 352, null, 353, "Shimazu Toyohisa" },
                    { 353, null, 1246, "Shimazu Yoshihiro" },
                    { 354, null, 1871, "Shimazu Yoshihisa" },
                    { 355, null, 1148, "Shindou Hiroshii" },
                    { 356, null, 512, "Sogo Nagayasu" },
                    { 357, null, 1009, "Sue Yoshitaka" },
                    { 358, null, 163, "Tachibana Muneshige" },
                    { 359, null, 538, "Tachibana Dōsetsu" },
                    { 360, null, 1876, "Tachibana Ginchiyo" },
                    { 361, null, 1433, "Taigen Sessai" },
                    { 362, null, 1123, "Taira no Kiyomori" },
                    { 363, null, 1367, "Taira Masakado" },
                    { 364, null, 216, "Takahashi Shigetane" },
                    { 365, null, 649, "Takenaka Shigeharu" },
                    { 366, null, 1301, "Takasugi Shinsaku" },
                    { 367, null, 1887, "Takayama Justo" },
                    { 368, null, 402, "Takayama Ukon" },
                    { 369, null, 1567, "Takechi Hanpeita" },
                    { 370, null, 957, "Takeda Katsuyori" },
                    { 371, null, 1600, "Takeda Nobukatsu" },
                    { 372, null, 869, "Takeda Nobushige" },
                    { 373, null, 1733, "Takeda Shingen" },
                    { 374, null, 226, "Takenaka Hanbei" },
                    { 375, null, 696, "Tani Tadasumi" },
                    { 376, null, 745, "Tōdō Takatora" },
                    { 377, null, 1891, "Toki Yorinari" },
                    { 378, null, 866, "Tochimitsu Gantyoki" },
                    { 379, null, 1225, "Tokugawa Ieyasu" },
                    { 380, null, 1394, "Tokugawa Hidetada" },
                    { 381, null, 1518, "Tokugawa Nariaki" },
                    { 382, null, 418, "Tokugawa Yoshinobu" },
                    { 383, null, 887, "Torii Mototada" },
                    { 384, null, 179, "Toyotomi Hidenaga" },
                    { 385, null, 1600, "Toyotomi Hideyoshi" },
                    { 386, null, 1276, "Toyotomi Hideyori" },
                    { 387, null, 121, "Tozuka Tadaharu" },
                    { 388, null, 573, "Tsukahara Bokuden" },
                    { 389, null, 336, "Uesugi Kagekatsu" },
                    { 390, null, 57, "Uesugi Kagetora" },
                    { 391, null, 1261, "Uesugi Kenshin" },
                    { 392, null, 634, "Ujiie Naotomo" },
                    { 393, null, 1361, "Ukita Naoie" },
                    { 394, null, 17, "Ukita Okiie" },
                    { 395, null, 974, "Umezawa Michiharu" },
                    { 396, null, 292, "Usami Sadamitsu" },
                    { 397, null, 762, "Uyama Hisanobu" },
                    { 398, null, 37, "Wada Shinsuke" },
                    { 399, null, 639, "Watanabe Kazan" },
                    { 400, null, 839, "Watanabe no Tsuna" },
                    { 401, null, 1989, "Yasumero Kenshin" },
                    { 402, null, 1541, "Yagyū Jūbei Mitsuyoshi" },
                    { 403, null, 95, "Yagyū Munenori" },
                    { 404, null, 170, "Yamauchi Kazutoyo" },
                    { 405, null, 1832, "Yamada Arinaga" },
                    { 406, null, 685, "Yamada Arinobu" },
                    { 407, null, 1703, "Yamada Nagamasa" },
                    { 408, null, 1214, "Yamagata Masakage" },
                    { 409, null, 989, "Yamakawa Hiroshi" },
                    { 410, null, 333, "Yamakawa Kenjirō" },
                    { 411, null, 405, "Yamakawa Naoe" },
                    { 412, null, 1913, "Yamanaka Yukimori" },
                    { 413, null, 1610, "Yamanami Keisuke" },
                    { 414, null, 636, "Yamaoka Tesshū" },
                    { 415, null, 1295, "Yanagawa Kenzaburo" },
                    { 416, null, 293, "Yanagisawa Yoshiyasu" },
                    { 417, null, 988, "Yonekura Shigetsugu" },
                    { 418, null, 727, "Yūki Hideyasu" },
                    { 419, null, 1433, "Yasuke" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtMartialSamourai_SamouraisId",
                table: "ArtMartialSamourai",
                column: "SamouraisId");

            migrationBuilder.CreateIndex(
                name: "IX_Samourais_ArmeId",
                table: "Samourais",
                column: "ArmeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtMartialSamourai");

            migrationBuilder.DropTable(
                name: "ArtsMartiaux");

            migrationBuilder.DropTable(
                name: "Samourais");

            migrationBuilder.DropTable(
                name: "Armes");
        }
    }
}
