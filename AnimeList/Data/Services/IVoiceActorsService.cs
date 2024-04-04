using AnimeList.Models;

namespace AnimeList.Data.Services
{
    public interface IVoiceActorsService
    {
        Task<IEnumerable<VoiceActor>> GetAllAsync();

        Task<VoiceActor> GetByIdAsync(int id);

        Task<bool> AddAsync(VoiceActor voiceActor);

        Task<bool> UpdateAsync(VoiceActor voiceActor);

        Task<bool> DeleteAsync(int id);
    }
}
