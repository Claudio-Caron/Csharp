using Microsoft.IdentityModel.Clients.ActiveDirectory;
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
        return await
            _httpclient.GetFromJsonAsync<ICollection<ArtistaResponse>>
            ("artistas");
    }   
}
