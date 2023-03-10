using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movie_E_commerce.Data;
using Movie_E_commerce.Models;

namespace Movie_E_commerce.Controllers
{
    public class ProducerController : Controller
    {
        private readonly AppDbContext _context;
        public ProducerController(AppDbContext context)
        {
            _context = context;  
        }
        public async Task<IActionResult> Index()
        {
            var allProducersList =await _context.Producers.ToListAsync();
            return View((List<Producer>)allProducersList);
        }
    }
}
