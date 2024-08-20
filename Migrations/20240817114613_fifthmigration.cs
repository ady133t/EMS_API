using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEETEK_EMS_DB.Migrations
{
    public partial class fifthmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductionOrder_RoutingMap_RoutingMapID",
                table: "ProductionOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_RoutingMap_Operations_OperationID",
                table: "RoutingMap");

            migrationBuilder.DropForeignKey(
                name: "FK_RoutingMap_ResourceGroups_ResourceGroupID",
                table: "RoutingMap");

            migrationBuilder.DropForeignKey(
                name: "FK_RoutingMap_Stations_StationID",
                table: "RoutingMap");

            migrationBuilder.DropForeignKey(
                name: "FK_SN_ProductionOrder_ProductionOrderID",
                table: "SN");

            migrationBuilder.DropForeignKey(
                name: "FK_SNTracking_RoutingMap_RoutingMapID",
                table: "SNTracking");

            migrationBuilder.DropForeignKey(
                name: "FK_SNTracking_SN_SNID",
                table: "SNTracking");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SNTracking",
                table: "SNTracking");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SN",
                table: "SN");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoutingMap",
                table: "RoutingMap");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductionOrder",
                table: "ProductionOrder");

            migrationBuilder.RenameTable(
                name: "SNTracking",
                newName: "SNTrackings");

            migrationBuilder.RenameTable(
                name: "SN",
                newName: "SNs");

            migrationBuilder.RenameTable(
                name: "RoutingMap",
                newName: "RoutingMaps");

            migrationBuilder.RenameTable(
                name: "ProductionOrder",
                newName: "ProductionOrders");

            migrationBuilder.RenameIndex(
                name: "IX_SNTracking_SNID",
                table: "SNTrackings",
                newName: "IX_SNTrackings_SNID");

            migrationBuilder.RenameIndex(
                name: "IX_SNTracking_RoutingMapID",
                table: "SNTrackings",
                newName: "IX_SNTrackings_RoutingMapID");

            migrationBuilder.RenameIndex(
                name: "IX_SN_ProductionOrderID",
                table: "SNs",
                newName: "IX_SNs_ProductionOrderID");

            migrationBuilder.RenameIndex(
                name: "IX_RoutingMap_StationID",
                table: "RoutingMaps",
                newName: "IX_RoutingMaps_StationID");

            migrationBuilder.RenameIndex(
                name: "IX_RoutingMap_ResourceGroupID",
                table: "RoutingMaps",
                newName: "IX_RoutingMaps_ResourceGroupID");

            migrationBuilder.RenameIndex(
                name: "IX_RoutingMap_OperationID",
                table: "RoutingMaps",
                newName: "IX_RoutingMaps_OperationID");

            migrationBuilder.RenameIndex(
                name: "IX_ProductionOrder_RoutingMapID",
                table: "ProductionOrders",
                newName: "IX_ProductionOrders_RoutingMapID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SNTrackings",
                table: "SNTrackings",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SNs",
                table: "SNs",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoutingMaps",
                table: "RoutingMaps",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductionOrders",
                table: "ProductionOrders",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionOrders_RoutingMaps_RoutingMapID",
                table: "ProductionOrders",
                column: "RoutingMapID",
                principalTable: "RoutingMaps",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoutingMaps_Operations_OperationID",
                table: "RoutingMaps",
                column: "OperationID",
                principalTable: "Operations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoutingMaps_ResourceGroups_ResourceGroupID",
                table: "RoutingMaps",
                column: "ResourceGroupID",
                principalTable: "ResourceGroups",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoutingMaps_Stations_StationID",
                table: "RoutingMaps",
                column: "StationID",
                principalTable: "Stations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SNs_ProductionOrders_ProductionOrderID",
                table: "SNs",
                column: "ProductionOrderID",
                principalTable: "ProductionOrders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SNTrackings_RoutingMaps_RoutingMapID",
                table: "SNTrackings",
                column: "RoutingMapID",
                principalTable: "RoutingMaps",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SNTrackings_SNs_SNID",
                table: "SNTrackings",
                column: "SNID",
                principalTable: "SNs",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductionOrders_RoutingMaps_RoutingMapID",
                table: "ProductionOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_RoutingMaps_Operations_OperationID",
                table: "RoutingMaps");

            migrationBuilder.DropForeignKey(
                name: "FK_RoutingMaps_ResourceGroups_ResourceGroupID",
                table: "RoutingMaps");

            migrationBuilder.DropForeignKey(
                name: "FK_RoutingMaps_Stations_StationID",
                table: "RoutingMaps");

            migrationBuilder.DropForeignKey(
                name: "FK_SNs_ProductionOrders_ProductionOrderID",
                table: "SNs");

            migrationBuilder.DropForeignKey(
                name: "FK_SNTrackings_RoutingMaps_RoutingMapID",
                table: "SNTrackings");

            migrationBuilder.DropForeignKey(
                name: "FK_SNTrackings_SNs_SNID",
                table: "SNTrackings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SNTrackings",
                table: "SNTrackings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SNs",
                table: "SNs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoutingMaps",
                table: "RoutingMaps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductionOrders",
                table: "ProductionOrders");

            migrationBuilder.RenameTable(
                name: "SNTrackings",
                newName: "SNTracking");

            migrationBuilder.RenameTable(
                name: "SNs",
                newName: "SN");

            migrationBuilder.RenameTable(
                name: "RoutingMaps",
                newName: "RoutingMap");

            migrationBuilder.RenameTable(
                name: "ProductionOrders",
                newName: "ProductionOrder");

            migrationBuilder.RenameIndex(
                name: "IX_SNTrackings_SNID",
                table: "SNTracking",
                newName: "IX_SNTracking_SNID");

            migrationBuilder.RenameIndex(
                name: "IX_SNTrackings_RoutingMapID",
                table: "SNTracking",
                newName: "IX_SNTracking_RoutingMapID");

            migrationBuilder.RenameIndex(
                name: "IX_SNs_ProductionOrderID",
                table: "SN",
                newName: "IX_SN_ProductionOrderID");

            migrationBuilder.RenameIndex(
                name: "IX_RoutingMaps_StationID",
                table: "RoutingMap",
                newName: "IX_RoutingMap_StationID");

            migrationBuilder.RenameIndex(
                name: "IX_RoutingMaps_ResourceGroupID",
                table: "RoutingMap",
                newName: "IX_RoutingMap_ResourceGroupID");

            migrationBuilder.RenameIndex(
                name: "IX_RoutingMaps_OperationID",
                table: "RoutingMap",
                newName: "IX_RoutingMap_OperationID");

            migrationBuilder.RenameIndex(
                name: "IX_ProductionOrders_RoutingMapID",
                table: "ProductionOrder",
                newName: "IX_ProductionOrder_RoutingMapID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SNTracking",
                table: "SNTracking",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SN",
                table: "SN",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoutingMap",
                table: "RoutingMap",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductionOrder",
                table: "ProductionOrder",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionOrder_RoutingMap_RoutingMapID",
                table: "ProductionOrder",
                column: "RoutingMapID",
                principalTable: "RoutingMap",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoutingMap_Operations_OperationID",
                table: "RoutingMap",
                column: "OperationID",
                principalTable: "Operations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoutingMap_ResourceGroups_ResourceGroupID",
                table: "RoutingMap",
                column: "ResourceGroupID",
                principalTable: "ResourceGroups",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoutingMap_Stations_StationID",
                table: "RoutingMap",
                column: "StationID",
                principalTable: "Stations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SN_ProductionOrder_ProductionOrderID",
                table: "SN",
                column: "ProductionOrderID",
                principalTable: "ProductionOrder",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SNTracking_RoutingMap_RoutingMapID",
                table: "SNTracking",
                column: "RoutingMapID",
                principalTable: "RoutingMap",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SNTracking_SN_SNID",
                table: "SNTracking",
                column: "SNID",
                principalTable: "SN",
                principalColumn: "ID");
        }
    }
}
