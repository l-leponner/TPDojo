using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TPDojo.Migrations
{
    /// <inheritdoc />
    public partial class SamouraiDataInsert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Samourais",
                columns: new[] { "Id", "ArmeId", "Force", "Nom" },
                values: new object[,]
                {
                    { 100, null, 755, "Abe Masakatsu" },
                    { 101, null, 1298, "Adachi Yasumori" },
                    { 102, null, 1120, "Adachi Kagemori" },
                    { 103, null, 1160, "Adams William" },
                    { 104, null, 1987, "Aiou Mototsuna" },
                    { 105, null, 1367, "Akai Terukage" },
                    { 106, null, 1293, "Akao Kiyotsuna" },
                    { 107, null, 1015, "Akechi Mitsuhide" },
                    { 108, null, 372, "Akiyama Nobutomo" },
                    { 109, null, 1624, "Amago Haruhisa" },
                    { 110, null, 352, "Amago Yoshihisa" },
                    { 111, null, 156, "Andō Morinari" },
                    { 112, null, 395, "Ankokuji Ekei" },
                    { 113, null, 1460, "Aochi Shigetsuna" },
                    { 114, null, 1514, "Aokage Takaakira" },
                    { 115, null, 431, "Aoki Kazushige" },
                    { 116, null, 841, "Akahori Chohichi" },
                    { 117, null, 1280, "Arai Hakuseki" },
                    { 118, null, 5, "Araki Motokiyo" },
                    { 119, null, 755, "Araki Murashige" },
                    { 120, null, 1431, "Araki Muratsugu" },
                    { 121, null, 410, "Arima Kihei" },
                    { 122, null, 605, "Asakura Yoshikage" },
                    { 123, null, 603, "Ayame Kagekatsu" },
                    { 124, null, 1717, "Azai Hisamasa" },
                    { 125, null, 1843, "Azai Nagamasa" },
                    { 126, null, 115, "Azai Sukemasa" },
                    { 127, null, 1784, "Baba Nobufusa" },
                    { 128, null, 1620, "Bessho Nagaharu" },
                    { 129, null, 1465, "Chacha" },
                    { 130, null, 290, "Chiba Shusaku Narimasa" },
                    { 131, null, 492, "Chōsokabe Morichika" },
                    { 132, null, 497, "Chōsokabe Kunichika" },
                    { 133, null, 1586, "Chōsokabe Motochika" },
                    { 134, null, 1686, "Chōsokabe Nobuchika" },
                    { 135, null, 20, "Collache Eugène" },
                    { 136, null, 1893, "Date Masamune" },
                    { 137, null, 694, "Date Shigezane" },
                    { 138, null, 1648, "Doi Toshikatsu" },
                    { 139, null, 511, "Etō Shinpei" },
                    { 140, null, 1523, "Endō Naotsune" },
                    { 141, null, 1227, "Enjoji Nobutane" },
                    { 142, null, 777, "Enomoto Takeaki" },
                    { 143, null, 812, "Era Fusahide" },
                    { 144, null, 1923, "Fūma Kotarō" },
                    { 145, null, 1908, "Fuwa Mitsuharu" },
                    { 146, null, 1324, "Fukushima Masanori" },
                    { 147, null, 1305, "Gamō Katahide" },
                    { 148, null, 408, "Gamō Ujisato" },
                    { 149, null, 895, "Harada Naomasa" },
                    { 150, null, 1132, "Harada Nobutane" },
                    { 151, null, 1929, "Harada Sanosuke" },
                    { 152, null, 403, "Hasekura Tsunenaga" },
                    { 153, null, 277, "Hattori Hanzō" },
                    { 154, null, 1606, "Hatano Hideharu" },
                    { 155, null, 1755, "Hasegawa Eishin" },
                    { 156, null, 861, "Hayashizaki Jinsuke Shigenobu" },
                    { 157, null, 1110, "Hayashi Narinaga" },
                    { 158, null, 1118, "Hijikata Toshizo" },
                    { 159, null, 87, "Hirate Masahide" },
                    { 160, null, 1585, "Hitotsubashi Keiki" },
                    { 161, null, 1688, "Hōjō Masako" },
                    { 162, null, 1881, "Hōjō Tokimune" },
                    { 163, null, 1257, "Hōjō Ujiyasu" },
                    { 164, null, 1079, "Hōjō Ujimasa" },
                    { 165, null, 295, "Honda Tadakatsu" },
                    { 166, null, 1567, "Honda Tadatomo" },
                    { 167, null, 1070, "Honganji Kennyo" },
                    { 168, null, 1871, "Horio Yoshiharu" },
                    { 169, null, 1347, "Hosokawa Fujitaka" },
                    { 170, null, 1824, "Hosokawa Gracia" },
                    { 171, null, 1203, "Hosokawa Tadaoki" },
                    { 172, null, 216, "Hotta Masatoshi" },
                    { 173, null, 224, "Ii Naoaki" },
                    { 174, null, 153, "Ii Naomasa" },
                    { 175, null, 1884, "Ii Naomori" },
                    { 176, null, 3, "Ii Naonaka" },
                    { 177, null, 206, "Ii Naosuke" },
                    { 178, null, 398, "Ii Naotaka" },
                    { 179, null, 1176, "Ii Naotora" },
                    { 180, null, 514, "Ii Naoyuki" },
                    { 181, null, 1296, "Ii Naozumi" },
                    { 182, null, 1785, "Iizasa Ienao" },
                    { 183, null, 1881, "Ijuin Tadaaki" },
                    { 184, null, 1953, "Ikeda Tsuneoki" },
                    { 185, null, 1605, "Imagawa Ujizane" },
                    { 186, null, 910, "Imagawa Yoshimoto" },
                    { 187, null, 880, "Imai Kanehira" },
                    { 188, null, 1988, "Inaba Yoshimichi" },
                    { 189, null, 1055, "Inugami Nagayasu" },
                    { 190, null, 444, "Ishida Mitsunari" },
                    { 191, null, 1586, "Isshiki Fujinaga" },
                    { 192, null, 271, "Itagaki Nobukata" },
                    { 193, null, 1137, "Itō Hirobumi" },
                    { 194, null, 284, "Iwanari Tomomichi" },
                    { 195, null, 1027, "Jinbo Nagamoto" },
                    { 196, null, 1323, "Jonas Tönse" },
                    { 197, null, 183, "Kannan Kumar(Salem)" },
                    { 198, null, 1313, "Kakeda Toshimune" },
                    { 199, null, 808, "Kaneko Ietada" },
                    { 200, null, 1010, "Katagiri Katsumoto" },
                    { 201, null, 1243, "Katakura Kojūro" },
                    { 202, null, 494, "Katakura Shigenaga" },
                    { 203, null, 1493, "Kataoka Mitsumasa" },
                    { 204, null, 171, "Katō Kiyomasa" },
                    { 205, null, 1885, "Kawakami Gensai" },
                    { 206, null, 777, "Kido Takayoshi" },
                    { 207, null, 1972, "Kikkawa Hiroie" },
                    { 208, null, 1969, "Kimotsuki Kanetsugu" },
                    { 209, null, 19, "Kitamura Kansuke" },
                    { 210, null, 463, "Kobayakawa Hideaki" },
                    { 211, null, 1125, "Kobayakawa Hidekane" },
                    { 212, null, 1582, "Kobayakawa Takakage" },
                    { 213, null, 1750, "Konishi Yukinaga" },
                    { 214, null, 805, "Kojima Toyoharu" },
                    { 215, null, 804, "Kuroda Kanbei" },
                    { 216, null, 1240, "Kuroda Kiyotaka" },
                    { 217, null, 1640, "Kusunoki Masashige" },
                    { 218, null, 363, "Kuwana Tarozaemon" },
                    { 219, null, 141, "Kumagai Naozane" },
                    { 220, null, 1158, "Maeda Keiji" },
                    { 221, null, 568, "Maeda Matsu" },
                    { 222, null, 1548, "Maeda Nagatane" },
                    { 223, null, 306, "Maeda Toshiie" },
                    { 224, null, 710, "Maeda Toshinaga" },
                    { 225, null, 223, "Maeda Toshitsune" },
                    { 226, null, 1678, "Magome Kageyu" },
                    { 227, null, 1279, "Manabe Akifusa" },
                    { 228, null, 532, "Matsudaira Katamori" },
                    { 229, null, 146, "Matsudaira Nobutsuna" },
                    { 230, null, 1194, "Matsudaira Nobuyasu" },
                    { 231, null, 543, "Matsudaira Higo no Kami Katamori" },
                    { 232, null, 1545, "Matsudaira Sadanobu" },
                    { 233, null, 219, "Matsudaira Tadayoshi" },
                    { 234, null, 510, "Matsudaira Teru" },
                    { 235, null, 20, "Matsunaga Hisahide" },
                    { 236, null, 1326, "Matsunaga Hisamichi" },
                    { 237, null, 1076, "Matsuo Bashō" },
                    { 238, null, 1478, "Matsudaira Motoyasu" },
                    { 239, null, 1202, "Minamoto no Mitsunaka" },
                    { 240, null, 27, "Minamoto no Yoshiie" },
                    { 241, null, 737, "Minamoto no Yoshimitsu" },
                    { 242, null, 1742, "Minamoto no Yoshinaka" },
                    { 243, null, 1004, "Minamoto no Yoshitomo" },
                    { 244, null, 828, "Minamoto no Yoshitsune" },
                    { 245, null, 715, "Minamoto no Tameyoshi" },
                    { 246, null, 1530, "Minamoto no Yorimasa" },
                    { 247, null, 133, "Minamoto no Yorimitsu" },
                    { 248, null, 1470, "Minamoto no Yoritomo" },
                    { 249, null, 1180, "Minamoto no Noriyori" },
                    { 250, null, 333, "Minoro Takashi" },
                    { 251, null, 802, "Miura Anjin" },
                    { 252, null, 325, "Miura Yoshimoto" },
                    { 253, null, 342, "Miyamoto Musashi" },
                    { 254, null, 863, "Miyoshi Chōkei" },
                    { 255, null, 85, "Miyoshi Kazuhide" },
                    { 256, null, 1001, "Miyoshi Masaga" },
                    { 257, null, 411, "Miyoshi Masayasu" },
                    { 258, null, 628, "Miyoshi Moriyata" },
                    { 259, null, 297, "Miyoshi Nagayuki" },
                    { 260, null, 511, "Miyoshi Yoshitsugu" },
                    { 261, null, 1118, "Mizuno Tadakuni" },
                    { 262, null, 62, "Moniwa Yoshinao" },
                    { 263, null, 220, "Mōri Motonari" },
                    { 264, null, 1577, "Mōri Nagasada" },
                    { 265, null, 1280, "Mori Nagayoshi" },
                    { 266, null, 1605, "Mōri Okimoto" },
                    { 267, null, 1776, "Mori Ranmaru" },
                    { 268, null, 1543, "Mōri Takamoto" },
                    { 269, null, 1514, "Mori Tadamasa" },
                    { 270, null, 1293, "Mōri Terumoto" },
                    { 271, null, 1695, "Mori Yoshinari" },
                    { 272, null, 1432, "Murai Sadakatsu" },
                    { 273, null, 1895, "Nagakura Shinpachi" },
                    { 274, null, 561, "Nagao Harukage" },
                    { 275, null, 1937, "Nagao Kagenobu" },
                    { 276, null, 1052, "Nagao Masakage" },
                    { 277, null, 1259, "Nagao Tamekage" },
                    { 278, null, 1609, "Nakagawa Kiyohide" },
                    { 279, null, 1704, "Nakaoka Shintarō" },
                    { 280, null, 130, "Naoe Kagetsuna" },
                    { 281, null, 1015, "Naoe Kanetsugu" },
                    { 282, null, 938, "Narita Kaihime" },
                    { 283, null, 1261, "Nene" },
                    { 284, null, 1260, "Nihonmatsu Yoshitsugu" },
                    { 285, null, 421, "Niimi Nishiki" },
                    { 286, null, 1393, "Niiro Tadamoto" },
                    { 287, null, 1517, "Niwa Nagahide" },
                    { 288, null, 1662, "Niwa Nagashige" },
                    { 289, null, 549, "Oda Hiroyoshi" },
                    { 290, null, 1116, "Oda Nobuhide" },
                    { 291, null, 129, "Oda Nobukata" },
                    { 292, null, 397, "Oda Nobukiyo" },
                    { 293, null, 330, "Oda Nobunaga" },
                    { 294, null, 826, "Oda Nobutada" },
                    { 295, null, 1253, "Oda Nobutomo" },
                    { 296, null, 1679, "Oda Nobukatsu" },
                    { 297, null, 1980, "Oda Nobuyasu" },
                    { 298, null, 879, "Ogasawara Shōsai" },
                    { 299, null, 1284, "Ōishi Kuranosuke" },
                    { 300, null, 1100, "Okada Izō" },
                    { 301, null, 751, "Judge Ooka" },
                    { 302, null, 962, "Ōta Dōkan" },
                    { 303, null, 309, "Ōtani Yoshitsugu" },
                    { 304, null, 597, "Ōtani Yoshiharu" },
                    { 305, null, 1541, "Ōtomo Sōrin" },
                    { 306, null, 604, "Okita Sōji" },
                    { 307, null, 828, "Ōkubo Toshimichi" },
                    { 308, null, 219, "Okunomiya Masaie" },
                    { 309, null, 820, "Ōuchi Yoshitaka" },
                    { 310, null, 1575, "Omy Yoshika" },
                    { 311, null, 1479, "Pore Sufi" },
                    { 312, null, 1848, "Reizei Takatoyo" },
                    { 313, null, 40, "Rokkaku Sadayori" },
                    { 314, null, 235, "Rokkaku Yoshiharu" },
                    { 315, null, 1648, "Rokkaku Yoshikata" },
                    { 316, null, 1948, "Rusu Masakage" },
                    { 317, null, 120, "Ryūzōji Takanobu" },
                    { 318, null, 1829, "Saigo Kiyokazu" },
                    { 319, null, 1771, "Saigō Masako" },
                    { 320, null, 714, "Sagara Taketō" },
                    { 321, null, 117, "Saigō Takamori" },
                    { 322, null, 1134, "Saigo Yoshikatsu" },
                    { 323, null, 150, "Saitō Dōsan" },
                    { 324, null, 787, "Saitō Hajime" },
                    { 325, null, 148, "Saito Musashibō Benkei" },
                    { 326, null, 34, "Saitō Yoshitatsu" },
                    { 327, null, 940, "Sakai Tadakiyo" },
                    { 328, null, 1742, "Sakai Tadashige" },
                    { 329, null, 1446, "Sakai Tadatsugu" },
                    { 330, null, 150, "Sakai Tadayo" },
                    { 331, null, 549, "Sakakibara Yasumasa" },
                    { 332, null, 1795, "Sakamoto Ryōma" },
                    { 333, null, 931, "Sakuma Morimasa" },
                    { 334, null, 533, "Sakuma Nobumori" },
                    { 335, null, 566, "Sanada Akihime" },
                    { 336, null, 1830, "Sanada Komatsuhime" },
                    { 337, null, 1715, "Sanada Masayuki" },
                    { 338, null, 1690, "Sanada Nobuyuki" },
                    { 339, null, 1965, "Sanada Yukimura" },
                    { 340, null, 711, "Sasaki Kojirō" },
                    { 341, null, 754, "Sassa Narimasa" },
                    { 342, null, 242, "Sasuke Sarutobi" },
                    { 343, null, 167, "Serizawa Kamo" },
                    { 344, null, 1837, "Shibata Katsuie" },
                    { 345, null, 1017, "Shima Sakon" },
                    { 346, null, 649, "Shimada Ichirō" },
                    { 347, null, 30, "Shimazu Katsuhisa" },
                    { 348, null, 824, "Shimazu Tadahisa" },
                    { 349, null, 805, "Shimazu Tadatsune" },
                    { 350, null, 1307, "Shimazu Tadayoshi" },
                    { 351, null, 943, "Shimazu Takahisa" },
                    { 352, null, 1231, "Shimazu Toyohisa" },
                    { 353, null, 1024, "Shimazu Yoshihiro" },
                    { 354, null, 1450, "Shimazu Yoshihisa" },
                    { 355, null, 1590, "Shindou Hiroshii" },
                    { 356, null, 1220, "Sogo Nagayasu" },
                    { 357, null, 1573, "Sue Yoshitaka" },
                    { 358, null, 571, "Tachibana Muneshige" },
                    { 359, null, 527, "Tachibana Dōsetsu" },
                    { 360, null, 481, "Tachibana Ginchiyo" },
                    { 361, null, 646, "Taigen Sessai" },
                    { 362, null, 1869, "Taira no Kiyomori" },
                    { 363, null, 1095, "Taira Masakado" },
                    { 364, null, 855, "Takahashi Shigetane" },
                    { 365, null, 55, "Takenaka Shigeharu" },
                    { 366, null, 1574, "Takasugi Shinsaku" },
                    { 367, null, 1030, "Takayama Justo" },
                    { 368, null, 702, "Takayama Ukon" },
                    { 369, null, 238, "Takechi Hanpeita" },
                    { 370, null, 1976, "Takeda Katsuyori" },
                    { 371, null, 1966, "Takeda Nobukatsu" },
                    { 372, null, 1937, "Takeda Nobushige" },
                    { 373, null, 397, "Takeda Shingen" },
                    { 374, null, 583, "Takenaka Hanbei" },
                    { 375, null, 184, "Tani Tadasumi" },
                    { 376, null, 1234, "Tōdō Takatora" },
                    { 377, null, 1303, "Toki Yorinari" },
                    { 378, null, 1375, "Tochimitsu Gantyoki" },
                    { 379, null, 1305, "Tokugawa Ieyasu" },
                    { 380, null, 320, "Tokugawa Hidetada" },
                    { 381, null, 61, "Tokugawa Nariaki" },
                    { 382, null, 1883, "Tokugawa Yoshinobu" },
                    { 383, null, 206, "Torii Mototada" },
                    { 384, null, 970, "Toyotomi Hidenaga" },
                    { 385, null, 520, "Toyotomi Hideyoshi" },
                    { 386, null, 1737, "Toyotomi Hideyori" },
                    { 387, null, 1185, "Tozuka Tadaharu" },
                    { 388, null, 1855, "Tsukahara Bokuden" },
                    { 389, null, 28, "Uesugi Kagekatsu" },
                    { 390, null, 1059, "Uesugi Kagetora" },
                    { 391, null, 1748, "Uesugi Kenshin" },
                    { 392, null, 832, "Ujiie Naotomo" },
                    { 393, null, 991, "Ukita Naoie" },
                    { 394, null, 419, "Ukita Okiie" },
                    { 395, null, 153, "Umezawa Michiharu" },
                    { 396, null, 1399, "Usami Sadamitsu" },
                    { 397, null, 192, "Uyama Hisanobu" },
                    { 398, null, 1539, "Wada Shinsuke" },
                    { 399, null, 516, "Watanabe Kazan" },
                    { 400, null, 1057, "Watanabe no Tsuna" },
                    { 401, null, 1054, "Yasumero Kenshin" },
                    { 402, null, 1587, "Yagyū Jūbei Mitsuyoshi" },
                    { 403, null, 624, "Yagyū Munenori" },
                    { 404, null, 351, "Yamauchi Kazutoyo" },
                    { 405, null, 1343, "Yamada Arinaga" },
                    { 406, null, 453, "Yamada Arinobu" },
                    { 407, null, 937, "Yamada Nagamasa" },
                    { 408, null, 979, "Yamagata Masakage" },
                    { 409, null, 902, "Yamakawa Hiroshi" },
                    { 410, null, 656, "Yamakawa Kenjirō" },
                    { 411, null, 1723, "Yamakawa Naoe" },
                    { 412, null, 1354, "Yamanaka Yukimori" },
                    { 413, null, 1967, "Yamanami Keisuke" },
                    { 414, null, 143, "Yamaoka Tesshū" },
                    { 415, null, 1576, "Yanagawa Kenzaburo" },
                    { 416, null, 1741, "Yanagisawa Yoshiyasu" },
                    { 417, null, 699, "Yonekura Shigetsugu" },
                    { 418, null, 407, "Yūki Hideyasu" },
                    { 419, null, 1069, "Yasuke" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Samourais",
                keyColumn: "Id",
                keyValue: 419);
        }
    }
}
