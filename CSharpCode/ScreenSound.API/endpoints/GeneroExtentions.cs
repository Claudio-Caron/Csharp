using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using PersistindoDadosComEntityFC.Database;
using ScreenSound.API.Requests;
using ScreenSound.API.Responses;
using ScreenSound.Modelos.Modelos;

namespace ScreenSound.API.endpoints
{
    public static class GeneroExtentions
    {
        public static void AddEndpointsGenero(this WebApplication app)
        {
            app.MapGet("/Generos", ([FromServices] DAL<Genero> generos) =>
            {
                if (generos.Listar() is not null)
                {
                    var generosListadosRequest = GenerosToCollection(generos.Listar());
                    return Results.Ok(generosListadosRequest);
                }
                return Results.NotFound();
            });
            app.MapGet("/Generos/{nome}", ([FromServices] string nome,[FromServices] DAL<Genero> generos)=>
            {
                if (generos.Listar() is not null)
                {
                    var generoRecuperado = generos.RecuperarPor(x => x.Name.ToUpper().Equals(nome.ToUpper()));
                    if (generoRecuperado is not null)
                    {
                        return Results.Ok(generoRecuperado);
                    }
                }
                return Results.NotFound();
            });
            app.MapPost("/Generos", ([FromServices]DAL<Genero> generos, [FromBody] GeneroRequest genero) =>
            {
                var recuperedGenero = generos.RecuperarPor(x => x.Name.ToUpper().Equals(genero.Name.ToUpper()));
                if (recuperedGenero is not null)
                {
                    return Results.Conflict();
                }
                //conversão
                var convertedGenero = RequestedToGenero(genero);
                generos.Adicionar(convertedGenero);
                return Results.Ok(convertedGenero);
            });
            app.MapDelete("/Generos/{Id}", ([FromServices] DAL<Genero> generos, int Id) =>
            {
                var recuperedGenero = generos.RecuperarPor(x => x.Id == Id);
                if (recuperedGenero is not null)
                {
                    generos.Deletar(recuperedGenero);
                    return Results.NoContent();
                }
                return Results.NotFound();
            });
            app.MapPut("/Generos", ([FromServices] DAL<Genero> generos,[FromBody] GeneroRequestEdit genero) =>
            {
                var recuperedGenero = generos.RecuperarPor(x => x.Id == genero.Id);
                if (recuperedGenero is null)
                { 
                    return Results.NotFound();
                }
                recuperedGenero.Name = genero.Name;
                recuperedGenero.Description = genero.Description;
                generos.Alterar(recuperedGenero);
                return Results.Ok(recuperedGenero);
            });
        }

        public static Genero RequestedToGenero(GeneroRequest genero)
        {
            return new Genero() {Name = genero.Name, Description = genero.Description };
        }
        private static ICollection<GeneroResponse> GenerosToCollection(IEnumerable<Genero> generos)
            => generos.Select(a=>GeneroToGeneroRequest(a)).ToList();

        private static GeneroResponse GeneroToGeneroRequest(Genero genero)
        => new(genero.Id, genero.Name!, genero.Description);
    }
}
