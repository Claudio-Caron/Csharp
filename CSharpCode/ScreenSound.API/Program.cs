using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.AspNetCore.Mvc;
using PersistindoDadosComEntityFC.Database;
using ScreenSound.Modelos;
using System.Text.Json.Serialization;
using PersistindoDadosComEntityFC.Migrations;
using ScreenSound.API.endpoints;
using JsonOptions = Microsoft.AspNetCore.Http.Json.JsonOptions;

internal class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddDbContext<ScreenSoundContext>();
        builder.Services.AddTransient<DAL<Artista>>();
        builder.Services.AddTransient<DAL<Musica>>();

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.Configure<JsonOptions>(options => options.SerializerOptions
            .ReferenceHandler = ReferenceHandler.IgnoreCycles);

        var app = builder.Build();

        app.UseSwagger();
        app.UseSwaggerUI();

        ArtistaExtentions.AddEndpointsArtista(app);
        MusicaExtentions.AddEndpointsMusica((app));
        
        app.Run();
    }
}
