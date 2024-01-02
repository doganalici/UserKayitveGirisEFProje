using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserKayitveGirisEFProje.Migrations
{
    /// <inheritdoc />
    public partial class advertCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adverts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Renk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yil = table.Column<int>(type: "int", nullable: false),
                    Vites = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YakitTuru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kilometre = table.Column<double>(type: "float", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adverts", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adverts");
        }
    }
}
