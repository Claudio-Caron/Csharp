using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.AspNetCore.Mvc;
using PersistindoDadosComEntityFC.Database;
using ScreenSound.Modelos;
using System.Text.Json.Serialization;
using PersistindoDadosComEntityFC.Migrations;
using JsonOptions = Microsoft.AspNetCore.Http.Json.JsonOptions;

internal class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddDbContext<ScreenSoundContext>();
        builder.Services.AddTransient<DAL<Artista>>();
        builder.Services.AddTransient<DAL<Musica>>();

        builder.Services.Configure<JsonOptions>(options => options.SerializerOptions
            .ReferenceHandler = ReferenceHandler.IgnoreCycles);

        var app = builder.Build();


        app.MapGet("/Artistas", ([FromServices]DAL<Artista> artistaDal) 
            => artistaDal.Listar());


        app.MapGet("/Artistas/{nome}", ([FromServices] DAL<Artista> dal, string nome) =>
        {
            Artista artistar = dal.RecuperarPor(a => a.Nome.ToUpper().Equals(nome.ToUpper()));
            if (artistar is null)
            {
                return Results.NotFound();
            }
            return Results.Ok(artistar);

        });

        app.MapPost("/Artistas", ([FromServices]DAL < Artista > artistaDal, [FromBody]Artista artista) =>
        {
            artistaDal.Adicionar(artista);
            return Results.Ok(artista); 
        });

        app.MapDelete("/Artistas/{id}", ([FromServices] DAL<Artista> artistaDal, int id) =>
        {
            var artistaRecuperado = artistaDal.RecuperarPor(x => x.Id.Equals(id));
            if (artistaRecuperado is null)
            {
                return Results.NoContent();
            }
            artistaDal.Deletar(artistaRecuperado);
            return Results.Ok();
        });

        app.MapPut("/Artistas", ([FromServices] DAL<Artista> dal, [FromBody] Artista artista) => {
            var artistaAAtualizar = dal.RecuperarPor(a => a.Id == artista.Id);
            if (artistaAAtualizar is null)
            {
                return Results.NotFound();
            }
            artistaAAtualizar.Nome = artista.Nome;
            artistaAAtualizar.Bio = artista.Bio;
            artistaAAtualizar.FotoPerfil = artista.FotoPerfil;

            dal.Alterar(artistaAAtualizar);
            return Results.Ok();
        });

        app.MapGet("/Musicas", ([FromServices] DAL<Musica> dal) => Results.Ok(dal.Listar()));
        
        app.MapGet("/Musicas/{nome}", ([FromServices] DAL<Artista> dal, string nome) =>
        {
            var musica = dal.RecuperarPor(x => x.Nome.ToUpper().Equals(nome.ToUpper()));
            if (musica is null)
            {
                return Results.NotFound();
            }

            return Results.Ok(musica);
        });

        app.MapPost("/Musicas", ([FromServices] DAL<Musica> dal, [FromBody] Musica music) =>
        {
        });

        app.Run();
    }
}
