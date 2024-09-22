using Dapper;
using Real_EstateDapper.Context;
using Real_EstateDapper.Dto.CategoryDtos;
using Real_EstateDapper.Dto.MovieDto;
using Real_EstateDapper.Dto.PropertyDtos;
using Real_EstateDapper.Services.PropertyService;

namespace Real_EstateDapper.Services.MovieService
{
	public class MovieService : IMovieService
	{
		private readonly Real_EstateDapperContext _context;

		public MovieService(Real_EstateDapperContext context)
		{
			_context = context;
		}

		public async Task<List<ResultMovieDto>> GetAllMovieAsync()
		{
			const string query = "SELECT * FROM movies";

			using var connection = _context.CreateConnection();
			var properties = await connection.QueryAsync<ResultMovieDto>(query);
			return properties.ToList();
		}

	
		public async Task<List<ResultMovieDto>> GetFilteredMovies(string Title)
		{
			// Başlangıç sorgusu
			var query = "SELECT * FROM movies WHERE 1=1";

			// Sorgu parametreleri
			var parameters = new DynamicParameters();

		

			// Şehir filtresi
			if (!string.IsNullOrEmpty(Title))
			{
				query += " AND Title = @Title";
				parameters.Add("@Title", Title);
			}

			// Veritabanı bağlantısını oluştur
			using var connection = _context.CreateConnection();

			// Sorguyu çalıştır ve sonuçları al
			var properties = await connection.QueryAsync<ResultMovieDto>(query, parameters);

			// Listeye dönüştür ve döndür
			return properties.ToList();
		}
        public async Task<ResultMovieDto> GetByIdMovieAsync(int id)
        {
            string query = "select * from movies Where Id=@Id";
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id);
            var x = _context.CreateConnection();
            var values = await x.QueryFirstOrDefaultAsync<ResultMovieDto>(query, parameters);
            return values;
        }
        public async Task<MovieStatisticsDto> GetMovieStatisticsAsync()
        {
            var stats = new MovieStatisticsDto();

            using var connection = _context.CreateConnection();

            // 1. Toplam Film Sayısı
            stats.TotalMovies = await connection.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM movies");

            // 2. Ortalama IMDB Puanı
            stats.AverageRating = await connection.ExecuteScalarAsync<float>("SELECT AVG(IMDB_Rating) FROM movies");

            // 3. En Yüksek IMDB Puanı
            stats.HighestRating = await connection.ExecuteScalarAsync<float>("SELECT MAX(IMDB_Rating) FROM movies");

            // 4. En Düşük IMDB Puanı
            stats.LowestRating = await connection.ExecuteScalarAsync<float>("SELECT MIN(IMDB_Rating) FROM movies");

            // 5. Toplam Yönetmen Sayısı
            stats.TotalDirectors = await connection.ExecuteScalarAsync<int>("SELECT COUNT(DISTINCT Directors) FROM movies");

            // 6. Toplam Senarist Sayısı
            stats.TotalWriters = await connection.ExecuteScalarAsync<int>("SELECT COUNT(DISTINCT Writers) FROM movies");

            // 7. Toplam Yıldız Sayısı
            stats.TotalStars = await connection.ExecuteScalarAsync<int>("SELECT COUNT(DISTINCT Stars) FROM movies");

            // 8. Toplam Tür Sayısı
            stats.TotalGenres = await connection.ExecuteScalarAsync<int>("SELECT COUNT(DISTINCT Genres) FROM movies");

            // 9. Bu Yılda Çıkan Film Sayısı 2023'te
            stats.MoviesReleasedThisYear = await connection.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM movies WHERE YEAR(Release_Year) = YEAR(20230)");

            // 10. Ortalama Film Süresi
            stats.AverageLength = await connection.ExecuteScalarAsync<float>("SELECT AVG(Length_in_Min) FROM movies");

            // 11. Belirli bir puanın üzerindeki film sayısı
            stats.MoviesAboveRating = await connection.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM movies WHERE IMDB_Rating > @Rating", new { Rating = 7.0f }); // Örnek puan

            // 12. Belirli bir puanın altındaki film sayısı
            stats.MoviesBelowRating = await connection.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM movies WHERE IMDB_Rating < @Rating", new { Rating = 4.0f }); // Örnek puan

            // 13. Ortalama Yayın Yılı
            stats.AverageReleaseYear = await connection.ExecuteScalarAsync<float>("SELECT AVG(Release_Year) FROM movies");

            // 14. Özeti Olan Film Sayısı
            stats.MoviesWithPlot = await connection.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM movies WHERE Plot IS NOT NULL AND Plot <> ''");

            // 15. Poster Olan Film Sayısı
            stats.MoviesWithPoster = await connection.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM movies WHERE Poster IS NOT NULL AND Poster <> ''");

            // 16. Yıldız Sayısı Olan Film Sayısı
            stats.MoviesWithStarCount = await connection.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM movies WHERE Stars IS NOT NULL AND Stars <> ''");

            // 17. Belirli bir türdeki film sayısı (örnek tür)
            stats.MoviesByGenre = await connection.ExecuteScalarAsync<int>("SELECT COUNT(*) FROM movies WHERE Genres LIKE @Genre", new { Genre = "%Action%" }); // Örnek tür

            return stats;
        }

    }
}
