using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Migrations
{
    [ExcludeFromCodeCoverage]
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Price = table.Column<decimal>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CustomerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 1, "kayley@mitchellkoss.com", "Dr. Hollis Lowe" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 73, "conor_ruecker@corkery.com", "Rozella Smith" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 72, "maybelle_schamberger@bauch.com", "Roberto Cummerata" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 71, "ilene.wisozk@conn.co.uk", "Jakob Lang" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 70, "rhianna@flatleyoconnell.ca", "Mariela Yundt" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 69, "brennan_bruen@conroyraynor.com", "Chadrick Wiza" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 68, "lane@hudson.biz", "Mr. Felicita Dickinson" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 67, "karl_schiller@morissette.uk", "Nigel Reilly" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 66, "johanna.abshire@stokes.ca", "Timothy Yost" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 65, "braden_bauch@kessler.uk", "Ryan Dach" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 64, "lucious@carter.biz", "Bart Williamson" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 63, "raven@rowekris.co.uk", "Trever Emmerich" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 62, "marshall.schimmel@brakus.co.uk", "Dr. Lora Treutel" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 61, "reuben@lebsack.ca", "Aletha Bradtke" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 60, "mose.wyman@boehm.biz", "Uriel Collins" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 59, "mariano@olson.biz", "Zechariah Heathcote" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 58, "dane@colemonahan.name", "Edythe Towne" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 57, "else.toy@schmidt.com", "Marjolaine Mosciski DDS" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 56, "nikolas@willflatley.info", "Ms. Raoul Wuckert" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 55, "willa@fritschturcotte.uk", "Wilfrid Bins" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 54, "suzanne@schroederwisoky.info", "Miss Fern Koch" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 53, "janie_kuhic@treutel.co.uk", "Annetta Doyle" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 74, "eloise@runolfsdottir.co.uk", "Brannon Ondricka" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 52, "dejah_fahey@mohr.us", "Ava Harber" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 75, "roslyn.prohaska@mcglynnlangosh.ca", "Dariana Maggio PhD" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 77, "lila.schumm@smitham.co.uk", "Valentina Batz" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 98, "oleta@wittingklocko.com", "Lincoln Stamm" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 97, "addison@douglas.uk", "Nyah Becker" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 96, "jovani@schmeler.us", "Zelma Torp III" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 95, "charley.hudson@rosenbaumquitzon.info", "Art Bernier" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 94, "vance.mertz@sporermuller.us", "Janie Durgan" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 93, "markus@weissnatprosacco.ca", "Grayson Spinka Jr." });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 92, "terrence_monahan@faygerhold.name", "Miss Judge Jast" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 91, "emily_blick@lueilwitzmayert.co.uk", "Yesenia Ankunding" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 90, "else@hilll.co.uk", "Dr. Brooks McDermott" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 89, "pearline.renner@davis.us", "Dr. Clotilde Weber" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 88, "murl@stiedemann.biz", "Jillian Pagac" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 87, "ramona@lueilwitz.name", "Samanta Osinski" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 86, "marion@reilly.uk", "Randi Hammes" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 85, "kody@watsica.name", "Loma Davis" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 84, "laurine_hilll@mosciski.co.uk", "Miss Alessia Lindgren" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 83, "toy@torpchristiansen.us", "Romaine Reynolds" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 82, "constantin.marvin@harber.name", "Mossie Gerlach PhD" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 81, "estell@hoegerhickle.biz", "Christian Gaylord" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 80, "ottis_labadie@nicolas.biz", "Michale Towne Jr." });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 79, "maybelle@abbottzboncak.name", "Rita Stark" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 78, "georgianna_nienow@powlowskibode.biz", "Lily Goldner" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 76, "jeanne_eichmann@schoenkassulke.us", "Randall Bashirian" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 51, "vince.kassulke@hessel.us", "Antoinette Parker" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 50, "cayla_wilderman@weber.biz", "Brandyn Huel DVM" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 49, "barney.hand@johnston.com", "Rylee Balistreri I" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 22, "hilton@larson.ca", "Coty Miller" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 21, "rudy.graham@yundt.biz", "Juwan Bogan" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 20, "kay@mills.ca", "Bradford Sanford" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 19, "jonathon@schamberger.co.uk", "Mr. Fatima Crona" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 18, "emerson_considine@wuckert.co.uk", "Name Kautzer" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 17, "betsy_beer@johns.biz", "Lemuel McClure" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 16, "kyler.lindgren@mitchellschoen.biz", "Sabrina Raynor I" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 15, "alexandre@abshire.name", "Miss Courtney Renner" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 14, "robb_rolfson@mraz.co.uk", "Dereck Daniel" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 13, "chelsea@effertzcormier.info", "Hellen Wilderman" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 12, "ramiro@rutherford.uk", "Genevieve Pfeffer" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 11, "edmund_rodriguez@mcclure.info", "Luz Little" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 10, "janiya@runolfsson.us", "Halle Hermiston" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 9, "dedrick.stamm@jacobsonweimann.ca", "Dallin Gusikowski IV" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 8, "kevin_frami@aufderhar.com", "Marcos Bins" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 7, "agnes@gleason.info", "Monte Hackett" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 6, "emely.shanahan@rogahn.ca", "Hayley Herzog" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 5, "otho@littlereichel.uk", "Mrs. Carroll Satterfield" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 4, "geovanny.klocko@pfeffer.biz", "Ted Gleichner" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 3, "lonnie@beer.biz", "Rodger Roberts" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 2, "oren@mayert.biz", "Sydnee Moore" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 23, "elmira@simonis.info", "Dr. Gertrude Lebsack" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 24, "kelley.roob@adams.ca", "Mathias Pfannerstill" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 25, "julien@greenfelderbecker.info", "Alejandra Lubowitz" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 26, "easton_predovic@stehr.com", "Mercedes Cole" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 48, "gerhard.balistreri@pfannerstill.ca", "Hailie Schuster" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 47, "keenan_donnelly@greenholtcorkery.co.uk", "Leonardo Auer" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 46, "jeanette_klein@marvin.ca", "Susanna Baumbach PhD" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 45, "lane_corkery@larkin.co.uk", "Ms. Hermina Glover" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 44, "candido_torphy@durgan.ca", "Amie Fay" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 43, "abe.jerde@lehnerbotsford.ca", "Gonzalo Mueller" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 42, "norene@kuhn.co.uk", "Rebeka Schmeler" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 41, "kip_dickens@franecki.co.uk", "Gladys Beer MD" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 40, "assunta_rosenbaum@bernhardkuhn.com", "Ms. Walton Mertz" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 39, "isaac.keebler@krajcik.co.uk", "Ms. Kurt Prohaska" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 99, "deborah@bashirian.name", "Tyrique Trantow" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 38, "dahlia@botsfordankunding.com", "Baylee Kuphal" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 36, "winston_douglas@hagenes.uk", "Keely Altenwerth" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 35, "zachary@ricebernhard.co.uk", "Ferne Schaefer" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 34, "chelsie@cartwrightkassulke.uk", "Jamal Quitzon" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 33, "ana.hammes@rempel.uk", "Isac Schmitt" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 32, "antonetta@muellerschimmel.biz", "Dr. Salvatore Wilderman" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 31, "madelyn@mclaughlin.name", "Abdullah Miller" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 30, "winona@schneider.us", "Marvin Kilback" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 29, "pinkie@reicherthuel.info", "Ora Doyle" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 28, "deja@skiles.info", "Mrs. Shayne Walter" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 27, "adah@walkerwalsh.uk", "Zoey Nitzsche" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 37, "laverna@jacobiflatley.name", "Autumn Gislason" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 100, "wilford_gutmann@wolfemmerich.uk", "Miss Alycia Morissette" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 22, new DateTime(2019, 4, 26, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 1, 12370.2200m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 89, new DateTime(2019, 6, 29, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 57, 17506.2697m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 131, new DateTime(2019, 3, 25, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 57, 46423.3863m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 122, new DateTime(2019, 4, 26, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 58, 44230.3123m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 52, new DateTime(2019, 5, 3, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 60, 86055.2181m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 98, new DateTime(2019, 3, 30, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 60, 36460.324m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 141, new DateTime(2018, 11, 3, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 61, 38826.1323m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 160, new DateTime(2019, 6, 1, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 61, 58894.2563m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 106, new DateTime(2019, 2, 22, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 62, 54448.2084m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 111, new DateTime(2019, 5, 25, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 62, 65244.1074m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 147, new DateTime(2019, 6, 29, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 62, 69114.1622m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 151, new DateTime(2018, 10, 24, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 63, 21281.2502m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 175, new DateTime(2018, 11, 15, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 65, 5161.1284m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 181, new DateTime(2019, 4, 13, 17, 49, 48, 730, DateTimeKind.Local).AddTicks(7850), 65, 30829.2668m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 23, new DateTime(2019, 3, 13, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 66, 17605.1206m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 53, new DateTime(2019, 6, 25, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 66, 51575.1299m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 108, new DateTime(2018, 12, 25, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 66, 11788.2279m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 120, new DateTime(2019, 1, 1, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 66, 14790.3674m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 179, new DateTime(2019, 2, 26, 17, 49, 48, 730, DateTimeKind.Local).AddTicks(7850), 68, 1567.3974m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 143, new DateTime(2018, 12, 22, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 69, 49828.974m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 18, new DateTime(2019, 2, 19, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 70, 86134.19m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 58, new DateTime(2019, 3, 6, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 70, 30292.2688m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 144, new DateTime(2019, 5, 28, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 54, 85551.3468m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 136, new DateTime(2019, 4, 27, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 70, 88362.467m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 32, new DateTime(2019, 2, 19, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 54, 91909.1176m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 182, new DateTime(2019, 4, 8, 17, 49, 48, 730, DateTimeKind.Local).AddTicks(7850), 53, 9088.2792m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 74, new DateTime(2019, 3, 19, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 46, 56289.3763m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 153, new DateTime(2019, 2, 21, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 46, 91115.2936m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 177, new DateTime(2019, 1, 21, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 46, 76610.1021m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 66, new DateTime(2019, 4, 5, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 47, 52306.888m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 121, new DateTime(2018, 10, 14, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 47, 77807.414m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 36, new DateTime(2019, 5, 15, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 48, 73736.448m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 45, new DateTime(2018, 12, 17, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 48, 51526.3660m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 145, new DateTime(2019, 4, 22, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 48, 86161.1967m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 189, new DateTime(2019, 5, 15, 17, 49, 48, 730, DateTimeKind.Local).AddTicks(7850), 48, 86843.3580m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 134, new DateTime(2018, 12, 31, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 49, 66510.1886m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 41, new DateTime(2019, 4, 5, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 50, 37016.3684m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 84, new DateTime(2018, 11, 13, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 50, 14765.3869m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 178, new DateTime(2019, 1, 6, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 50, 79249.1659m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 11, new DateTime(2018, 11, 11, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 52, 16332.702m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 25, new DateTime(2018, 12, 30, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 52, 44108.1012m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 87, new DateTime(2019, 3, 9, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 52, 78640.1143m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 95, new DateTime(2018, 11, 15, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 52, 33772.3536m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 148, new DateTime(2019, 2, 1, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 52, 45443.3248m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 186, new DateTime(2018, 10, 10, 17, 49, 48, 730, DateTimeKind.Local).AddTicks(7850), 52, 80732.2435m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 73, new DateTime(2018, 9, 22, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 53, 2055.73m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 139, new DateTime(2019, 4, 11, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 53, 82638.3394m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 9, new DateTime(2019, 4, 4, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 54, 59666.1761m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 3, new DateTime(2019, 5, 31, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 46, 91378.864m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 142, new DateTime(2018, 12, 1, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 70, 35809.506m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 35, new DateTime(2019, 5, 8, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 71, 84112.3582m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 42, new DateTime(2019, 1, 25, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 89, 21307.3296m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 57, new DateTime(2018, 11, 6, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 89, 69407.3293m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 68, new DateTime(2018, 11, 6, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 89, 60369.2378m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 129, new DateTime(2019, 1, 20, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 89, 96606.1541m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 43, new DateTime(2019, 1, 1, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 91, 66650.2048m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 116, new DateTime(2018, 11, 4, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 92, 67226.1372m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 30, new DateTime(2019, 7, 1, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 93, 72015.2692m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 37, new DateTime(2018, 10, 19, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 94, 2519.2906m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 199, new DateTime(2019, 1, 5, 17, 49, 48, 730, DateTimeKind.Local).AddTicks(7850), 94, 70258.925m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 80, new DateTime(2018, 12, 18, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 95, 56209.141m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 100, new DateTime(2019, 3, 27, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 95, 81843.1392m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 27, new DateTime(2019, 4, 26, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 96, 4850.1471m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 114, new DateTime(2018, 12, 3, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 96, 83923.2053m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 170, new DateTime(2019, 6, 16, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 96, 21534.3056m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 200, new DateTime(2019, 3, 25, 17, 49, 48, 730, DateTimeKind.Local).AddTicks(7850), 96, 803.1646m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 124, new DateTime(2018, 12, 6, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 97, 9719.2033m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 174, new DateTime(2018, 10, 7, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 97, 91149.2802m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 88, new DateTime(2019, 6, 6, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 98, 43049.3328m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 96, new DateTime(2019, 3, 19, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 98, 39908.504m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 107, new DateTime(2019, 4, 29, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 98, 2892.2388m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 192, new DateTime(2018, 12, 7, 17, 49, 48, 730, DateTimeKind.Local).AddTicks(7850), 98, 12621.2599m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 176, new DateTime(2019, 5, 26, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 86, 20425.960m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 187, new DateTime(2018, 11, 21, 17, 49, 48, 730, DateTimeKind.Local).AddTicks(7850), 70, 65313.3299m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 92, new DateTime(2019, 2, 25, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 86, 84393.1502m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 195, new DateTime(2019, 4, 4, 17, 49, 48, 730, DateTimeKind.Local).AddTicks(7850), 84, 6516.3214m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 101, new DateTime(2019, 1, 24, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 71, 87083.2382m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 125, new DateTime(2019, 3, 10, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 71, 15521.3179m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 126, new DateTime(2019, 3, 30, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 72, 85110.1714m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 70, new DateTime(2018, 11, 22, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 73, 30846.1366m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 39, new DateTime(2019, 2, 15, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 74, 5182.795m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 50, new DateTime(2019, 4, 10, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 75, 45266.1952m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 194, new DateTime(2019, 5, 23, 17, 49, 48, 730, DateTimeKind.Local).AddTicks(7850), 75, 70521.2788m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 5, new DateTime(2018, 11, 14, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 77, 39767.3967m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 12, new DateTime(2018, 12, 17, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 77, 74901.1563m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 91, new DateTime(2019, 3, 27, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 77, 91747.1628m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 69, new DateTime(2019, 5, 22, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 79, 6059.2670m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 90, new DateTime(2019, 3, 4, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 79, 90553.3859m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 146, new DateTime(2018, 12, 8, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 80, 35578.1203m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 152, new DateTime(2019, 3, 2, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 80, 504.1436m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 163, new DateTime(2019, 6, 18, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 80, 44023.2331m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 184, new DateTime(2019, 1, 8, 17, 49, 48, 730, DateTimeKind.Local).AddTicks(7850), 80, 16481.2126m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 61, new DateTime(2019, 5, 5, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 81, 9905.2293m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 103, new DateTime(2018, 12, 17, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 82, 22774.1213m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 172, new DateTime(2018, 11, 22, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 82, 92956.2858m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 46, new DateTime(2018, 9, 29, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 84, 91225.1027m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 190, new DateTime(2018, 11, 12, 17, 49, 48, 730, DateTimeKind.Local).AddTicks(7850), 84, 29520.807m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 86, new DateTime(2019, 6, 14, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 85, 61158.3778m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 168, new DateTime(2018, 11, 26, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 45, 21835.3050m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 99, new DateTime(2019, 2, 25, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 45, 15988.3327m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 67, new DateTime(2019, 3, 19, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 45, 74609.2907m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 60, new DateTime(2019, 4, 11, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 11, 62748.2342m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 113, new DateTime(2019, 3, 11, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 11, 30911.1941m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 191, new DateTime(2019, 4, 1, 17, 49, 48, 730, DateTimeKind.Local).AddTicks(7850), 11, 67127.2901m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 29, new DateTime(2019, 6, 6, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 12, 9253.3635m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 33, new DateTime(2019, 4, 12, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 12, 9756.2751m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 198, new DateTime(2019, 1, 19, 17, 49, 48, 730, DateTimeKind.Local).AddTicks(7850), 12, 45585.2925m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 128, new DateTime(2018, 11, 15, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 14, 69572.2408m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 154, new DateTime(2018, 11, 12, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 14, 84506.248m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 158, new DateTime(2018, 9, 29, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 14, 35400.533m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 40, new DateTime(2019, 7, 2, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 15, 21491.3586m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 78, new DateTime(2019, 5, 15, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 15, 38906.2878m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 93, new DateTime(2019, 4, 18, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 15, 22215.1029m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 183, new DateTime(2018, 9, 25, 17, 49, 48, 730, DateTimeKind.Local).AddTicks(7850), 15, 70667.1217m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 193, new DateTime(2019, 3, 2, 17, 49, 48, 730, DateTimeKind.Local).AddTicks(7850), 15, 3504.800m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 6, new DateTime(2019, 2, 15, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 16, 32532.3246m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 118, new DateTime(2018, 12, 29, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 16, 9401.1287m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 28, new DateTime(2018, 10, 12, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 17, 49358.3785m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 133, new DateTime(2018, 12, 5, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 17, 88462.805m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 109, new DateTime(2019, 3, 3, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 18, 22997.2925m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 119, new DateTime(2018, 10, 24, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 18, 68617.451m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 112, new DateTime(2019, 1, 5, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 19, 62954.1342m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 4, new DateTime(2019, 6, 16, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 11, 47959.3985m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 24, new DateTime(2018, 12, 12, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 20, 87051.2806m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 162, new DateTime(2019, 3, 1, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 10, 60994.45m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 85, new DateTime(2019, 3, 11, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 9, 21979.2832m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 72, new DateTime(2019, 5, 28, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 1, 39833.3621m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 82, new DateTime(2019, 3, 19, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 1, 10700.2265m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 140, new DateTime(2018, 10, 5, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 1, 99598.1724m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 51, new DateTime(2019, 1, 7, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 2, 29296.3101m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 137, new DateTime(2018, 12, 18, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 2, 58344.1702m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 132, new DateTime(2019, 4, 26, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 3, 99498.348m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 156, new DateTime(2019, 4, 12, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 3, 77573.469m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 7, new DateTime(2018, 10, 29, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 4, 10392.2809m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 44, new DateTime(2019, 5, 12, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 4, 58888.1740m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 55, new DateTime(2019, 3, 27, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 5, 3681.2439m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 150, new DateTime(2018, 9, 29, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 5, 89618.553m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 173, new DateTime(2019, 4, 2, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 5, 71612.953m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 2, new DateTime(2019, 5, 1, 17, 49, 48, 726, DateTimeKind.Local).AddTicks(7848), 6, 29996.3673m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 157, new DateTime(2018, 10, 13, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 7, 38933.3962m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 161, new DateTime(2019, 1, 13, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 7, 34580.3192m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 20, new DateTime(2019, 6, 22, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 8, 41518.419m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 34, new DateTime(2019, 3, 12, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 8, 856.380m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 13, new DateTime(2019, 4, 30, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 9, 19820.962m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 71, new DateTime(2018, 11, 11, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 9, 15501.1067m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 79, new DateTime(2019, 7, 9, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 9, 19563.3737m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 83, new DateTime(2019, 3, 6, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 9, 8687.2689m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 159, new DateTime(2019, 4, 20, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 10, 60785.3473m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 75, new DateTime(2018, 12, 5, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 20, 43915.3357m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 19, new DateTime(2019, 3, 7, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 21, 16597.1937m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 38, new DateTime(2018, 12, 8, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 21, 33096.3534m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 64, new DateTime(2019, 4, 17, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 35, 34794.1132m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 105, new DateTime(2019, 2, 15, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 35, 43664.2227m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 49, new DateTime(2019, 2, 19, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 36, 36057.3318m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 56, new DateTime(2018, 11, 22, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 36, 89447.3575m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 63, new DateTime(2019, 2, 24, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 36, 98335.1921m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 167, new DateTime(2018, 10, 18, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 36, 95251.3430m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 26, new DateTime(2019, 2, 15, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 37, 43715.1528m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 166, new DateTime(2018, 10, 16, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 37, 44020.1885m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 10, new DateTime(2019, 6, 19, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 38, 83135.67m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 185, new DateTime(2019, 2, 22, 17, 49, 48, 730, DateTimeKind.Local).AddTicks(7850), 38, 77228.2365m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 196, new DateTime(2019, 3, 17, 17, 49, 48, 730, DateTimeKind.Local).AddTicks(7850), 38, 74696.1328m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 17, new DateTime(2018, 10, 23, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 39, 80294.35m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 65, new DateTime(2018, 12, 2, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 39, 21498.1881m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 188, new DateTime(2018, 10, 11, 17, 49, 48, 730, DateTimeKind.Local).AddTicks(7850), 39, 24221.2209m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 77, new DateTime(2019, 1, 11, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 40, 20220.3468m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 135, new DateTime(2019, 6, 7, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 40, 50321.3184m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 127, new DateTime(2018, 10, 27, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 41, 48763.3955m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 169, new DateTime(2019, 1, 8, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 42, 32592.3995m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 81, new DateTime(2018, 9, 30, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 43, 97696.295m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 110, new DateTime(2018, 10, 20, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 44, 34426.3318m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 8, new DateTime(2019, 1, 18, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 45, 90041.3613m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 171, new DateTime(2019, 5, 30, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 34, 39866.3173m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 54, new DateTime(2019, 5, 20, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 33, 35702.1287m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 1, new DateTime(2019, 6, 30, 17, 49, 48, 725, DateTimeKind.Local).AddTicks(7847), 33, 12184.3366m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 62, new DateTime(2018, 10, 4, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 32, 57980.3704m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 130, new DateTime(2019, 3, 31, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 21, 42183.2969m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 76, new DateTime(2019, 2, 23, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 22, 24822.1062m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 104, new DateTime(2018, 12, 16, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 22, 47927.3665m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 149, new DateTime(2018, 11, 7, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 22, 10861.1420m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 14, new DateTime(2019, 3, 17, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 23, 62284.2616m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 48, new DateTime(2018, 10, 26, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 23, 51151.3442m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 117, new DateTime(2019, 2, 10, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 23, 85602.2229m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 138, new DateTime(2018, 12, 7, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 23, 5141.2195m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 123, new DateTime(2018, 11, 20, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 24, 33964.3511m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 180, new DateTime(2018, 12, 19, 17, 49, 48, 730, DateTimeKind.Local).AddTicks(7850), 24, 91893.1313m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 94, new DateTime(2019, 5, 20, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 99, 1991.3515m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 47, new DateTime(2019, 2, 3, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 25, 76426.2968m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 31, new DateTime(2019, 4, 4, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 26, 59333.3301m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 102, new DateTime(2018, 12, 16, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 26, 72097.2923m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 197, new DateTime(2018, 12, 27, 17, 49, 48, 730, DateTimeKind.Local).AddTicks(7850), 28, 7997.3547m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 15, new DateTime(2018, 9, 23, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 29, 7735.414m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 97, new DateTime(2019, 6, 13, 17, 49, 48, 728, DateTimeKind.Local).AddTicks(7849), 29, 10550.1092m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 21, new DateTime(2019, 7, 2, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 30, 68601.1118m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 155, new DateTime(2019, 2, 28, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 30, 93751.587m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 165, new DateTime(2019, 2, 7, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 30, 97114.957m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 59, new DateTime(2019, 3, 4, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 31, 61235.379m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 115, new DateTime(2019, 3, 30, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 31, 92129.1397m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 16, new DateTime(2018, 12, 12, 17, 49, 48, 727, DateTimeKind.Local).AddTicks(7848), 26, 89425.2549m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 164, new DateTime(2019, 6, 15, 17, 49, 48, 729, DateTimeKind.Local).AddTicks(7849), 99, 42582.711m });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
