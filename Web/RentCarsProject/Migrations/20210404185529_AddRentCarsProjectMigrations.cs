using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace RentCarsProject.Migrations
{
    public partial class AddRentCarsProjectMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bonussystem",
                columns: table => new
                {
                    IDbonussystem = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Discountpercent = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bonussystem", x => x.IDbonussystem);
                });

            migrationBuilder.CreateTable(
                name: "locationcar",
                columns: table => new
                {
                    IDlocationcar = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Address = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Terrain = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_locationcar", x => x.IDlocationcar);
                });

            migrationBuilder.CreateTable(
                name: "client",
                columns: table => new
                {
                    IDclient = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Login = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Familyname = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Patronymic = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Passportdata = table.Column<int>(type: "integer", nullable: false),
                    Driverslicense = table.Column<int>(type: "integer", nullable: false),
                    Numberofphone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    IDbonussystem = table.Column<int>(type: "integer", nullable: false),
                    bonussystemIDbonussystem = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client", x => x.IDclient);
                    table.ForeignKey(
                        name: "FK_client_bonussystem_bonussystemIDbonussystem",
                        column: x => x.bonussystemIDbonussystem,
                        principalTable: "bonussystem",
                        principalColumn: "IDbonussystem",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "car",
                columns: table => new
                {
                    IDCar = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VINnumber = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Brand = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ClassCar = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Transmission = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    Color = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    Yearofmanufacture = table.Column<short>(type: "smallint", nullable: false),
                    IDlocationcar = table.Column<int>(type: "integer", nullable: false),
                    locationcarIDlocationcar = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_car", x => x.IDCar);
                    table.ForeignKey(
                        name: "FK_car_locationcar_locationcarIDlocationcar",
                        column: x => x.locationcarIDlocationcar,
                        principalTable: "locationcar",
                        principalColumn: "IDlocationcar",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "fine",
                columns: table => new
                {
                    IDfine = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "character varying(70)", maxLength: 70, nullable: false),
                    Cost = table.Column<decimal>(type: "numeric", nullable: false),
                    Datefine = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Status = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    IDclient = table.Column<int>(type: "integer", nullable: false),
                    clientIDclient = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fine", x => x.IDfine);
                    table.ForeignKey(
                        name: "FK_fine_client_clientIDclient",
                        column: x => x.clientIDclient,
                        principalTable: "client",
                        principalColumn: "IDclient",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "rate",
                columns: table => new
                {
                    IDrate = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Cost = table.Column<decimal>(type: "numeric", nullable: false),
                    IDcar = table.Column<int>(type: "integer", nullable: false),
                    carIDCar = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rate", x => x.IDrate);
                    table.ForeignKey(
                        name: "FK_rate_car_carIDCar",
                        column: x => x.carIDCar,
                        principalTable: "car",
                        principalColumn: "IDCar",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "returncar",
                columns: table => new
                {
                    IDreturncar = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Condition = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Returndate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IDcar = table.Column<int>(type: "integer", nullable: false),
                    carIDCar = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_returncar", x => x.IDreturncar);
                    table.ForeignKey(
                        name: "FK_returncar_car_carIDCar",
                        column: x => x.carIDCar,
                        principalTable: "car",
                        principalColumn: "IDCar",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "rentcar",
                columns: table => new
                {
                    IDrentcar = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Countdaysrent = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Cost = table.Column<decimal>(type: "numeric", nullable: false),
                    Dateofissue = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IDcar = table.Column<int>(type: "integer", nullable: false),
                    IDclient = table.Column<int>(type: "integer", nullable: false),
                    IDrate = table.Column<int>(type: "integer", nullable: false),
                    carIDCar = table.Column<int>(type: "integer", nullable: true),
                    clientIDclient = table.Column<int>(type: "integer", nullable: true),
                    rateIDrate = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rentcar", x => x.IDrentcar);
                    table.ForeignKey(
                        name: "FK_rentcar_car_carIDCar",
                        column: x => x.carIDCar,
                        principalTable: "car",
                        principalColumn: "IDCar",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_rentcar_client_clientIDclient",
                        column: x => x.clientIDclient,
                        principalTable: "client",
                        principalColumn: "IDclient",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_rentcar_rate_rateIDrate",
                        column: x => x.rateIDrate,
                        principalTable: "rate",
                        principalColumn: "IDrate",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_car_locationcarIDlocationcar",
                table: "car",
                column: "locationcarIDlocationcar");

            migrationBuilder.CreateIndex(
                name: "IX_client_bonussystemIDbonussystem",
                table: "client",
                column: "bonussystemIDbonussystem");

            migrationBuilder.CreateIndex(
                name: "IX_fine_clientIDclient",
                table: "fine",
                column: "clientIDclient");

            migrationBuilder.CreateIndex(
                name: "IX_rate_carIDCar",
                table: "rate",
                column: "carIDCar");

            migrationBuilder.CreateIndex(
                name: "IX_rentcar_carIDCar",
                table: "rentcar",
                column: "carIDCar");

            migrationBuilder.CreateIndex(
                name: "IX_rentcar_clientIDclient",
                table: "rentcar",
                column: "clientIDclient");

            migrationBuilder.CreateIndex(
                name: "IX_rentcar_rateIDrate",
                table: "rentcar",
                column: "rateIDrate");

            migrationBuilder.CreateIndex(
                name: "IX_returncar_carIDCar",
                table: "returncar",
                column: "carIDCar");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "fine");

            migrationBuilder.DropTable(
                name: "rentcar");

            migrationBuilder.DropTable(
                name: "returncar");

            migrationBuilder.DropTable(
                name: "client");

            migrationBuilder.DropTable(
                name: "rate");

            migrationBuilder.DropTable(
                name: "bonussystem");

            migrationBuilder.DropTable(
                name: "car");

            migrationBuilder.DropTable(
                name: "locationcar");
        }
    }
}
