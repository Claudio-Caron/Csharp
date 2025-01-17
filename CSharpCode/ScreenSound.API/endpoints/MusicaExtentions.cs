using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using PersistindoDadosComEntityFC.Database;
using ScreenSound.API.Requests;
using ScreenSound.API.Responses;
using ScreenSound.Modelos;
using ScreenSound.Modelos.Modelos;

namespace ScreenSound.API.endpoints
{
    public static class MusicaExtentions
    {
       // #region EndPoints
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

            app.MapPost("/Musicas", ([FromServices] DAL<Musica> dal,
                [FromServices]DAL<Genero> dalGeneros,[FromBody] MusicaRequest musicRequest) =>
            {
                var music = new Musica(musicRequest.nome)
                {
                    AnoLancamento = musicRequest.anoLancamento,
                    Id = musicRequest.ArtistaId,
                    GenerosMusica = musicRequest.generos is not null ?
                    RequestToGeneroEntity(musicRequest.generos, dalGeneros) : new List<Genero>()
                };
                
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

        private static ICollection<Genero> RequestToGeneroEntity(ICollection<GeneroRequest> generos, DAL<Genero> dalGenero)
        {
            var generosConvertidos = new List<Genero>();
           
            foreach(var item in generos)
            {
                var genero= new Genero() { Name = item.Name, Description = item.Description };
                var entity = dalGenero.RecuperarPor(x=>x.Name.ToUpper().Equals(item.Name.ToUpper()));
                if (entity is not null)
                {
                    generosConvertidos.Add(entity);
                }
                else
                {
                    generosConvertidos.Add(genero);
                }
            }

            return generosConvertidos;
        }

        private static ICollection<MusicaResponse> EntityListToResponse(IEnumerable<Musica> musics)
            => musics.Select(x => EntityToResponse(x)).ToList();
        
        private static MusicaResponse EntityToResponse(Musica music)
            => new MusicaResponse(music.Nome, music.AnoLancamento);
    }
}
