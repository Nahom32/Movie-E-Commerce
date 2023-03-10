using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movie_E_commerce.Data;

namespace Movie_E_commerce.Controllers
{
    public class MovieController : Controller
    {
        private readonly AppDbContext _context;
        public MovieController(AppDbContext context)
        {
            _context = context;

        }
        public async Task<IActionResult> Index()
        {
            var allMoviesList = await _context.Movies.OrderBy(n=>n.Name).Include(n => n.Cinema).ToListAsync();
            return View(allMoviesList);
        }
    }
}
