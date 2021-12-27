using BlazMelOpenSourcesApi.Models;

namespace BlazMelOpenSourcesApi.Services
{
    public interface IChatService
    {
        Task<List<Chat>> GetChats();
    }
}
