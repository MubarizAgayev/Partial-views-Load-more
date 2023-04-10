using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task.Migrations
{
    public partial class CreatePricingTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PricingHeaders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MyProperty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PricingHeaders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PricingPackets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacketPrice = table.Column<int>(type: "int", nullable: false),
                    PricingHeaderId = table.Column<int>(type: "int", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PricingPackets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PricingPackets_PricingHeaders_PricingHeaderId",
                        column: x => x.PricingHeaderId,
                        principalTable: "PricingHeaders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PricingOffers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OfferName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PricingPacketId = table.Column<int>(type: "int", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PricingOffers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PricingOffers_PricingPackets_PricingPacketId",
                        column: x => x.PricingPacketId,
                        principalTable: "PricingPackets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PricingOffers_PricingPacketId",
                table: "PricingOffers",
                column: "PricingPacketId");

            migrationBuilder.CreateIndex(
                name: "IX_PricingPackets_PricingHeaderId",
                table: "PricingPackets",
                column: "PricingHeaderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PricingOffers");

            migrationBuilder.DropTable(
                name: "PricingPackets");

            migrationBuilder.DropTable(
                name: "PricingHeaders");
        }
    }
}
