using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaCollection.Data.Migrations
{
    public partial class RemoveGuests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DropColumn(
                name: "GuestId",
                table: "PodcastAfleveringen");

            migrationBuilder.AddColumn<string>(
                name: "Guests",
                table: "PodcastAfleveringen",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Guests",
                table: "PodcastAfleveringen");

            migrationBuilder.AddColumn<int>(
                name: "GuestId",
                table: "PodcastAfleveringen",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naam = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.Id);
                });
        }
    }
}
