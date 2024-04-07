using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
//Dada uma lista de livros com título, autor e ano de publicação,
//criar uma consulta LINQ para retornar uma lista com os títulos
//dos livros publicados após o ano 1900, ordenados alfabeticamente.
using _2_04CAAL;
namespace Ex2_02CAAL;


internal class LinqLivro
{
    public static string teste = "Ok";
    public static List<string> LivrosAposDoisMil(List<LivroJson> livros)
    => livros.Where(x => x.AnoDePublicacao>=1900).Select(x => x.Titulo!).ToList();     
}