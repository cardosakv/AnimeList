using AnimeList.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AnimeList.Controllers
{
    public class StudiosController : Controller
    {
        private readonly AppDbContext _context;

        public StudiosController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _context.Studios.ToListAsync();
            return View(data);
        }
    }
}
