using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserKayitveGirisEFProje.Migrations
{
    /// <inheritdoc />
    public partial class advertTableAddImagePathField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Adverts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Adverts");
        }
    }
}
