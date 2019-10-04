using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaCollection.Data.Migrations
{
    public partial class HostToPodcast : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nummers_Albums_AlbumId",
                table: "Nummers");

            migrationBuilder.DropIndex(
                name: "IX_Nummers_AlbumId",
                table: "Nummers");

            migrationBuilder.DropColumn(
                name: "AlbumId",
                table: "Nummers");

            migrationBuilder.AddColumn<string>(
                name: "Host",
                table: "Podcasts",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_NummerAlbums_Albums_AlbumId",
                table: "NummerAlbums",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NummerAlbums_Albums_AlbumId",
                table: "NummerAlbums");

            migrationBuilder.DropColumn(
                name: "Host",
                table: "Podcasts");

            migrationBuilder.AddColumn<int>(
                name: "AlbumId",
                table: "Nummers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nummers_AlbumId",
                table: "Nummers",
                column: "AlbumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Nummers_Albums_AlbumId",
                table: "Nummers",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
