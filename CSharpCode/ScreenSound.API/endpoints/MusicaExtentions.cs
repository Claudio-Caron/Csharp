using Microsoft.AspNetCore.Mvc;
using PersistindoDadosComEntityFC.Database;
using ScreenSound.Modelos;

namespace ScreenSound.API.endpoints
{
    public static class MusicaExtentions
    {
        public static void AddEndpointsMusica(this WebApplication app)
        {
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
                dal.Adicionar(music);
                return Results.Ok();
            });

            app.MapDelete("/Musicas/{id}", ([FromServices] DAL<Musica> dal, int id) =>
            {
                var recuperedMusic = dal.RecuperarPor(x => x.Id.Equals(id));
                if (recuperedMusic is null)
                {
                    return Results.NotFound();
                }
                dal.Deletar(recuperedMusic);
                return Results.Ok(recuperedMusic);
            });
            app.MapPut("/Musicas", ([FromServices] DAL<Musica> dal, [FromBody] Musica music) =>
            {
                var recoveredMusic = dal.RecuperarPor(x => x.Id.Equals(music.Id));
                if (recoveredMusic is null)
                {
                    return Results.NotFound();
                }
                recoveredMusic.Nome = music.Nome;
                recoveredMusic.AnoLancamento = music.AnoLancamento;
                recoveredMusic.Artista = music.Artista;

                dal.Alterar(recoveredMusic);
                return Results.Ok();
            });
        }
    }
}
