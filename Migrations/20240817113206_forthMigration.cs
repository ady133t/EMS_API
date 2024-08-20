using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEETEK_EMS_DB.Migrations
{
    public partial class forthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SNTracking_RoutingMap_RoutingMapStep",
                table: "SNTracking");

            migrationBuilder.DropIndex(
                name: "IX_SNTracking_RoutingMapStep",
                table: "SNTracking");

            migrationBuilder.CreateIndex(
                name: "IX_SNTracking_RoutingMapID",
                table: "SNTracking",
                column: "RoutingMapID");

            migrationBuilder.AddForeignKey(
                name: "FK_SNTracking_RoutingMap_RoutingMapID",
                table: "SNTracking",
                column: "RoutingMapID",
                principalTable: "RoutingMap",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SNTracking_RoutingMap_RoutingMapID",
                table: "SNTracking");

            migrationBuilder.DropIndex(
                name: "IX_SNTracking_RoutingMapID",
                table: "SNTracking");

            migrationBuilder.CreateIndex(
                name: "IX_SNTracking_RoutingMapStep",
                table: "SNTracking",
                column: "RoutingMapStep");

            migrationBuilder.AddForeignKey(
                name: "FK_SNTracking_RoutingMap_RoutingMapStep",
                table: "SNTracking",
                column: "RoutingMapStep",
                principalTable: "RoutingMap",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
