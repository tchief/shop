using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Migrations
{
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
                    Email = table.Column<string>(nullable: false)
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
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 1, "giovanna.moen@upton.info", "Candido Koepp" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 73, "americo@friesen.name", "Mrs. Elnora Auer" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 72, "jazmin_goodwin@lindgrengislason.ca", "Kattie Boyle" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 71, "catherine.kovacek@parker.us", "Katlynn Rowe" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 70, "austin@walsh.ca", "Kyler Kirlin" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 69, "lue@breitenbergschinner.co.uk", "Mrs. Aisha White" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 68, "torrey.rosenbaum@lubowitz.co.uk", "Gilbert Weber" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 67, "edmund@upton.name", "Lilian Lesch Sr." });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 66, "wilford.bartell@croninschneider.ca", "Gay Lueilwitz" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 65, "dashawn.effertz@langluettgen.biz", "Nakia Bins" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 64, "morris@runolfssonwilkinson.name", "Kip Von" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 63, "sven@moorerippin.info", "Kristopher Ferry" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 62, "lucas.vandervort@funk.ca", "Sarah Doyle" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 61, "merlin@runolfsson.us", "Lera Tromp" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 60, "lennie@murray.ca", "Corene Corwin" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 59, "joel@abshirechamplin.us", "Celine McGlynn" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 58, "jewell@prosaccojast.co.uk", "Ezekiel Larkin" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 57, "lauryn@mclaughlin.biz", "Dr. Kailyn Denesik" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 56, "gaetano@lynch.ca", "Mayra Stracke" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 55, "kennith.hand@pourosshields.name", "Robbie Kozey IV" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 54, "missouri@runte.biz", "Dr. Brett Stroman" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 53, "violet.gleichner@johnston.uk", "Justina Heller" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 74, "gail@von.info", "Jessyca Kuhlman" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 52, "bernice@okeefe.name", "Blake Conroy" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 75, "sean@haneveum.ca", "Jayme Schuster DDS" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 77, "ashlynn.huels@johnsonstanton.info", "Eudora Boyer" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 98, "elliott@grimes.uk", "Lourdes Schuster PhD" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 97, "timothy@quigleygreenfelder.uk", "Elvie Hirthe II" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 96, "zelda.zemlak@cormier.com", "Jayce Mueller" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 95, "syble.shields@murazikklein.name", "Layne Beer Sr." });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 94, "rafaela@yundtrunte.us", "Ms. Duncan Stehr" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 93, "frieda@goodwin.uk", "Wendy Osinski" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 92, "myah.powlowski@schimmel.com", "Madisen Conn" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 91, "dorothy@wolf.com", "Quinn Doyle" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 90, "ada@volkman.uk", "Emma Rau" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 89, "hipolito_parker@green.com", "Claud Tremblay" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 88, "laila.ritchie@ratke.info", "Madisen Medhurst" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 87, "verdie.stracke@macejkovic.info", "Jordi Kuhn" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 86, "raul_eichmann@koepp.info", "Wilburn Osinski" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 85, "vida@satterfield.com", "Robbie Ebert" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 84, "sonny@roobjenkins.co.uk", "Kenny Luettgen I" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 83, "jaydon@hudson.com", "Verner Muller" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 82, "jacynthe@reichel.biz", "Ms. Wilber Brown" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 81, "roger.west@flatley.biz", "Delmer Macejkovic I" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 80, "mina@schaden.uk", "Eveline Terry Sr." });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 79, "whitney@parisian.us", "Raul Carter" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 78, "colten@daugherty.biz", "Robbie Raynor" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 76, "mathilde.parker@heaneykeeling.us", "Mrs. Aditya Langosh" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 51, "ricardo@armstrong.us", "Crystel Christiansen II" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 50, "melyna_keeling@heidenreich.biz", "Muhammad Bins" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 49, "ethan@wehnerokeefe.name", "Arthur Leffler" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 22, "delilah.bartell@wisozk.uk", "Miss Dixie Johnson" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 21, "einar_wintheiser@jerde.name", "Jason Jenkins" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 20, "waldo@hegmanncorwin.co.uk", "Benedict Hoeger" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 19, "christina@baumbach.info", "Dr. Gennaro Haag" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 18, "david_bode@ryan.ca", "Aurelie Hickle" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 17, "maye.koelpin@blanda.co.uk", "Dr. Hettie Towne" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 16, "esta_ohara@mcglynn.info", "Madalyn Breitenberg" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 15, "amara@lueilwitzmann.ca", "Delphia Schuster PhD" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 14, "nola_pollich@crooks.biz", "Jayda Lueilwitz IV" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 13, "adele@parisian.co.uk", "Letitia Rogahn" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 12, "general@gusikowski.uk", "Bessie Muller" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 11, "mike@corkery.name", "Javier Rohan" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 10, "rita_gislason@powlowski.name", "Elmer Frami" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 9, "gloria.johnson@littel.us", "Celestine Bogisich PhD" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 8, "quinten@gleasongreenholt.co.uk", "Jasen Jacobs" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 7, "mireya@kuvalis.biz", "Toney Rutherford" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 6, "damian.johnson@bogan.com", "Camylle King" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 5, "melvin.marvin@cartwright.info", "Isaias Collins" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 4, "ocie@rohan.info", "Larry Strosin" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 3, "maximilian_wiza@ankunding.ca", "Trystan Gottlieb" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 2, "joan.maggio@deckowgreenfelder.us", "Bradford Reynolds" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 23, "justyn.hilpert@waelchi.co.uk", "Uriah Yundt" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 24, "jalyn.mueller@bernhard.uk", "Garland Borer" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 25, "blair_mcglynn@walsheffertz.us", "Dr. Winfield Gerhold" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 26, "tremaine@bashirian.com", "Willa Goldner" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 48, "hilda_wintheiser@champlin.biz", "Lamont Batz II" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 47, "katherine_hintz@kris.uk", "Jorge Schaden" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 46, "jeramy@cummerata.com", "Gisselle Reichel" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 45, "chaz@dietrichpouros.biz", "Dallas Green" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 44, "juliana@balistrericartwright.ca", "Rhiannon Jakubowski" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 43, "lavinia@beckerkozey.com", "Buddy Lowe" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 42, "colton@murazik.biz", "Virgie Kris" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 41, "kendrick@torphy.info", "Meredith Buckridge" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 40, "kendall@torp.info", "Nona Medhurst III" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 39, "santos_halvorson@yost.biz", "Otha Sipes" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 99, "daren_schulist@ziemannanderson.com", "Ashton Torp" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 38, "antonetta_kerluke@jerdeyundt.us", "Desmond Larson" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 36, "kenny@effertz.name", "Mrs. Madge Hoeger" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 35, "weldon.kuvalis@walker.uk", "Whitney Haag" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 34, "harold@feeneyhilpert.uk", "Valentina Blick IV" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 33, "maddison_treutel@vandervortankunding.uk", "Jeromy Casper" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 32, "issac@hettingerboehm.info", "Hal Kohler" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 31, "bernita@stracke.com", "Joannie Rogahn I" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 30, "cali.bradtke@lowevolkman.com", "Jan Roberts" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 29, "jaylon@kozey.us", "Carolyn Rodriguez" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 28, "beryl@schmitt.biz", "Sarah Luettgen" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 27, "kenton_hegmann@johns.co.uk", "Leopold Cronin" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 37, "esteban_yost@torphy.biz", "Karl Wyman" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 100, "dennis_romaguera@okeefeconn.biz", "Madilyn Swaniawski" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 29, new DateTime(2018, 11, 17, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 1, 41735.3269m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 187, new DateTime(2018, 11, 2, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 55, 12221.3216m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 179, new DateTime(2018, 11, 3, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 56, 77576.1521m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 71, new DateTime(2019, 4, 8, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 57, 23258.1698m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 169, new DateTime(2019, 3, 9, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 57, 60782.1490m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 37, new DateTime(2018, 9, 29, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 58, 32127.2513m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 135, new DateTime(2018, 12, 18, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 58, 53223.798m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 61, new DateTime(2019, 4, 28, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 59, 34089.838m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 82, new DateTime(2018, 12, 22, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 59, 78638.3200m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 103, new DateTime(2019, 3, 12, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 59, 17841.2839m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 20, new DateTime(2019, 5, 10, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 60, 28262.831m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 48, new DateTime(2019, 5, 31, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 60, 71286.2685m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 104, new DateTime(2019, 5, 18, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 60, 79267.110m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 19, new DateTime(2019, 6, 10, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 61, 86159.615m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 134, new DateTime(2018, 12, 12, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 62, 4674.3815m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 69, new DateTime(2018, 12, 7, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 63, 39638.408m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 45, new DateTime(2018, 12, 31, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 64, 83473.827m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 74, new DateTime(2018, 10, 19, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 66, 87990.3757m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 34, new DateTime(2018, 10, 15, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 67, 51356.2164m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 25, new DateTime(2019, 5, 20, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 69, 18500.2869m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 73, new DateTime(2019, 2, 10, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 70, 66666.1634m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 150, new DateTime(2019, 3, 21, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 70, 34328.405m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 132, new DateTime(2019, 1, 19, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 55, 3915.1514m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 199, new DateTime(2019, 6, 15, 0, 58, 51, 676, DateTimeKind.Local).AddTicks(3111), 71, 19533.1243m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 35, new DateTime(2019, 3, 31, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 55, 19738.2115m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 7, new DateTime(2019, 7, 5, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 54, 94439.638m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 137, new DateTime(2019, 4, 25, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 44, 62883.217m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 43, new DateTime(2018, 10, 25, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 45, 40354.1979m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 116, new DateTime(2019, 1, 22, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 45, 27792.2949m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 126, new DateTime(2019, 3, 14, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 45, 15411.79m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 113, new DateTime(2019, 7, 11, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 46, 6538.1261m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 148, new DateTime(2019, 3, 3, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 46, 91379.633m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 23, new DateTime(2019, 3, 5, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 47, 7807.3462m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 31, new DateTime(2019, 2, 16, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 47, 49502.3160m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 160, new DateTime(2018, 10, 4, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 47, 51302.3270m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 42, new DateTime(2018, 12, 12, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 48, 75830.3722m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 166, new DateTime(2018, 12, 14, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 48, 20487.3132m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 195, new DateTime(2018, 9, 25, 0, 58, 51, 676, DateTimeKind.Local).AddTicks(3111), 48, 68392.3484m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 75, new DateTime(2019, 7, 9, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 49, 36026.2989m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 153, new DateTime(2018, 12, 5, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 49, 29669.627m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 118, new DateTime(2018, 11, 26, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 50, 77649.3440m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 180, new DateTime(2019, 6, 5, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 50, 7064.729m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 14, new DateTime(2019, 6, 19, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 52, 86021.3773m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 80, new DateTime(2018, 10, 28, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 52, 27820.2710m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 93, new DateTime(2019, 1, 28, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 52, 22792.2141m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 105, new DateTime(2019, 3, 31, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 52, 39841.1414m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 18, new DateTime(2019, 5, 7, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 53, 96228.2272m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 152, new DateTime(2019, 6, 27, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 54, 98287.3272m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 9, new DateTime(2019, 4, 18, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 44, 10012.2415m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 59, new DateTime(2018, 9, 24, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 72, 3175.165m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 94, new DateTime(2018, 12, 11, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 74, 36585.3477m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 125, new DateTime(2019, 3, 29, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 88, 1775.1526m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 171, new DateTime(2019, 4, 11, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 88, 86700.1057m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 140, new DateTime(2018, 11, 24, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 89, 52901.2257m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 185, new DateTime(2019, 3, 9, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 89, 8128.2328m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 174, new DateTime(2018, 10, 28, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 90, 98659.563m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 182, new DateTime(2018, 11, 3, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 90, 6894.1472m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 143, new DateTime(2019, 2, 18, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 91, 86562.1032m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 120, new DateTime(2018, 11, 3, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 92, 98955.2071m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 170, new DateTime(2019, 5, 31, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 92, 31011.2835m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 2, new DateTime(2018, 10, 12, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 93, 54815.1872m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 108, new DateTime(2018, 10, 5, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 93, 5984.2274m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 1, new DateTime(2019, 6, 14, 0, 58, 51, 671, DateTimeKind.Local).AddTicks(3109), 94, 17341.910m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 52, new DateTime(2019, 6, 2, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 94, 13322.2624m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 62, new DateTime(2019, 6, 24, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 94, 70633.3961m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 186, new DateTime(2019, 5, 7, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 94, 40561.82m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 145, new DateTime(2018, 11, 17, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 95, 24879.3719m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 110, new DateTime(2018, 9, 19, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 97, 57224.2740m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 89, new DateTime(2018, 11, 13, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 98, 57345.2824m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 46, new DateTime(2019, 4, 10, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 99, 15073.177m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 57, new DateTime(2019, 2, 19, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 99, 16443.2435m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 88, new DateTime(2018, 10, 28, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 99, 25880.3664m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 122, new DateTime(2019, 4, 21, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 87, 47091.1675m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 158, new DateTime(2018, 11, 24, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 73, 98218.53m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 10, new DateTime(2018, 12, 19, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 87, 83621.1m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 86, new DateTime(2019, 3, 30, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 86, 56902.3718m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 63, new DateTime(2018, 10, 20, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 75, 37802.1990m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 78, new DateTime(2018, 12, 23, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 75, 26974.570m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 95, new DateTime(2018, 9, 29, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 75, 77241.2008m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 100, new DateTime(2019, 4, 8, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 75, 77990.1834m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 26, new DateTime(2019, 5, 9, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 76, 37210.2334m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 117, new DateTime(2018, 12, 22, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 76, 92610.3460m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 146, new DateTime(2019, 5, 7, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 76, 45230.3882m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 8, new DateTime(2018, 12, 20, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 77, 9685.1614m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 28, new DateTime(2018, 9, 29, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 77, 56857.3021m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 91, new DateTime(2019, 7, 4, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 79, 61777.1835m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 72, new DateTime(2018, 11, 3, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 80, 63616.1m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 165, new DateTime(2018, 12, 11, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 80, 14049.3136m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 64, new DateTime(2019, 2, 15, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 81, 39820.1075m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 87, new DateTime(2018, 9, 24, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 81, 28609.3754m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 97, new DateTime(2018, 11, 10, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 82, 82385.310m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 58, new DateTime(2019, 7, 1, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 83, 69214.3861m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 50, new DateTime(2018, 12, 24, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 84, 14862.2442m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 21, new DateTime(2018, 11, 12, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 85, 46148.367m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 141, new DateTime(2018, 12, 8, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 85, 88079.2362m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 192, new DateTime(2019, 2, 16, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 85, 35789.960m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 193, new DateTime(2019, 3, 28, 0, 58, 51, 676, DateTimeKind.Local).AddTicks(3111), 85, 1915.1352m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 6, new DateTime(2019, 6, 19, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 87, 92407.97m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 154, new DateTime(2018, 12, 11, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 43, 39103.837m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 85, new DateTime(2018, 10, 29, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 43, 96418.2157m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 15, new DateTime(2018, 10, 17, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 43, 64791.3102m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 161, new DateTime(2018, 11, 16, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 10, 35785.861m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 189, new DateTime(2018, 12, 4, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 10, 53636.2274m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 76, new DateTime(2019, 6, 13, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 11, 63965.315m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 77, new DateTime(2018, 9, 28, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 11, 96633.2628m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 90, new DateTime(2019, 6, 16, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 11, 32377.3877m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 175, new DateTime(2019, 6, 8, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 11, 14437.3601m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 54, new DateTime(2019, 3, 18, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 12, 26238.2807m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 107, new DateTime(2019, 1, 7, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 12, 81899.1234m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 159, new DateTime(2018, 11, 6, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 12, 39343.1729m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 33, new DateTime(2019, 4, 27, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 13, 98635.1869m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 106, new DateTime(2019, 6, 18, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 13, 56904.3891m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 200, new DateTime(2019, 6, 17, 0, 58, 51, 676, DateTimeKind.Local).AddTicks(3111), 13, 22885.3080m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 38, new DateTime(2019, 2, 3, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 15, 53900.2936m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 16, new DateTime(2019, 4, 19, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 17, 7863.1826m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 32, new DateTime(2018, 11, 11, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 17, 97185.1280m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 111, new DateTime(2019, 4, 16, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 18, 84220.1385m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 17, new DateTime(2019, 3, 21, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 20, 51071.1613m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 40, new DateTime(2019, 5, 10, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 20, 65282.3987m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 121, new DateTime(2019, 3, 31, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 20, 74258.1352m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 130, new DateTime(2018, 10, 24, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 20, 75555.3452m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 123, new DateTime(2018, 11, 30, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 21, 93304.2004m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 114, new DateTime(2019, 6, 9, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 10, 10582.833m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 168, new DateTime(2019, 4, 16, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 21, 10996.1600m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 164, new DateTime(2019, 2, 14, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 9, 66519.2009m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 188, new DateTime(2019, 3, 17, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 8, 95052.374m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 56, new DateTime(2019, 4, 27, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 1, 54026.2968m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 155, new DateTime(2018, 9, 26, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 1, 15226.449m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 5, new DateTime(2019, 5, 11, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 2, 9574.259m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 96, new DateTime(2019, 6, 3, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 2, 47393.1014m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 157, new DateTime(2019, 3, 16, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 2, 98404.765m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 53, new DateTime(2018, 11, 5, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 3, 17532.1702m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 83, new DateTime(2019, 3, 20, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 3, 22039.832m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 172, new DateTime(2019, 2, 18, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 3, 67904.545m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 197, new DateTime(2019, 7, 5, 0, 58, 51, 676, DateTimeKind.Local).AddTicks(3111), 3, 30204.510m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 119, new DateTime(2019, 1, 4, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 4, 48371.350m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 44, new DateTime(2018, 11, 29, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 5, 12651.1215m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 79, new DateTime(2019, 7, 3, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 6, 67888.571m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 138, new DateTime(2019, 5, 16, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 6, 94251.2015m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 12, new DateTime(2019, 3, 15, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 7, 81017.2923m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 22, new DateTime(2018, 11, 4, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 7, 20297.539m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 24, new DateTime(2018, 12, 21, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 7, 92630.1322m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 66, new DateTime(2019, 4, 6, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 7, 61403.1328m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 92, new DateTime(2018, 10, 12, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 7, 90858.671m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 98, new DateTime(2019, 3, 23, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 7, 95027.956m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 60, new DateTime(2018, 9, 20, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 8, 91653.1965m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 181, new DateTime(2019, 2, 16, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 8, 49161.3555m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 163, new DateTime(2019, 7, 12, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 9, 74739.457m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 176, new DateTime(2019, 4, 11, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 21, 76495.3467m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 194, new DateTime(2018, 11, 9, 0, 58, 51, 676, DateTimeKind.Local).AddTicks(3111), 21, 20384.247m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 65, new DateTime(2019, 5, 16, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 22, 91542.3470m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 84, new DateTime(2019, 6, 7, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 31, 21559.489m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 124, new DateTime(2019, 1, 3, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 32, 43461.2060m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 136, new DateTime(2019, 4, 1, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 32, 8492.3989m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 190, new DateTime(2018, 11, 17, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 32, 64399.3087m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 39, new DateTime(2018, 12, 13, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 33, 21508.2700m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 131, new DateTime(2019, 4, 21, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 33, 60414.2336m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 51, new DateTime(2018, 10, 8, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 34, 35214.1540m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 81, new DateTime(2019, 2, 14, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 34, 2752.3974m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 99, new DateTime(2019, 1, 27, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 34, 63828.3343m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 184, new DateTime(2019, 1, 29, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 34, 88921.2226m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 4, new DateTime(2019, 5, 26, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 35, 73337.2479m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 3, new DateTime(2018, 12, 8, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 36, 69457.1421m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 70, new DateTime(2019, 3, 20, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 36, 75521.3911m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 133, new DateTime(2019, 6, 9, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 36, 7560.3326m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 196, new DateTime(2018, 10, 19, 0, 58, 51, 676, DateTimeKind.Local).AddTicks(3111), 36, 62423.909m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 55, new DateTime(2019, 6, 14, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 39, 66776.3337m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 142, new DateTime(2019, 7, 3, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 39, 19073.2427m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 41, new DateTime(2019, 5, 14, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 41, 53805.2118m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 128, new DateTime(2018, 11, 18, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 42, 61637.3386m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 191, new DateTime(2018, 10, 4, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 42, 12766.2097m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 198, new DateTime(2018, 9, 21, 0, 58, 51, 676, DateTimeKind.Local).AddTicks(3111), 42, 21718.3912m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 67, new DateTime(2019, 5, 31, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 31, 52656.168m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 49, new DateTime(2019, 1, 22, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 31, 12009.3531m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 156, new DateTime(2018, 10, 19, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 30, 97135.1907m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 129, new DateTime(2018, 10, 7, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 30, 40781.2052m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 162, new DateTime(2018, 11, 7, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 22, 70501.2409m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 183, new DateTime(2019, 1, 25, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 22, 90752.753m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 27, new DateTime(2018, 11, 9, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 23, 33014.827m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 102, new DateTime(2019, 5, 28, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 23, 97513.3283m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 109, new DateTime(2019, 3, 22, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 23, 8493.2473m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 167, new DateTime(2018, 12, 19, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 23, 58764.1710m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 13, new DateTime(2019, 2, 23, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 24, 86248.1857m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 101, new DateTime(2019, 5, 23, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 24, 19296.3030m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 115, new DateTime(2019, 2, 16, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 24, 98844.79m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 30, new DateTime(2018, 11, 19, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 25, 60558.920m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 112, new DateTime(2018, 11, 15, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 100, 34983.1848m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 139, new DateTime(2018, 11, 25, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 25, 87532.3723m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 47, new DateTime(2018, 12, 10, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 26, 54815.209m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 151, new DateTime(2019, 2, 27, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 26, 45433.1923m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 127, new DateTime(2019, 4, 19, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 27, 26373.379m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 36, new DateTime(2019, 2, 10, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 28, 54204.3785m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 149, new DateTime(2019, 5, 7, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 28, 29908.369m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 173, new DateTime(2018, 9, 18, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 28, 95842.3901m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 178, new DateTime(2018, 10, 5, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 28, 74360.955m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 147, new DateTime(2018, 10, 14, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 29, 33208.506m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 11, new DateTime(2019, 5, 31, 0, 58, 51, 673, DateTimeKind.Local).AddTicks(3110), 30, 82608.1672m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 68, new DateTime(2019, 1, 26, 0, 58, 51, 674, DateTimeKind.Local).AddTicks(3110), 30, 64462.611m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 177, new DateTime(2018, 11, 19, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 25, 57922.2102m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 144, new DateTime(2018, 11, 12, 0, 58, 51, 675, DateTimeKind.Local).AddTicks(3111), 100, 47372.3325m });

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
