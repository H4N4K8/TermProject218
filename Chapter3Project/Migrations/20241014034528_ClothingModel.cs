using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chapter3Project.Migrations
{
    /// <inheritdoc />
    public partial class ClothingModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClothingSet",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SmiskiType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClothingSet", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClothingSet");
        }
    }
}
