using AnimeList.Models;
using Microsoft.EntityFrameworkCore;

namespace AnimeList.Data.Services
{
    public class VoiceActorsService : IVoiceActorsService
    {
        private readonly AppDbContext _context;

        public VoiceActorsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddAsync(VoiceActor voiceActor)
        {
            await _context.AddAsync(voiceActor);
            var res = await _context.SaveChangesAsync();

            return res > 0;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var va = await _context.VoiceActors.FindAsync(id);
            _context.VoiceActors.Remove(va);
            var res = await _context.SaveChangesAsync();

            return res > 0;
        }

        public async Task<IEnumerable<VoiceActor>> GetAllAsync()
        {
			return await _context.VoiceActors.OrderBy(va => va.Name).ToListAsync();
        }

		public async Task<VoiceActor> GetByIdAsync(int id)
		{
			return await _context.VoiceActors.FindAsync(id);
		}

		public async Task<bool> UpdateAsync(VoiceActor voiceActor)
        {
            _context.Update(voiceActor);
            var res = await _context.SaveChangesAsync();
            return res > 0;
        }
    }
}
