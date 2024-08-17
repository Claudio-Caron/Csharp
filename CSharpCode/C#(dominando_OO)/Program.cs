

// See https://aka.ms/new-console-template for more information
using Csharp_treinamento.Csharp_dominando_OO.Filmes;

Console.WriteLine("treinamento de exercicio");
List<Filme> Preferidos = new();
Artista Art1 = new("Roberto", 35);
Artista Art2 = new("Roberto Bocra", 25);
Artista Art3 = new("Fernando", 23);
Artista Art4 = new("Dionete", 18);
Artista Art5 = new("Claudia", 67);
Artista Art6 = new("Montana", 82);
Artista Art7 = new("Petcovith", 12);
Artista Art8 = new("POhh", 24);
Artista Art9 = new("Bob Munhete", 44);
Artista Art10 = new("Choque bradocks", 32);
Artista Art11 = new("Boiahhbuh", 42);
Artista Art12 = new("Luiza Bezerra", 54);
Artista Art13 = new("Bocadas", 32);
Artista Art14 = new("Chefia", 21);
Artista Art15 = new("Maluquete", 22);
List <Artista> Artists1 = new();
List <Artista> Artists2 = new();    
List <Artista> Artists3 = new();
List <Artista> Artists4 = new();
List <Artista> Artists5 = new();
Artists1.Add(Art1);
Artists1.Add(Art2);
Artists1.Add(Art3);
Artists2.Add(Art4);
Artists2.Add(Art5);
Artists2.Add(Art6);
Artists3.Add(Art7);
Artists3.Add(Art8);
Artists3.Add(Art9);
Artists4.Add(Art10);
Artists4.Add(Art11);
Artists4.Add(Art12);
Artists5.Add(Art13);
Artists5.Add(Art14);
Artists5.Add(Art15);
Filme Filme1 = new(Artists1, "A volta de quem não foi", 149);
Filme Filme2 = new(Artists2, "As trancas de um careca", 185);
Filme Filme3 = new(Artists3, "Pesado por miligramas", 219);
Filme Filme4 = new(Artists4, "O futuro de quem esta no passado", 145);
Filme Filme5 = new(Artists5, "O pensamento do cachorro", 145);
Preferidos.Add(Filme1);
Preferidos.Add(Filme2); 
Preferidos.Add(Filme3); 
Preferidos.Add(Filme4);
Preferidos.Add(Filme5);
foreach (var item in Preferidos)
{
    Console.WriteLine("\n|"+item.Titulo+"|");
}




