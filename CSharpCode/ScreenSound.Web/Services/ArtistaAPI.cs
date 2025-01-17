using ScreenSound.API.Requests;
using ScreenSound.API.Responses;
using System.Net.Http.Json;
using IHttpClientFactory = System.Net.Http.IHttpClientFactory;

namespace ScreenSound.Web.Services;

public class ArtistaAPI
{
    private readonly HttpClient _httpclient;
    public ArtistaAPI(IHttpClientFactory factory)
    {
        _httpclient = factory.CreateClient("API");
    }
    

public async Task<ICollection<ArtistaResponse>?> GetArtistasAsync()
    {
        ICollection<ArtistaResponse>? artistasTeste;
        try
        {
            artistasTeste = await
            _httpclient.GetFromJsonAsync<ICollection<ArtistaResponse>>
            ("artistas");
            if (artistasTeste == null)
            {
                Console.WriteLine("Retorno nulo da API");
            }
            return artistasTeste;
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro no Arquivo ArtistaApi . Mensagem : {ex.Message}");
        }
    }  
    public async Task AddArtistaAsync(ArtistaRequest artistaRequest)
    {
        await _httpclient.PostAsJsonAsync("artistas", artistaRequest);
    }
    public async Task DeleteArtistaAsync(int id)
    {
        await _httpclient.DeleteAsync($"artistas/{id}");
    }
    public async Task<ArtistaResponse?> GetArtistaPorNomeAsync(string nome)
    {
        return await _httpclient.GetFromJsonAsync<ArtistaResponse?>($"artistas/{nome}");
    }
    public async Task UpdateArtistaAsync(ArtistaRequestEdit artista)
    {
        await _httpclient.PutAsJsonAsync($"artistas", artista);
    }
 
}
