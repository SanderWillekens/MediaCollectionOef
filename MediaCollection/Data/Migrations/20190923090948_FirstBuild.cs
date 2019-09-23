using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaCollection.Data.Migrations
{
    public partial class FirstBuild : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AfspeellijstFilms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naam = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AfspeellijstFilms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AfspeellijstNummers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naam = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AfspeellijstNummers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AfspeellijstPodcasts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naam = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AfspeellijstPodcasts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AfspeellijstSeries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naam = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AfspeellijstSeries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naam = table.Column<string>(nullable: true),
                    AlbumFoto = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Artiesten",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naam = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artiesten", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Auteurs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naam = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auteurs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BekekenStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BekekenStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Titel = table.Column<string>(nullable: true),
                    Beschrijving = table.Column<string>(nullable: true),
                    Speelduur = table.Column<int>(nullable: false),
                    Foto = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GehoordStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GehoordStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeluisterdStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeluisterdStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GenreFilms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Genrenaam = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreFilms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GenreNummers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naam = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreNummers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GenreSeries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GenreNaam = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreSeries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GezienStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GezienStatuses", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Podcasts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Titel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Podcasts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regisseurs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naam = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regisseurs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegisseurSeries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naam = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisseurSeries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SerieAfspeellijsten",
                columns: table => new
                {
                    SerieId = table.Column<int>(nullable: false),
                    AfspeellijstId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerieAfspeellijsten", x => new { x.AfspeellijstId, x.SerieId, x.UserId });
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naam = table.Column<string>(nullable: true),
                    Foto = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nummers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naam = table.Column<string>(nullable: true),
                    Speeltijd = table.Column<int>(nullable: false),
                    AlbumId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nummers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nummers_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FilmAfspeellijsten",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    FilmId = table.Column<int>(nullable: false),
                    AfspeellijstId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmAfspeellijsten", x => new { x.AfspeellijstId, x.UserId, x.FilmId });
                    table.ForeignKey(
                        name: "FK_FilmAfspeellijsten_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmFavoriten",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    FilmId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmFavoriten", x => new { x.UserId, x.FilmId });
                    table.ForeignKey(
                        name: "FK_FilmFavoriten_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmGenres",
                columns: table => new
                {
                    FilmId = table.Column<int>(nullable: false),
                    GenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmGenres", x => new { x.FilmId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_FilmGenres_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmGezienStatuses",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    FilmId = table.Column<int>(nullable: false),
                    GezienStatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmGezienStatuses", x => new { x.FilmId, x.UserId });
                    table.ForeignKey(
                        name: "FK_FilmGezienStatuses_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmRegisseurs",
                columns: table => new
                {
                    RegisseurId = table.Column<int>(nullable: false),
                    FilmId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmRegisseurs", x => new { x.FilmId, x.RegisseurId });
                    table.ForeignKey(
                        name: "FK_FilmRegisseurs_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmReviews",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    FilmId = table.Column<int>(nullable: false),
                    ReviewTitel = table.Column<string>(nullable: true),
                    Score = table.Column<int>(nullable: false),
                    Review = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmReviews", x => new { x.FilmId, x.UserId });
                    table.ForeignKey(
                        name: "FK_FilmReviews_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PodcastAfleveringen",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PodcastId = table.Column<int>(nullable: false),
                    GuestId = table.Column<int>(nullable: false),
                    Titel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PodcastAfleveringen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PodcastAfleveringen_Podcasts_PodcastId",
                        column: x => x.PodcastId,
                        principalTable: "Podcasts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PodcastAfspeellijsten",
                columns: table => new
                {
                    PodcastId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    AfspeellijstId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PodcastAfspeellijsten", x => new { x.AfspeellijstId, x.PodcastId, x.UserId });
                    table.ForeignKey(
                        name: "FK_PodcastAfspeellijsten_Podcasts_PodcastId",
                        column: x => x.PodcastId,
                        principalTable: "Podcasts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PodcastAuteur",
                columns: table => new
                {
                    PodcastId = table.Column<int>(nullable: false),
                    AuteurId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PodcastAuteur", x => new { x.AuteurId, x.PodcastId });
                    table.ForeignKey(
                        name: "FK_PodcastAuteur_Podcasts_PodcastId",
                        column: x => x.PodcastId,
                        principalTable: "Podcasts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PodcastFavorites",
                columns: table => new
                {
                    PodcastId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PodcastFavorites", x => new { x.PodcastId, x.UserId });
                    table.ForeignKey(
                        name: "FK_PodcastFavorites_Podcasts_PodcastId",
                        column: x => x.PodcastId,
                        principalTable: "Podcasts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PodcastGehoordStatuses",
                columns: table => new
                {
                    PodcastId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    GehoordStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PodcastGehoordStatuses", x => new { x.UserId, x.PodcastId });
                    table.ForeignKey(
                        name: "FK_PodcastGehoordStatuses_Podcasts_PodcastId",
                        column: x => x.PodcastId,
                        principalTable: "Podcasts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PodcastReviews",
                columns: table => new
                {
                    PodcastAfleveringId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    Titel = table.Column<string>(nullable: true),
                    Score = table.Column<int>(nullable: false),
                    Review = table.Column<string>(nullable: true),
                    PodcastId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PodcastReviews", x => new { x.PodcastAfleveringId, x.UserId });
                    table.ForeignKey(
                        name: "FK_PodcastReviews_Podcasts_PodcastId",
                        column: x => x.PodcastId,
                        principalTable: "Podcasts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SerieAfleveringen",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SerieId = table.Column<int>(nullable: false),
                    Titel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerieAfleveringen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SerieAfleveringen_Series_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SerieBekekenStatuses",
                columns: table => new
                {
                    BekekenStatusId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    SerieId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerieBekekenStatuses", x => new { x.UserId, x.BekekenStatusId });
                    table.ForeignKey(
                        name: "FK_SerieBekekenStatuses_Series_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SerieFavorites",
                columns: table => new
                {
                    SerieId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerieFavorites", x => new { x.SerieId, x.UserId });
                    table.ForeignKey(
                        name: "FK_SerieFavorites_Series_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SerieGenres",
                columns: table => new
                {
                    GenreId = table.Column<int>(nullable: false),
                    SerieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerieGenres", x => new { x.SerieId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_SerieGenres_Series_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SerieRegisseurs",
                columns: table => new
                {
                    SerieId = table.Column<int>(nullable: false),
                    RegisseurId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerieRegisseurs", x => new { x.RegisseurId, x.SerieId });
                    table.ForeignKey(
                        name: "FK_SerieRegisseurs_Series_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SerieReviews",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    SerieId = table.Column<int>(nullable: false),
                    Titel = table.Column<string>(nullable: true),
                    Score = table.Column<int>(nullable: false),
                    Review = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerieReviews", x => new { x.SerieId, x.UserId });
                    table.ForeignKey(
                        name: "FK_SerieReviews_Series_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NummerAfspeellijsten",
                columns: table => new
                {
                    NummerId = table.Column<int>(nullable: false),
                    AfspeellijstId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NummerAfspeellijsten", x => new { x.AfspeellijstId, x.NummerId, x.UserId });
                    table.ForeignKey(
                        name: "FK_NummerAfspeellijsten_Nummers_NummerId",
                        column: x => x.NummerId,
                        principalTable: "Nummers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NummerAlbums",
                columns: table => new
                {
                    AlbumId = table.Column<int>(nullable: false),
                    NummerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NummerAlbums", x => new { x.AlbumId, x.NummerId });
                    table.ForeignKey(
                        name: "FK_NummerAlbums_Nummers_NummerId",
                        column: x => x.NummerId,
                        principalTable: "Nummers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NummerArtiesten",
                columns: table => new
                {
                    NummerId = table.Column<int>(nullable: false),
                    ArtiestId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NummerArtiesten", x => new { x.ArtiestId, x.NummerId });
                    table.ForeignKey(
                        name: "FK_NummerArtiesten_Nummers_NummerId",
                        column: x => x.NummerId,
                        principalTable: "Nummers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NummerFavorite",
                columns: table => new
                {
                    NummerId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NummerFavorite", x => new { x.NummerId, x.UserId });
                    table.ForeignKey(
                        name: "FK_NummerFavorite_Nummers_NummerId",
                        column: x => x.NummerId,
                        principalTable: "Nummers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NummerGeluisterdStatuses",
                columns: table => new
                {
                    NummerId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    GeluisterdId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NummerGeluisterdStatuses", x => new { x.UserId, x.NummerId });
                    table.ForeignKey(
                        name: "FK_NummerGeluisterdStatuses_Nummers_NummerId",
                        column: x => x.NummerId,
                        principalTable: "Nummers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NummerGenres",
                columns: table => new
                {
                    NummerId = table.Column<int>(nullable: false),
                    GenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NummerGenres", x => new { x.GenreId, x.NummerId });
                    table.ForeignKey(
                        name: "FK_NummerGenres_Nummers_NummerId",
                        column: x => x.NummerId,
                        principalTable: "Nummers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NummerReviews",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    NummerId = table.Column<int>(nullable: false),
                    Titel = table.Column<string>(nullable: true),
                    Score = table.Column<int>(nullable: false),
                    Review = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NummerReviews", x => new { x.NummerId, x.UserId });
                    table.ForeignKey(
                        name: "FK_NummerReviews_Nummers_NummerId",
                        column: x => x.NummerId,
                        principalTable: "Nummers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilmAfspeellijsten_FilmId",
                table: "FilmAfspeellijsten",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmFavoriten_FilmId",
                table: "FilmFavoriten",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_NummerAfspeellijsten_NummerId",
                table: "NummerAfspeellijsten",
                column: "NummerId");

            migrationBuilder.CreateIndex(
                name: "IX_NummerAlbums_NummerId",
                table: "NummerAlbums",
                column: "NummerId");

            migrationBuilder.CreateIndex(
                name: "IX_NummerArtiesten_NummerId",
                table: "NummerArtiesten",
                column: "NummerId");

            migrationBuilder.CreateIndex(
                name: "IX_NummerGeluisterdStatuses_NummerId",
                table: "NummerGeluisterdStatuses",
                column: "NummerId");

            migrationBuilder.CreateIndex(
                name: "IX_NummerGenres_NummerId",
                table: "NummerGenres",
                column: "NummerId");

            migrationBuilder.CreateIndex(
                name: "IX_Nummers_AlbumId",
                table: "Nummers",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_PodcastAfleveringen_PodcastId",
                table: "PodcastAfleveringen",
                column: "PodcastId");

            migrationBuilder.CreateIndex(
                name: "IX_PodcastAfspeellijsten_PodcastId",
                table: "PodcastAfspeellijsten",
                column: "PodcastId");

            migrationBuilder.CreateIndex(
                name: "IX_PodcastAuteur_PodcastId",
                table: "PodcastAuteur",
                column: "PodcastId");

            migrationBuilder.CreateIndex(
                name: "IX_PodcastGehoordStatuses_PodcastId",
                table: "PodcastGehoordStatuses",
                column: "PodcastId");

            migrationBuilder.CreateIndex(
                name: "IX_PodcastReviews_PodcastId",
                table: "PodcastReviews",
                column: "PodcastId");

            migrationBuilder.CreateIndex(
                name: "IX_SerieAfleveringen_SerieId",
                table: "SerieAfleveringen",
                column: "SerieId");

            migrationBuilder.CreateIndex(
                name: "IX_SerieBekekenStatuses_SerieId",
                table: "SerieBekekenStatuses",
                column: "SerieId");

            migrationBuilder.CreateIndex(
                name: "IX_SerieRegisseurs_SerieId",
                table: "SerieRegisseurs",
                column: "SerieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AfspeellijstFilms");

            migrationBuilder.DropTable(
                name: "AfspeellijstNummers");

            migrationBuilder.DropTable(
                name: "AfspeellijstPodcasts");

            migrationBuilder.DropTable(
                name: "AfspeellijstSeries");

            migrationBuilder.DropTable(
                name: "Artiesten");

            migrationBuilder.DropTable(
                name: "Auteurs");

            migrationBuilder.DropTable(
                name: "BekekenStatuses");

            migrationBuilder.DropTable(
                name: "FilmAfspeellijsten");

            migrationBuilder.DropTable(
                name: "FilmFavoriten");

            migrationBuilder.DropTable(
                name: "FilmGenres");

            migrationBuilder.DropTable(
                name: "FilmGezienStatuses");

            migrationBuilder.DropTable(
                name: "FilmRegisseurs");

            migrationBuilder.DropTable(
                name: "FilmReviews");

            migrationBuilder.DropTable(
                name: "GehoordStatuses");

            migrationBuilder.DropTable(
                name: "GeluisterdStatuses");

            migrationBuilder.DropTable(
                name: "GenreFilms");

            migrationBuilder.DropTable(
                name: "GenreNummers");

            migrationBuilder.DropTable(
                name: "GenreSeries");

            migrationBuilder.DropTable(
                name: "GezienStatuses");

            migrationBuilder.DropTable(
                name: "Guests");

            migrationBuilder.DropTable(
                name: "NummerAfspeellijsten");

            migrationBuilder.DropTable(
                name: "NummerAlbums");

            migrationBuilder.DropTable(
                name: "NummerArtiesten");

            migrationBuilder.DropTable(
                name: "NummerFavorite");

            migrationBuilder.DropTable(
                name: "NummerGeluisterdStatuses");

            migrationBuilder.DropTable(
                name: "NummerGenres");

            migrationBuilder.DropTable(
                name: "NummerReviews");

            migrationBuilder.DropTable(
                name: "PodcastAfleveringen");

            migrationBuilder.DropTable(
                name: "PodcastAfspeellijsten");

            migrationBuilder.DropTable(
                name: "PodcastAuteur");

            migrationBuilder.DropTable(
                name: "PodcastFavorites");

            migrationBuilder.DropTable(
                name: "PodcastGehoordStatuses");

            migrationBuilder.DropTable(
                name: "PodcastReviews");

            migrationBuilder.DropTable(
                name: "Regisseurs");

            migrationBuilder.DropTable(
                name: "RegisseurSeries");

            migrationBuilder.DropTable(
                name: "SerieAfleveringen");

            migrationBuilder.DropTable(
                name: "SerieAfspeellijsten");

            migrationBuilder.DropTable(
                name: "SerieBekekenStatuses");

            migrationBuilder.DropTable(
                name: "SerieFavorites");

            migrationBuilder.DropTable(
                name: "SerieGenres");

            migrationBuilder.DropTable(
                name: "SerieRegisseurs");

            migrationBuilder.DropTable(
                name: "SerieReviews");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "Nummers");

            migrationBuilder.DropTable(
                name: "Podcasts");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropTable(
                name: "Albums");
        }
    }
}
