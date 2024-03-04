using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFGetStarted.Migrations
{
    /// <inheritdoc />
    public partial class initial_product : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categiries_CategiriesId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Categiries");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategiriesId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategiriesId",
                table: "Products");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategiriesId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categiries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categiries", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategiriesId",
                table: "Products",
                column: "CategiriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categiries_CategiriesId",
                table: "Products",
                column: "CategiriesId",
                principalTable: "Categiries",
                principalColumn: "Id");
        }
    }
}
