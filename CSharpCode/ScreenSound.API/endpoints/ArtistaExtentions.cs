using Microsoft.AspNetCore.Mvc;
using PersistindoDadosComEntityFC.Database;
using ScreenSound.API.Requests;
using ScreenSound.Modelos;

namespace ScreenSound.API.endpoints
{
    public static class ArtistaExtentions
    {
        public static void AddEndpointsArtista(this WebApplication app)
        {
            app.MapGet("/Artistas", ([FromServices] DAL<Artista> artistaDal)
                => Results.Ok(artistaDal.Listar()));


            app.MapGet("/Artistas/{nome}", ([FromServices] DAL<Artista> dal, string nome) =>
            {
                Artista artistar = dal.RecuperarPor(a => a.Nome.ToUpper().Equals(nome.ToUpper()));
                if (artistar is null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(artistar);

            });

            app.MapPost("/Artistas", ([FromServices] DAL<Artista> artistaDal, [FromBody] Rartista artistaRequisicao) =>
            {
                var artista = new Artista(artistaRequisicao.nome, artistaRequisicao.bio);
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
        }
    }
}
