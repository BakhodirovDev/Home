using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConstructionMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductType = table.Column<string>(type: "text", nullable: false),
                    MaterialType = table.Column<string>(type: "text", nullable: false),
                    SizeType = table.Column<string>(type: "text", nullable: false),
                    Thickness = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    MoneyType = table.Column<string>(type: "text", nullable: false),
                    PhotoPath = table.Column<string>(type: "text", nullable: false),
                    AddressDistrict = table.Column<int>(type: "integer", nullable: false),
                    AddressProvince = table.Column<int>(type: "integer", nullable: false),
                    InformationUniversal = table.Column<string>(type: "text", nullable: false),
                    PhoneNumbers = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConstructionMaterials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeAppliances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HomeApplianceType = table.Column<string>(type: "text", nullable: false),
                    BrendType = table.Column<string>(type: "text", nullable: false),
                    NumberOfProduct = table.Column<string>(type: "text", nullable: false),
                    IssueDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    MoneyType = table.Column<string>(type: "text", nullable: false),
                    PhotoPath = table.Column<string>(type: "text", nullable: false),
                    AddressDistrict = table.Column<int>(type: "integer", nullable: false),
                    AddressProvince = table.Column<int>(type: "integer", nullable: false),
                    InformationUniversal = table.Column<string>(type: "text", nullable: false),
                    PhoneNumbers = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeAppliances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeBuilds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FormatType = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    MoneyType = table.Column<string>(type: "text", nullable: false),
                    PhotoPath = table.Column<string>(type: "text", nullable: false),
                    TheEmployerAndEmployee = table.Column<string>(type: "text", nullable: false),
                    ServiceType = table.Column<string>(type: "text", nullable: false),
                    AddressDistrict = table.Column<int>(type: "integer", nullable: false),
                    AddressProvince = table.Column<int>(type: "integer", nullable: false),
                    InformationUniversal = table.Column<string>(type: "text", nullable: false),
                    PhoneNumbers = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeBuilds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeEquipment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Equipments = table.Column<string>(type: "text", nullable: false),
                    EquipmentType = table.Column<string>(type: "text", nullable: false),
                    NumberOfProduct = table.Column<string>(type: "text", nullable: false),
                    RawMaterialType = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    MoneyType = table.Column<string>(type: "text", nullable: false),
                    PhotoPath = table.Column<string>(type: "text", nullable: false),
                    AddressDistrict = table.Column<int>(type: "integer", nullable: false),
                    AddressProvince = table.Column<int>(type: "integer", nullable: false),
                    InformationUniversal = table.Column<string>(type: "text", nullable: false),
                    PhoneNumbers = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeEquipment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeRents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HomeOwner = table.Column<bool>(type: "boolean", nullable: false),
                    DayMonth = table.Column<string>(type: "text", nullable: false),
                    UserType = table.Column<string>(type: "text", nullable: false),
                    Arena = table.Column<double>(type: "double precision", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    MoneyType = table.Column<string>(type: "text", nullable: false),
                    PhotoPath = table.Column<string>(type: "text", nullable: false),
                    NumberOfRoom = table.Column<int>(type: "integer", nullable: false),
                    AddressDistrict = table.Column<int>(type: "integer", nullable: false),
                    AddressProvince = table.Column<int>(type: "integer", nullable: false),
                    InformationUniversal = table.Column<string>(type: "text", nullable: false),
                    PhoneNumbers = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeRents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomeRepairs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SizeType = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    MoneyType = table.Column<string>(type: "text", nullable: false),
                    PhotoPath = table.Column<string>(type: "text", nullable: false),
                    TheEmployerAndEmployee = table.Column<string>(type: "text", nullable: false),
                    ServiceType = table.Column<string>(type: "text", nullable: false),
                    AddressDistrict = table.Column<int>(type: "integer", nullable: false),
                    AddressProvince = table.Column<int>(type: "integer", nullable: false),
                    InformationUniversal = table.Column<string>(type: "text", nullable: false),
                    PhoneNumbers = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeRepairs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Homes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Discription = table.Column<string>(type: "text", nullable: false),
                    YearBuilt = table.Column<int>(type: "integer", nullable: false),
                    HomeType = table.Column<string>(type: "text", nullable: false),
                    Arena = table.Column<double>(type: "double precision", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    MoneyType = table.Column<string>(type: "text", nullable: false),
                    PhotoPath = table.Column<string>(type: "text", nullable: false),
                    NumberOfRoom = table.Column<int>(type: "integer", nullable: false),
                    AddressDistrict = table.Column<int>(type: "integer", nullable: false),
                    AddressProvince = table.Column<int>(type: "integer", nullable: false),
                    InformationUniversal = table.Column<string>(type: "text", nullable: false),
                    PhoneNumbers = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Homes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DayMonth = table.Column<string>(type: "text", nullable: false),
                    RoomType = table.Column<string>(type: "text", nullable: false),
                    UserType = table.Column<string>(type: "text", nullable: false),
                    Arena = table.Column<double>(type: "double precision", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    MoneyType = table.Column<string>(type: "text", nullable: false),
                    PhotoPath = table.Column<string>(type: "text", nullable: false),
                    NumberOfRoom = table.Column<int>(type: "integer", nullable: false),
                    AddressDistrict = table.Column<int>(type: "integer", nullable: false),
                    AddressProvince = table.Column<int>(type: "integer", nullable: false),
                    InformationUniversal = table.Column<string>(type: "text", nullable: false),
                    PhoneNumbers = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TechnicalServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TimeType = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    MoneyType = table.Column<string>(type: "text", nullable: false),
                    PhotoPath = table.Column<string>(type: "text", nullable: false),
                    TheEmployerAndEmployee = table.Column<string>(type: "text", nullable: false),
                    ServiceType = table.Column<string>(type: "text", nullable: false),
                    AddressDistrict = table.Column<int>(type: "integer", nullable: false),
                    AddressProvince = table.Column<int>(type: "integer", nullable: false),
                    InformationUniversal = table.Column<string>(type: "text", nullable: false),
                    PhoneNumbers = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechnicalServices", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConstructionMaterials");

            migrationBuilder.DropTable(
                name: "HomeAppliances");

            migrationBuilder.DropTable(
                name: "HomeBuilds");

            migrationBuilder.DropTable(
                name: "HomeEquipment");

            migrationBuilder.DropTable(
                name: "HomeRents");

            migrationBuilder.DropTable(
                name: "HomeRepairs");

            migrationBuilder.DropTable(
                name: "Homes");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "TechnicalServices");
        }
    }
}
