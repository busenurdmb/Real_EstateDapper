using Microsoft.AspNetCore.Mvc;
using Real_EstateDapper.Services.MovieService;
using System.Security.Claims;
using X.PagedList.Extensions;

namespace Real_EstateDapper.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Movie")]
    public class MovieController : Controller
	{
		private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [Route("Index")]
        public async Task<IActionResult> Index(int? page , string Title)
		{
          
            
          
             var movies = await _movieService.GetFilteredMovies(Title);
         
            int pageNumber = page ?? 1;
            var pagedList = movies.ToPagedList(pageNumber, 3);

            return View(pagedList);
		}
   
    }
}
