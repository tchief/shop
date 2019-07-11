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
                values: new object[] { 1, "syble_gutmann@gleason.com", "Daphne Erdman II" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 73, "kyra_hamill@blandatrantow.uk", "Desiree Robel" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 72, "sarina@langworth.us", "Nannie Gleichner" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 71, "pablo_mohr@schoen.uk", "Marshall Lubowitz" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 70, "alysson@schmeler.uk", "Kelli Kuphal" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 69, "ernestina.von@hammes.us", "Ernie Funk" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 68, "laurence@monahan.co.uk", "Reece Kunde" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 67, "lambert.swaniawski@zulaufblock.uk", "Dr. Bradly Beer" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 66, "gregory@abshiremuller.info", "Margret Braun" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 65, "destinee@pfannerstill.us", "Lukas Little" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 64, "noemy.legros@mrazwilliamson.com", "Aiyana Kunde" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 63, "santiago@torphy.ca", "Carlos Heaney" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 62, "albertha@kertzmann.us", "Frieda Gusikowski DDS" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 61, "yesenia@anderson.us", "Carroll Wisozk" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 60, "candelario@lynch.info", "Isadore Zieme" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 59, "percy.stehr@torphy.biz", "Jessyca Lesch" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 58, "elvera_stracke@casperkozey.co.uk", "Cicero Koepp" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 57, "jasper@watsica.co.uk", "Haley Bechtelar" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 56, "connor@kuhn.info", "Elisha Trantow III" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 55, "catalina_braun@glover.co.uk", "Mrs. Raegan Schmeler" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 54, "autumn.gaylord@bosco.co.uk", "Jeffery O'Kon" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 53, "alexandrea@farrellkerluke.us", "Maryam Brown" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 74, "ludie@balistreri.us", "Lue Pollich" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 52, "delbert@kutch.us", "Dr. Ezequiel Lueilwitz" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 75, "cecil_fay@darekassulke.us", "Jordan West" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 77, "amara@stamm.name", "Tate Walker DDS" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 98, "marjolaine.mann@hettinger.co.uk", "Marilyne Conroy" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 97, "jessyca@keeling.co.uk", "Stone Goyette" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 96, "emerson_douglas@wiegand.ca", "Nathen Lehner" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 95, "jasmin@heller.name", "Archibald Hintz" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 94, "alejandra@schultz.uk", "Brandyn Abbott" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 93, "imani@miller.info", "Alisha Spencer" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 92, "ned_roob@feeneyosinski.us", "Elsa Schulist" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 91, "mabelle@pouroscrona.biz", "Patsy Tromp" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 90, "karolann_tremblay@yundt.com", "Ms. Casimer Barton" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 89, "wendell.buckridge@runtelegros.biz", "Cassidy Orn" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 88, "estrella@jacobsherzog.name", "Lenny Cassin" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 87, "casimir@konopelski.name", "Mose Muller" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 86, "winston@hodkiewicz.uk", "Alena Lemke" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 85, "candelario.mohr@rice.info", "Dr. Darrin Leannon" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 84, "melyssa@schaefer.co.uk", "Ebony Schinner" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 83, "bryana_rutherford@hayesrau.name", "Leora Walker" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 82, "alford@corwinfarrell.uk", "Raymond Lehner" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 81, "idella.spencer@robel.com", "Caden Wolf" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 80, "arianna@hilpert.com", "Layne Bahringer" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 79, "adrian.powlowski@steuber.co.uk", "Bennie Ebert" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 78, "percy_jewess@bogisich.name", "Willie Romaguera" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 76, "ubaldo@dach.com", "Vernice Pagac" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 51, "kaley.dickinson@eichmann.co.uk", "Jade Bins V" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 50, "maggie@langworthhayes.uk", "Logan Adams" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 49, "olen_hane@sporer.us", "Delfina Cummings" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 22, "jan@kuphalmonahan.info", "Onie Langworth DDS" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 21, "lionel_pouros@jakubowskiorn.com", "Nyah Rippin" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 20, "quinn@oreillyhilll.com", "Madisyn Wilkinson" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 19, "alison@schinner.info", "Jefferey Emmerich" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 18, "kellie@greenbeer.uk", "Edwardo Langosh" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 17, "liliana_stark@powlowskifisher.info", "Wilfred Raynor MD" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 16, "chet.rau@schneiderstanton.biz", "Jazmin Terry" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 15, "adell@mcglynnbergnaum.us", "Gerard Beahan" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 14, "anahi_christiansen@schmittchamplin.co.uk", "Taya Schoen" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 13, "jayce@schiller.co.uk", "Leone Ratke" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 12, "abraham_prosacco@kunzegreen.name", "Herminio Nader" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 11, "erna@yundt.com", "Boyd Hane Sr." });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 10, "bulah@blockhintz.name", "Amos Kunde" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 9, "rebecca@fritsch.info", "Sidney Frami V" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 8, "judge_wilderman@nader.com", "Khalil Rippin" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 7, "dominique@halvorson.info", "Ashleigh Tremblay" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 6, "roxanne@kris.com", "Marlin Spencer PhD" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 5, "roselyn@pouros.name", "Kristy Wintheiser" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 4, "ronny@pagac.biz", "Hailee Zemlak" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 3, "catalina_kerluke@bechtelar.co.uk", "Florine Brekke" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 2, "bonita@labadie.uk", "Mr. Maribel Raynor" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 23, "violet_smitham@kris.com", "Ruthe Grady" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 24, "benny_mcdermott@lemkequigley.com", "Stefan Greenfelder" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 25, "casimir@harvey.com", "Mason Wilkinson" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 26, "jacinto.olson@steuber.name", "Hassan Tillman" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 48, "kareem@stokes.name", "Theodora Wilderman" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 47, "jake@waters.us", "Crystal Feeney" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 46, "beth@zemlakward.co.uk", "Murl Moore" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 45, "marco.beahan@littelkemmer.uk", "Madison Morar" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 44, "lydia@schneider.biz", "Haley Kling" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 43, "macey_greenholt@durgandurgan.us", "Novella Langworth IV" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 42, "wanda@powlowski.com", "Angie McGlynn" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 41, "luisa@hoeger.uk", "Lamar Morar" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 40, "deangelo@abernathy.name", "Judge Aufderhar" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 39, "jaren@gulgowski.info", "Zack King" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 99, "watson@pfannerstill.info", "Magdalena Batz" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 38, "ezra@hermann.name", "Shaina Kilback" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 36, "raoul_bernhard@ernser.biz", "Maurine Wehner" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 35, "adele_kessler@damore.ca", "Tod Hayes" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 34, "tamara@watsica.name", "Dr. Cecilia Orn" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 33, "ezra.feil@dare.name", "Hertha Hodkiewicz" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 32, "jules@millerbruen.us", "Ora Moen" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 31, "jettie@ohara.com", "Brett Boehm" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 30, "monty_lebsack@reilly.us", "Ozella Kuhlman" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 29, "agustin.franecki@douglas.ca", "Alexis Johnson III" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 28, "monique_ullrich@kessler.biz", "Darrel Goyette" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 27, "lewis@larsonhessel.biz", "Madalyn Willms" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 37, "lester@oreillyvandervort.ca", "Zita Mitchell DVM" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[] { 100, "susan.damore@stokes.info", "Samir Leffler" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 1, new DateTime(2018, 10, 31, 1, 24, 53, 678, DateTimeKind.Local).AddTicks(7965), 1, 51693.2887m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 54, new DateTime(2019, 1, 23, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 60, 76561.2247m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 2, new DateTime(2018, 12, 27, 1, 24, 53, 680, DateTimeKind.Local).AddTicks(7966), 61, 68991.2517m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 10, new DateTime(2019, 4, 6, 1, 24, 53, 680, DateTimeKind.Local).AddTicks(7966), 61, 54274.945m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 102, new DateTime(2019, 5, 21, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 61, 4870.1933m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 105, new DateTime(2019, 5, 31, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 61, 13021.2587m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 15, new DateTime(2019, 3, 27, 1, 24, 53, 680, DateTimeKind.Local).AddTicks(7966), 62, 82493.3545m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 64, new DateTime(2018, 11, 23, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 62, 92268.1052m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 192, new DateTime(2019, 4, 3, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 62, 75613.2582m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 5, new DateTime(2018, 10, 4, 1, 24, 53, 680, DateTimeKind.Local).AddTicks(7966), 63, 2452.3914m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 57, new DateTime(2019, 4, 29, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 63, 87177.415m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 67, new DateTime(2018, 9, 22, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 63, 12929.107m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 153, new DateTime(2018, 11, 13, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 63, 37430.2172m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 171, new DateTime(2019, 1, 17, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 63, 76731.210m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 145, new DateTime(2018, 11, 23, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 64, 45340.3715m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 68, new DateTime(2019, 4, 4, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 66, 7614.3280m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 8, new DateTime(2019, 3, 9, 1, 24, 53, 680, DateTimeKind.Local).AddTicks(7966), 68, 61871.1466m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 149, new DateTime(2018, 12, 11, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 68, 5074.1243m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 94, new DateTime(2019, 5, 10, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 70, 61313.1991m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 159, new DateTime(2018, 10, 6, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 70, 43895.94m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 62, new DateTime(2019, 1, 22, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 71, 38576.321m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 73, new DateTime(2018, 10, 10, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 71, 29763.3689m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 114, new DateTime(2018, 11, 7, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 59, 9977.3694m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 179, new DateTime(2018, 11, 5, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 71, 72066.208m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 178, new DateTime(2019, 6, 12, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 58, 27.2043m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 107, new DateTime(2019, 3, 1, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 58, 43900.1600m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 12, new DateTime(2018, 12, 26, 1, 24, 53, 680, DateTimeKind.Local).AddTicks(7966), 47, 38230.226m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 113, new DateTime(2019, 1, 24, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 48, 82105.26m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 137, new DateTime(2018, 12, 10, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 48, 68464.3597m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 195, new DateTime(2019, 2, 25, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 48, 9254.605m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 71, new DateTime(2019, 2, 4, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 49, 93022.3879m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 101, new DateTime(2019, 3, 16, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 49, 90426.3803m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 4, new DateTime(2019, 7, 9, 1, 24, 53, 680, DateTimeKind.Local).AddTicks(7966), 50, 22541.3151m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 9, new DateTime(2019, 5, 17, 1, 24, 53, 680, DateTimeKind.Local).AddTicks(7966), 50, 30290.735m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 116, new DateTime(2019, 4, 13, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 51, 23262.1585m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 175, new DateTime(2018, 12, 7, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 51, 18043.546m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 124, new DateTime(2019, 1, 12, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 53, 25555.1193m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 6, new DateTime(2018, 10, 20, 1, 24, 53, 680, DateTimeKind.Local).AddTicks(7966), 54, 71630.766m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 36, new DateTime(2019, 4, 5, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 54, 6598.412m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 106, new DateTime(2018, 10, 2, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 54, 20675.961m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 199, new DateTime(2019, 6, 22, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 54, 11254.1655m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 18, new DateTime(2019, 1, 14, 1, 24, 53, 680, DateTimeKind.Local).AddTicks(7966), 55, 88800.1637m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 31, new DateTime(2019, 4, 26, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 55, 83631.747m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 143, new DateTime(2019, 6, 3, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 55, 28043.630m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 127, new DateTime(2018, 11, 9, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 56, 62157.3822m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 166, new DateTime(2018, 11, 18, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 56, 49676.3366m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 136, new DateTime(2018, 11, 16, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 57, 96702.999m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 167, new DateTime(2019, 5, 13, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 58, 58889.371m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 148, new DateTime(2019, 4, 13, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 46, 11707.3038m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 119, new DateTime(2019, 5, 1, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 72, 79745.1538m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 33, new DateTime(2018, 12, 20, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 74, 12729.2241m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 82, new DateTime(2018, 12, 16, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 91, 14340.2317m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 104, new DateTime(2018, 10, 21, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 91, 21799.3256m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 184, new DateTime(2018, 12, 8, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 91, 98918.3409m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 39, new DateTime(2018, 12, 21, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 92, 47305.768m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 46, new DateTime(2019, 3, 22, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 93, 6983.2669m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 170, new DateTime(2018, 12, 13, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 93, 35020.2948m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 3, new DateTime(2019, 7, 8, 1, 24, 53, 680, DateTimeKind.Local).AddTicks(7966), 94, 36034.1176m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 88, new DateTime(2019, 6, 7, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 94, 50119.236m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 156, new DateTime(2019, 2, 3, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 94, 23140.2312m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 189, new DateTime(2019, 3, 28, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 94, 22938.2125m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 61, new DateTime(2018, 9, 17, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 95, 2879.3263m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 77, new DateTime(2019, 6, 13, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 95, 98583.2525m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 63, new DateTime(2018, 10, 26, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 96, 13946.1594m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 172, new DateTime(2019, 1, 24, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 96, 56841.37m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 53, new DateTime(2018, 12, 18, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 97, 77269.2133m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 169, new DateTime(2019, 4, 8, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 97, 59066.3624m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 154, new DateTime(2019, 6, 30, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 98, 39032.2889m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 173, new DateTime(2019, 5, 6, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 99, 69734.2587m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 200, new DateTime(2018, 9, 21, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 99, 6230.1230m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 27, new DateTime(2018, 10, 18, 1, 24, 53, 680, DateTimeKind.Local).AddTicks(7966), 100, 62425.1183m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 146, new DateTime(2018, 9, 27, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 100, 22485.2894m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 24, new DateTime(2019, 5, 7, 1, 24, 53, 680, DateTimeKind.Local).AddTicks(7966), 91, 75747.956m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 70, new DateTime(2019, 7, 2, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 73, 21353.2866m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 128, new DateTime(2018, 12, 11, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 90, 99144.1536m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 83, new DateTime(2018, 10, 2, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 89, 10658.3838m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 45, new DateTime(2018, 9, 20, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 74, 25634.3425m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 66, new DateTime(2019, 1, 19, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 74, 25312.2395m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 91, new DateTime(2019, 6, 18, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 77, 60294.3384m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 182, new DateTime(2019, 2, 7, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 77, 93999.617m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 48, new DateTime(2019, 5, 14, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 78, 64398.3177m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 100, new DateTime(2019, 3, 12, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 79, 79003.1351m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 129, new DateTime(2019, 1, 7, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 79, 42725.295m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 76, new DateTime(2019, 4, 18, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 80, 68013.3924m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 147, new DateTime(2019, 4, 21, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 80, 72232.2992m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 32, new DateTime(2019, 4, 2, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 82, 96282.552m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 49, new DateTime(2018, 10, 12, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 82, 95763.3496m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 89, new DateTime(2019, 3, 1, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 82, 81642.1956m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 161, new DateTime(2019, 6, 3, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 82, 3556.3191m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 38, new DateTime(2018, 10, 28, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 84, 25537.843m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 74, new DateTime(2018, 11, 8, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 84, 79562.306m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 81, new DateTime(2018, 9, 25, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 84, 61065.2010m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 86, new DateTime(2018, 10, 17, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 84, 70114.3193m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 13, new DateTime(2018, 12, 12, 1, 24, 53, 680, DateTimeKind.Local).AddTicks(7966), 85, 61013.2772m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 50, new DateTime(2018, 12, 25, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 87, 6285.2938m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 95, new DateTime(2019, 5, 13, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 87, 32119.211m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 191, new DateTime(2019, 2, 10, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 87, 46494.1986m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 118, new DateTime(2018, 9, 23, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 90, 31277.2608m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 37, new DateTime(2019, 1, 4, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 46, 38984.249m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 7, new DateTime(2019, 3, 5, 1, 24, 53, 680, DateTimeKind.Local).AddTicks(7966), 46, 46894.3299m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 165, new DateTime(2018, 12, 8, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 44, 78224.82m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 87, new DateTime(2018, 12, 30, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 11, 76304.686m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 19, new DateTime(2019, 7, 7, 1, 24, 53, 680, DateTimeKind.Local).AddTicks(7966), 12, 30075.798m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 21, new DateTime(2019, 2, 12, 1, 24, 53, 680, DateTimeKind.Local).AddTicks(7966), 12, 98102.3681m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 51, new DateTime(2018, 10, 19, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 12, 83906.461m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 110, new DateTime(2018, 12, 28, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 12, 79844.3337m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 112, new DateTime(2019, 6, 6, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 12, 52358.3899m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 20, new DateTime(2019, 3, 20, 1, 24, 53, 680, DateTimeKind.Local).AddTicks(7966), 13, 79412.1921m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 55, new DateTime(2018, 10, 4, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 13, 4050.1438m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 59, new DateTime(2018, 12, 5, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 13, 11414.3906m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 98, new DateTime(2019, 6, 28, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 14, 10584.1710m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 133, new DateTime(2018, 10, 10, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 14, 41415.3241m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 144, new DateTime(2018, 11, 18, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 14, 77479.2974m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 183, new DateTime(2018, 9, 16, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 14, 94715.1559m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 29, new DateTime(2019, 1, 27, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 15, 33957.2533m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 90, new DateTime(2019, 1, 10, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 15, 78283.868m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 93, new DateTime(2019, 6, 4, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 15, 78094.1088m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 174, new DateTime(2018, 12, 27, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 15, 77844.123m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 180, new DateTime(2018, 9, 18, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 15, 5499.523m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 44, new DateTime(2019, 4, 19, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 17, 53162.159m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 108, new DateTime(2018, 10, 25, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 17, 77116.3057m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 121, new DateTime(2018, 10, 6, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 17, 5409.3196m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 103, new DateTime(2018, 9, 21, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 10, 32525.3527m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 26, new DateTime(2019, 2, 21, 1, 24, 53, 680, DateTimeKind.Local).AddTicks(7966), 18, 63655.621m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 99, new DateTime(2019, 5, 9, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 10, 82636.1680m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 157, new DateTime(2019, 4, 17, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 9, 94516.2765m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 198, new DateTime(2019, 2, 13, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 1, 72156.1254m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 17, new DateTime(2018, 11, 14, 1, 24, 53, 680, DateTimeKind.Local).AddTicks(7966), 2, 33585.3307m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 58, new DateTime(2018, 11, 16, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 2, 73178.2470m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 78, new DateTime(2019, 6, 3, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 2, 70578.92m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 125, new DateTime(2018, 9, 30, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 2, 6824.1365m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 130, new DateTime(2019, 3, 28, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 2, 66231.1274m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 56, new DateTime(2018, 10, 5, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 3, 55864.589m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 142, new DateTime(2018, 11, 20, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 3, 85538.2898m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 196, new DateTime(2018, 12, 9, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 3, 76894.2154m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 197, new DateTime(2019, 2, 2, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 3, 85119.877m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 30, new DateTime(2019, 3, 9, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 4, 1919.2669m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 43, new DateTime(2018, 11, 10, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 5, 24986.2783m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 141, new DateTime(2019, 2, 27, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 5, 75102.3205m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 126, new DateTime(2018, 12, 17, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 6, 79310.299m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 60, new DateTime(2019, 2, 22, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 7, 88821.1725m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 85, new DateTime(2019, 2, 3, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 8, 2782.3646m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 132, new DateTime(2019, 6, 26, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 8, 74825.226m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 163, new DateTime(2019, 4, 29, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 8, 89418.973m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 177, new DateTime(2018, 12, 3, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 8, 53474.15m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 115, new DateTime(2019, 2, 12, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 9, 6587.294m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 140, new DateTime(2019, 1, 18, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 9, 12865.3883m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 14, new DateTime(2018, 11, 27, 1, 24, 53, 680, DateTimeKind.Local).AddTicks(7966), 10, 45785.154m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 138, new DateTime(2019, 6, 23, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 18, 78039.2190m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 79, new DateTime(2019, 5, 3, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 19, 72959.887m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 152, new DateTime(2019, 3, 21, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 19, 21080.3796m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 92, new DateTime(2018, 11, 4, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 34, 86802.1568m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 176, new DateTime(2019, 5, 27, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 34, 32077.108m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 158, new DateTime(2019, 3, 20, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 35, 56763.3922m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 164, new DateTime(2019, 1, 3, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 35, 52756.3746m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 16, new DateTime(2019, 5, 26, 1, 24, 53, 680, DateTimeKind.Local).AddTicks(7966), 36, 85133.623m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 162, new DateTime(2018, 12, 4, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 36, 54073.634m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 187, new DateTime(2019, 4, 29, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 36, 67351.156m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 40, new DateTime(2019, 5, 14, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 37, 76156.3660m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 47, new DateTime(2019, 2, 11, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 37, 18050.507m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 117, new DateTime(2019, 1, 5, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 37, 69909.1779m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 131, new DateTime(2018, 10, 6, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 37, 78204.1177m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 11, new DateTime(2018, 10, 11, 1, 24, 53, 680, DateTimeKind.Local).AddTicks(7966), 40, 13125.1940m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 52, new DateTime(2019, 3, 25, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 40, 30233.3027m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 181, new DateTime(2019, 3, 8, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 40, 1564.1814m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 25, new DateTime(2019, 4, 19, 1, 24, 53, 680, DateTimeKind.Local).AddTicks(7966), 41, 96605.3354m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 69, new DateTime(2019, 5, 9, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 41, 91640.1263m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 96, new DateTime(2019, 5, 4, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 41, 9056.2778m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 34, new DateTime(2019, 3, 20, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 42, 85584.2568m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 42, new DateTime(2019, 5, 8, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 43, 7260.3944m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 65, new DateTime(2019, 6, 21, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 43, 41842.1844m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 84, new DateTime(2018, 10, 18, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 44, 1813.3379m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 123, new DateTime(2018, 10, 19, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 33, 84620.3400m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 120, new DateTime(2019, 5, 20, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 33, 6674.3596m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 97, new DateTime(2019, 3, 28, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 33, 69852.3357m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 35, new DateTime(2019, 1, 30, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 33, 93676.837m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 185, new DateTime(2018, 11, 29, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 19, 2915.312m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 190, new DateTime(2018, 9, 21, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 19, 46136.989m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 28, new DateTime(2018, 10, 28, 1, 24, 53, 680, DateTimeKind.Local).AddTicks(7966), 20, 57048.126m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 75, new DateTime(2019, 1, 19, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 20, 39500.105m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 109, new DateTime(2018, 9, 20, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 21, 63453.3005m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 135, new DateTime(2019, 2, 9, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 21, 8747.476m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 122, new DateTime(2018, 10, 26, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 22, 36764.2697m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 139, new DateTime(2018, 11, 29, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 22, 15260.3396m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 151, new DateTime(2019, 1, 12, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 23, 30874.1045m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 194, new DateTime(2019, 4, 11, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 24, 30687.2340m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 155, new DateTime(2019, 2, 20, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 100, 17513.1775m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 41, new DateTime(2018, 11, 14, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 27, 93552.875m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 22, new DateTime(2018, 10, 12, 1, 24, 53, 680, DateTimeKind.Local).AddTicks(7966), 28, 1216.760m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 72, new DateTime(2018, 10, 2, 1, 24, 53, 681, DateTimeKind.Local).AddTicks(7967), 28, 99944.3586m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 150, new DateTime(2018, 10, 15, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 28, 26026.143m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 111, new DateTime(2018, 11, 3, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 29, 34652.2081m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 134, new DateTime(2018, 11, 6, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 29, 54135.3976m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 193, new DateTime(2019, 6, 2, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 29, 69987.1879m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 23, new DateTime(2019, 3, 11, 1, 24, 53, 680, DateTimeKind.Local).AddTicks(7966), 31, 29499.2779m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 160, new DateTime(2019, 2, 28, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 31, 77622.1026m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 168, new DateTime(2018, 12, 3, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 31, 66220.1958m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 80, new DateTime(2018, 10, 14, 1, 24, 53, 682, DateTimeKind.Local).AddTicks(7968), 32, 61729.1496m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 186, new DateTime(2019, 1, 26, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 27, 38988.2131m });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "Price" },
                values: new object[] { 188, new DateTime(2018, 10, 21, 1, 24, 53, 683, DateTimeKind.Local).AddTicks(7968), 100, 48917.3932m });

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
