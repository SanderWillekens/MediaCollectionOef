using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaCollection.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BekekenStatuses",
                columns: new[] { "Id", "Status" },
                values: new object[,]
                {
                    { 3, "Wil ik zien" },
                    { 1, "Nog niet gezien" },
                    { 2, "Gezien" },
                    { 4, "Wil ik niet zien" }
                });

            migrationBuilder.InsertData(
                table: "GehoordStatuses",
                columns: new[] { "Id", "Status" },
                values: new object[,]
                {
                    { 1, "Nog niet geluisterd" },
                    { 2, "Al geluisterd" },
                    { 3, "Wil ik luisteren" },
                    { 4, "Wil ik niet luisteren" }
                });

            migrationBuilder.InsertData(
                table: "GeluisterdStatuses",
                columns: new[] { "Id", "Status" },
                values: new object[,]
                {
                    { 4, "Wil ik niet luisteren" },
                    { 3, "Wil ik luisteren" },
                    { 2, "Al geluisterd" },
                    { 1, "Nog niet geluisterd" }
                });

            migrationBuilder.InsertData(
                table: "GenreFilms",
                columns: new[] { "Id", "Genrenaam" },
                values: new object[,]
                {
                    { 1, "Actie" },
                    { 11, "Historisch" },
                    { 10, "Romance" },
                    { 9, "Oorlog" },
                    { 8, "Drama" },
                    { 7, "Musical" },
                    { 6, "Western" },
                    { 5, "Horror" },
                    { 4, "Thriller" },
                    { 3, "Fantasy" },
                    { 2, "Avontuur" }
                });

            migrationBuilder.InsertData(
                table: "GenreNummers",
                columns: new[] { "Id", "Naam" },
                values: new object[,]
                {
                    { 8, "Electronic" },
                    { 7, "Dance" },
                    { 4, "Metal" },
                    { 5, "Drum 'n bass" },
                    { 3, "Rock" },
                    { 2, "Jazz" },
                    { 1, "Pop" },
                    { 6, "Dubstep" }
                });

            migrationBuilder.InsertData(
                table: "GenreSeries",
                columns: new[] { "Id", "GenreNaam" },
                values: new object[,]
                {
                    { 9, "Oorlog" },
                    { 8, "Drama" },
                    { 7, "Musical" },
                    { 6, "Western" },
                    { 5, "Horror" },
                    { 4, "Thriller" },
                    { 1, "Actie" },
                    { 2, "Avontuur" },
                    { 10, "Romance" },
                    { 3, "Fantasy" },
                    { 11, "Historisch" }
                });

            migrationBuilder.InsertData(
                table: "GezienStatuses",
                columns: new[] { "Id", "Status" },
                values: new object[,]
                {
                    { 1, "Nog niet gezien" },
                    { 2, "Gezien" },
                    { 3, "Wil ik zien" },
                    { 4, "Wil ik niet zien" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BekekenStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BekekenStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BekekenStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BekekenStatuses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GehoordStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GehoordStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GehoordStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GehoordStatuses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GeluisterdStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GeluisterdStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GeluisterdStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GeluisterdStatuses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GenreFilms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GenreFilms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GenreFilms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GenreFilms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GenreFilms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GenreFilms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GenreFilms",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "GenreFilms",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "GenreFilms",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "GenreFilms",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "GenreFilms",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "GenreNummers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GenreNummers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GenreNummers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GenreNummers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GenreNummers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GenreNummers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GenreNummers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "GenreNummers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "GenreSeries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GenreSeries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GenreSeries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GenreSeries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GenreSeries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GenreSeries",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GenreSeries",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "GenreSeries",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "GenreSeries",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "GenreSeries",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "GenreSeries",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "GezienStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GezienStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GezienStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GezienStatuses",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
