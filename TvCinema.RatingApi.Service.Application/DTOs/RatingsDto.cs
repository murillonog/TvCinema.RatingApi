namespace TvCinema.RatingApi.Service.Application.DTOs
{
    public class RatingsDto
    {
        public Guid Id { get; set; }
        public string? ImdbRating { get; set; }
        public string? TheMovieDb { get; set; }
        public string? RottenTomatoes { get; set; }
        public string? TV_com { get; set; }
        public string? FilmAffinity { get; set; }
        public string? Metascore { get; set; }
        public string? ImdbId { get; set; }
    }
}
