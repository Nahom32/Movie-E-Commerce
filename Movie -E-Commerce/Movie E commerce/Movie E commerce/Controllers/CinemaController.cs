using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movie_E_commerce.Data;
namespace Movie_E_commerce.Controllers
{
    public class CinemaController : Controller
    {
        private readonly AppDbContext _context; 
        public CinemaController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allCinemaList = await _context.Cinemas.ToListAsync();

            return View();
        }
    }
}
