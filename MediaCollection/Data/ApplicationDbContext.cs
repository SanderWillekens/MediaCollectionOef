using System;
using System.Collections.Generic;
using System.Text;
using MediaCollection.Domain.Film;
using MediaCollection.Domain.Muziek;
using MediaCollection.Domain.Podcast;
using MediaCollection.Domain.Serie;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MediaCollection.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        //Film Dbsets
        public DbSet<AfspeellijstFilm> AfspeellijstFilms { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<FilmAfspeellijst> FilmAfspeellijsten { get; set; }
        public DbSet<FilmFavorite> FilmFavoriten { get; set; }
        public DbSet<FilmGenre> FilmGenres { get; set; }
        public DbSet<FilmGezienStatus> FilmGezienStatuses { get; set; }
        public DbSet<FilmRegisseur> FilmRegisseurs { get; set; }
        public DbSet<FilmReview> FilmReviews { get; set; }
        public DbSet<GenreFilm> GenreFilms { get; set; }
        public DbSet<GezienStatus> GezienStatuses { get; set; }
        public DbSet<Regisseur> Regisseurs { get; set; }
        //Muziek Dbsets
        public DbSet<AfspeellijstNummer> AfspeellijstNummers { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artiest> Artiesten { get; set; }
        public DbSet<GeluisterdStatus> GeluisterdStatuses { get; set; }
        public DbSet<GenreNummer> GenreNummers { get; set; }
        public DbSet<Nummer> Nummers { get; set; }
        public DbSet<NummerAfspeellijst> NummerAfspeellijsten { get; set; }
        public DbSet<NummerAlbum> NummerAlbums { get; set; }
        public DbSet<NummerArtiest> NummerArtiesten { get; set; }
        public DbSet<NummerGeluisterdStatus> NummerGeluisterdStatuses { get; set; }
        public DbSet<NummerGenre> NummerGenres { get; set; }
        public DbSet<NummerReview> NummerReviews { get; set; }
        //Podcast Dbsets
        public DbSet<AfspeellijstPodcast> AfspeellijstPodcasts { get; set; }
        public DbSet<Auteur> Auteurs { get; set; }
        public DbSet<GehoordStatus> GehoordStatuses { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Podcast> Podcasts { get; set; }
        public DbSet<PodcastAflevering> PodcastAfleveringen { get; set; }
        public DbSet<PodcastAfspeellijst> PodcastAfspeellijsten { get; set; }
        public DbSet<PodcastFavorite> PodcastFavorites { get; set; }
        public DbSet<PodcastGehoordStatus> PodcastGehoordStatuses { get; set; }
        public DbSet<PodcastReview> PodcastReviews { get; set; }
        //Serie Dbsets
        public DbSet<BekekenStatus> BekekenStatuses { get; set; }
        public DbSet<AfspeellijstSerie> AfspeellijstSeries { get; set; }
        public DbSet<GenreSerie> GenreSeries { get; set; }
        public DbSet<RegisseurSerie> RegisseurSeries { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<SerieAflevering> SerieAfleveringen { get; set; }
        public DbSet<SerieAfspeellijst> SerieAfspeellijsten { get; set; }
        public DbSet<SerieBekekenStatus> SerieBekekenStatuses { get; set; }
        public DbSet<SerieFavorite> SerieFavorites { get; set; }
        public DbSet<SerieGenre> SerieGenres { get; set; }
        public DbSet<SerieRegisseur> SerieRegisseurs { get; set; }
        public DbSet<SerieReview> SerieReviews { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //FK Assignment
            //Films
            builder.Entity<FilmAfspeellijst>().HasKey(x => new { x.AfspeellijstId, x.UserId, x.FilmId });
            builder.Entity<FilmFavorite>().HasKey(f => new { f.UserId, f.FilmId });
            builder.Entity<FilmGenre>().HasKey(g => new { g.FilmId, g.GenreId });
            builder.Entity<FilmGezienStatus>().HasKey(s => new { s.FilmId, s.UserId });
            builder.Entity<FilmRegisseur>().HasKey(r => new { r.FilmId, r.RegisseurId });
            builder.Entity<FilmReview>().HasKey(y => new { y.FilmId, y.UserId });
            //Muziek
            builder.Entity<NummerAfspeellijst>().HasKey(a => new { a.AfspeellijstId, a.NummerId, a.UserId });
            builder.Entity<NummerAlbum>().HasKey(x => new { x.AlbumId, x.NummerId });
            builder.Entity<NummerArtiest>().HasKey(y => new { y.ArtiestId, y.NummerId });
            builder.Entity<NummerFavorite>().HasKey(f => new { f.NummerId, f.UserId });
            builder.Entity<NummerGeluisterdStatus>().HasKey(g => new { g.UserId, g.NummerId });
            builder.Entity<NummerGenre>().HasKey(z => new { z.GenreId, z.NummerId });
            builder.Entity<NummerReview>().HasKey(r => new { r.NummerId, r.UserId });
            //Podcast
            builder.Entity<PodcastAfspeellijst>().HasKey(a => new { a.AfspeellijstId, a.PodcastId, a.UserId });
            builder.Entity<PodcastFavorite>().HasKey(f => new { f.PodcastId, f.UserId });
            builder.Entity<PodcastGehoordStatus>().HasKey(g => new { g.UserId, g.PodcastId });
            builder.Entity<PodcastReview>().HasKey(r => new { r.PodcastAfleveringId, r.UserId });
            builder.Entity<PodcastAuteur>().HasKey(x => new { x.AuteurId, x.PodcastId });
            //Serie
            builder.Entity<SerieAfspeellijst>().HasKey(a => new { a.AfspeellijstId, a.SerieId, a.UserId });
            builder.Entity<SerieBekekenStatus>().HasKey(b => new { b.UserId, b.BekekenStatusId });
            builder.Entity<SerieFavorite>().HasKey(f => new { f.SerieId, f.UserId });
            builder.Entity<SerieGenre>().HasKey(g => new { g.SerieId, g.GenreId });
            builder.Entity<SerieRegisseur>().HasKey(r => new { r.RegisseurId, r.SerieId });
            builder.Entity<SerieReview>().HasKey(x => new { x.SerieId, x.UserId });
            //Data seeding
            //Film
            builder.Entity<GezienStatus>().HasData(
                new GezienStatus() { Status = "Nog niet gezien", Id = 1 },
                new GezienStatus() { Status = "Gezien",Id=2 },
                new GezienStatus() { Status = "Wil ik zien",Id=3 },
                new GezienStatus() { Status = "Wil ik niet zien",Id=4 }
            );
            builder.Entity<GenreFilm>().HasData(
                new GenreFilm() { Genrenaam = "Actie",Id=1 },
                new GenreFilm() { Genrenaam = "Avontuur",Id=2 },
                new GenreFilm() { Genrenaam = "Fantasy",Id=3 },
                new GenreFilm() { Genrenaam = "Thriller",Id=4 },
                new GenreFilm() { Genrenaam = "Horror",Id=5 },
                new GenreFilm() { Genrenaam = "Western",Id=6 },
                new GenreFilm() { Genrenaam = "Musical",Id=7 },
                new GenreFilm() { Genrenaam = "Drama",Id=8 },
                new GenreFilm() { Genrenaam = "Oorlog",Id=9 },
                new GenreFilm() { Genrenaam = "Romance",Id=10 },
                new GenreFilm() { Genrenaam = "Historisch",Id=11 }
                );
            //Muziek
            builder.Entity<GeluisterdStatus>().HasData(
                new GeluisterdStatus() { Status = "Nog niet geluisterd", Id = 1 },
                new GeluisterdStatus() { Status = "Al geluisterd" , Id = 2 },
                new GeluisterdStatus() { Status = "Wil ik luisteren" , Id = 3 },
                new GeluisterdStatus() { Status = "Wil ik niet luisteren", Id = 4 }
            );
            builder.Entity<GenreNummer>().HasData(
                new GenreNummer() { Naam="Pop",Id=1},
                new GenreNummer() { Naam = "Jazz", Id = 2 },
                new GenreNummer() { Naam = "Rock", Id = 3 },
                new GenreNummer() { Naam = "Metal", Id = 4 },
                new GenreNummer() { Naam = "Drum 'n bass", Id = 5 },
                new GenreNummer() { Naam = "Dubstep", Id = 6 },
                new GenreNummer() { Naam = "Dance", Id = 7 },
                new GenreNummer() { Naam = "Electronic", Id = 8 }
                );
            //Podcast
            builder.Entity<GehoordStatus>().HasData(
                new GehoordStatus() { Status = "Nog niet geluisterd", Id = 1 },
                new GehoordStatus() { Status = "Al geluisterd",Id=2 },
                new GehoordStatus() { Status = "Wil ik luisteren",Id=3 },
                new GehoordStatus() { Status = "Wil ik niet luisteren",Id=4 }
            );
            //Serie
            builder.Entity<BekekenStatus>().HasData(
                new BekekenStatus() { Status = "Nog niet gezien", Id = 1 },
                new BekekenStatus() { Status = "Gezien",Id=2 },
                new BekekenStatus() { Status = "Wil ik zien",Id=3 },
                new BekekenStatus() { Status = "Wil ik niet zien",Id=4 }
            );
            builder.Entity<GenreSerie>().HasData(
                new GenreSerie() { GenreNaam = "Actie",Id = 1 },
                new GenreSerie() { GenreNaam = "Avontuur", Id = 2 },
                new GenreSerie() { GenreNaam = "Fantasy", Id = 3 },
                new GenreSerie() { GenreNaam = "Thriller", Id = 4 },
                new GenreSerie() { GenreNaam = "Horror", Id = 5 },
                new GenreSerie() { GenreNaam = "Western", Id = 6 },
                new GenreSerie() { GenreNaam = "Musical", Id = 7 },
                new GenreSerie() { GenreNaam = "Drama", Id = 8 },
                new GenreSerie() { GenreNaam = "Oorlog", Id = 9 },
                new GenreSerie() { GenreNaam = "Romance", Id = 10 },
                new GenreSerie() { GenreNaam = "Historisch", Id = 11 }
                );
        }
    }
}
