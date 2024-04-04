using AnimeList.Data.Services;
using AnimeList.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnimeList.Controllers
{
    public class VoiceActorsController : Controller
    {
        private readonly IVoiceActorsService _service;

        public VoiceActorsController(IVoiceActorsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(VoiceActor voiceActor)
        {
            if (ModelState.IsValid)
            {
                await _service.AddAsync(voiceActor);
                return RedirectToAction(nameof(Index));
            }

            return View(voiceActor);
        }

        public async Task<IActionResult> Details(int id)
        {
            var voiceActor = await _service.GetByIdAsync(id);

            if (voiceActor is null)
            {
                return View(nameof(NotFound));
            }

            return View(voiceActor);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var voiceActor = await _service.GetByIdAsync(id);
            return View(voiceActor);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(VoiceActor voiceActor)
        {
            if (ModelState.IsValid)
            {
                await _service.UpdateAsync(voiceActor);
                return RedirectToAction(nameof(Details), new { id = voiceActor.Id });
            }

            return View(voiceActor);
        }

        public async Task<IActionResult> Delete(int id)
        {
			await _service.DeleteAsync(id);
			return RedirectToAction(nameof(Index));
		}
    }
}
