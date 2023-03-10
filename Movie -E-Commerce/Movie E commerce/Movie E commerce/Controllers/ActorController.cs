using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movie_E_commerce.Data;

namespace Movie_E_commerce.Controllers
{
    public class ActorController : Controller
    {
        private readonly AppDbContext _context;
        public ActorController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var actorLists =  _context.Actors.ToList();
            return View(actorLists);
        }

    }
}
