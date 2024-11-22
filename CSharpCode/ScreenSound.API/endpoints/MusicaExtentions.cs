using Microsoft.AspNetCore.Mvc;
using PersistindoDadosComEntityFC.Database;
using ScreenSound.API.Requests;
using ScreenSound.API.Responses;
using ScreenSound.Modelos;

namespace ScreenSound.API.endpoints
{
    public static class MusicaExtentions
    {
        public static void AddEndpointsMusica(this WebApplication app)
        {
            app.MapGet("/Musicas", ([FromServices] DAL<Musica> dal)
                => Results.Ok(EntityListToResponse(dal.Listar())));


            app.MapGet("/Musicas/{nome}", ([FromServices] DAL<Musica> dal, string nome) =>
            {
                var musica = dal.RecuperarPor(x => x.Nome.ToUpper().Equals(nome.ToUpper()));
                if (musica is null)
                {
                    return Results.NotFound();
                }
                var transferMusic = new MusicaResponse(musica.Nome, musica.AnoLancamento);
                return Results.Ok(transferMusic);
            });

            app.MapPost("/Musicas", ([FromServices] DAL<Musica> dal, [FromBody] MusicaRequest musicRequest) =>
            {
                var music = new Musica(musicRequest.nome);
                music.Id = musicRequest.ArtistaId;
                if (musicRequest.anoLancamento!=0) 
                    music.AnoLancamento = musicRequest.anoLancamento;
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
            app.MapPut("/Musicas", ([FromServices] DAL<Musica> dal, [FromBody] MusicaRequestEdit music) =>
            {
                var recoveredMusic = dal.RecuperarPor(x => x.Id.Equals(music.Id));
                if (recoveredMusic is null)
                {
                    return Results.NotFound();
                }
                recoveredMusic.Nome = music.nome;
                recoveredMusic.AnoLancamento = music.anoLancamento;

                dal.Alterar(recoveredMusic);
                return Results.Ok();
            });
        }

        private static ICollection<MusicaResponse> EntityListToResponse(IEnumerable<Musica> musics)
            => musics.Select(x => EntityToResponse(x)).ToList();

        private static MusicaResponse EntityToResponse(Musica music)
            => new MusicaResponse(music.Nome, music.AnoLancamento);
    }
}
