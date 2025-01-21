using ScreenSound.API.Requests;
using ScreenSound.API.Responses;
using System.Net.Http;
using System.Net.Http.Json;

namespace ScreenSound.Web.Services
{
    public class MusicaAPI
    {
        private HttpClient _httpClient;
        public MusicaAPI(IHttpClientFactory factory)
        {
            _httpClient = factory.CreateClient("API");
        }
        public async Task<ICollection<MusicaResponse>?> GetMusicasAsync()
        {
            return await _httpClient.GetFromJsonAsync<ICollection<MusicaResponse>>("musicas");
        }
        public async Task<MusicaResponse?> GetMusicaPorNomeAsync(string nomeMusica)
        {
            return await _httpClient.GetFromJsonAsync<MusicaResponse>($"musicas/{nomeMusica}/");
        }
        public async Task DeleteMusicaAsync(int Id)
        {
            await _httpClient.DeleteAsync($"musicas/{Id}");
        }
        public async Task AddMusicaAsync(MusicaRequest music)
        {
            await _httpClient.PostAsJsonAsync("musicas", music);
        }
        public async Task UpdateMusicaAsync(MusicaRequestEdit musica)
        {
            await _httpClient.PutAsJsonAsync("musicas", musica);
        }
    }
}
