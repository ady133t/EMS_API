using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEETEK_EMS_DB.Migrations
{
    public partial class thirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SNTracking",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SNName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SNID = table.Column<int>(type: "int", nullable: false),
                    RoutingMapID = table.Column<int>(type: "int", nullable: false),
                    RoutingMapStep = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SNTracking", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SNTracking_RoutingMap_RoutingMapStep",
                        column: x => x.RoutingMapStep,
                        principalTable: "RoutingMap",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SNTracking_SN_SNID",
                        column: x => x.SNID,
                        principalTable: "SN",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SNTracking_RoutingMapStep",
                table: "SNTracking",
                column: "RoutingMapStep");

            migrationBuilder.CreateIndex(
                name: "IX_SNTracking_SNID",
                table: "SNTracking",
                column: "SNID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SNTracking");
        }
    }
}
