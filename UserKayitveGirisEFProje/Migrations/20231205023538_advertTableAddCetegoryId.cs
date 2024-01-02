using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserKayitveGirisEFProje.Migrations
{
    /// <inheritdoc />
    public partial class advertTableAddCetegoryId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Adverts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Adverts");
        }
    }
}
