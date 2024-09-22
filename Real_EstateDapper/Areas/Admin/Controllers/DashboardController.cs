using Microsoft.AspNetCore.Mvc;
using Real_EstateDapper.Services.MovieService;

namespace Real_EstateDapper.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Dashboard")]
    public class DashboardController : Controller
    {
        private readonly IMovieService _movieService;

        public DashboardController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var value=await _movieService.GetMovieStatisticsAsync();
            return View(value);
        }
    }
}
