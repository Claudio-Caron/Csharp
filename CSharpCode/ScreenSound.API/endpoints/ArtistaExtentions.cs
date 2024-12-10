using Microsoft.AspNetCore.Mvc;
using PersistindoDadosComEntityFC.Database;
using ScreenSound.API.Requests;
using ScreenSound.API.Responses;
using ScreenSound.Modelos;

namespace ScreenSound.API.endpoints
{
    public static class ArtistaExtentions
    {
        public static void AddEndpointsArtista(this WebApplication app)
        {
            app.MapGet("/Artistas", ([FromServices] DAL<Artista> artistaDal)=>
            {
                var returnICollection = ConvertToCollection(artistaDal.Listar());
                return Results.Ok(returnICollection);
            });

            app.MapGet("/Artistas/{nome}", ([FromServices] DAL<Artista> dal, string nome) =>
            {
                Artista artistar = dal.RecuperarPor(a => a.Nome.ToUpper().Equals(nome.ToUpper()));
                if (artistar is null)                     
                {
                    return Results.NotFound();
                }

                var transferArtist = new ArtistaResponse(artistar.Nome, artistar.Bio, artistar.FotoPerfil);
                return Results.Ok(transferArtist);
            });

            app.MapPost("/Artistas", ([FromServices] DAL<Artista> artistaDal, [FromBody] ArtistaRequest artistaRequisicao) =>
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

        private static ICollection<ArtistaResponse> ConvertToCollection(IEnumerable<Artista> artists)
        {
            return artists.Select(a => ConvertToResponse(a)).ToList();
        }


        private static ArtistaResponse ConvertToResponse(Artista artist)
        {
            return new ArtistaResponse(artist.Nome, artist.Bio, artist.FotoPerfil);
        }

    }
}
