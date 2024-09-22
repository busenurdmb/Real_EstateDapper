using Real_EstateDapper.Dto.MovieDto;
using Real_EstateDapper.Dto.PropertyDtos;

namespace Real_EstateDapper.Services.MovieService
{
	public interface IMovieService
	{
		Task<List<ResultMovieDto>> GetAllMovieAsync();
		Task<List<ResultMovieDto>> GetFilteredMovies(string Title);
        Task<ResultMovieDto> GetByIdMovieAsync(int id);

		Task<MovieStatisticsDto> GetMovieStatisticsAsync();

    }
}
