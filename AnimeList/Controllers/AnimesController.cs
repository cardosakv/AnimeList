using AnimeList.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AnimeList.Controllers
{
    public class AnimesController : Controller
    {
        private readonly AppDbContext _context;

        public AnimesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _context.Animes.Include(a => a.Studio).ToListAsync();
            return View(data);
        }
    }
}
