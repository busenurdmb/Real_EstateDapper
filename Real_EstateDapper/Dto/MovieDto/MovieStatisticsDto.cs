namespace Real_EstateDapper.Dto.MovieDto
{
    public class MovieStatisticsDto
    {
        public int TotalMovies { get; set; }
        public float AverageRating { get; set; }
        public float HighestRating { get; set; }
        public float LowestRating { get; set; }
        public int TotalDirectors { get; set; }
        public int TotalWriters { get; set; }
        public int TotalStars { get; set; }
        public int TotalGenres { get; set; }
        public int MoviesReleasedThisYear { get; set; }
        public float AverageLength { get; set; }
        public int MoviesAboveRating { get; set; }
        public int MoviesBelowRating { get; set; }
        public float AverageReleaseYear { get; set; }
        public int MoviesWithPlot { get; set; }
        public int MoviesWithPoster { get; set; }
        public int MoviesWithStarCount { get; set; }
        public int MoviesByGenre { get; set; }
    }
}
