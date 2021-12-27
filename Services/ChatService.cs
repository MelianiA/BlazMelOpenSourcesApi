using BlazMelOpenSourcesApi.Models;
using System.Net.Http.Json;

namespace BlazMelOpenSourcesApi.Services
{
    public class ChatService : IChatService
    {
        private readonly HttpClient _httpClient;
        public ChatService()
        {
            _httpClient = new HttpClient(); 
        }
        public async Task<List<Chat>> GetChats()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<List<Chat>>("https://api.thecatapi.com/v1/images/search");
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
