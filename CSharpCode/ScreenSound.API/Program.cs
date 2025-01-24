using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.AspNetCore.Mvc;
using PersistindoDadosComEntityFC.Database;
using ScreenSound.Modelos;
using System.Text.Json.Serialization;
using PersistindoDadosComEntityFC.Migrations;
using ScreenSound.API.endpoints;
using ScreenSound.Modelos.Modelos;
using JsonOptions = Microsoft.AspNetCore.Http.Json.JsonOptions;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Host.ConfigureAppConfiguration(config =>
        {
            var settings = config.Build();
            config.AddAzureAppConfiguration("Endpoint=https://screensound-configurationn.azconfig.io;Id=Ks7s;Secret=FeSonGkMHROaAKNShqYI3MX4WhJk9zMHDXiwQgovZeJW7CADBmPzJQQJ99BAACZoyfie5JLqAAACAZAC483Q");
        });
        builder.Services.AddCors(options =>
        {
            options.AddPolicy("PermitirTudo", policy =>
            {
                policy.AllowAnyOrigin()
                      .AllowAnyMethod()
                      .AllowAnyHeader();
            });
        });
        


        builder.Services.AddDbContext<ScreenSoundContext>((options) =>
        {
            options.UseSqlServer(builder.Configuration["ConnectionStrings:ScreenSoundDB"])
                .UseLazyLoadingProxies();

        });

        builder.Services.AddTransient<DAL<Artista>>();
        builder.Services.AddTransient<DAL<Musica>>();
        builder.Services.AddTransient<DAL<Genero>>();

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.Configure<JsonOptions>(options => options.SerializerOptions
            .ReferenceHandler = ReferenceHandler.IgnoreCycles);

        var app = builder.Build();
        app.UseStaticFiles();
        app.UseSwagger();
        app.UseSwaggerUI();

        ArtistaExtentions.AddEndpointsArtista(app);
        MusicaExtentions.AddEndpointsMusica(app);
        GeneroExtentions.AddEndpointsGenero(app);
        
        app.UseCors("PermitirTudo");
        app.Run();
    }
}
