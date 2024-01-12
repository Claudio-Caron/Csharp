
Console.WriteLine("Insira sua nota para saber se é o suficiente");
string nota = Console.ReadLine()!;
int notateste= int.Parse(nota);
if (notateste >= 5)
{
    Console.WriteLine("Nota suficiente");
}
else
{
    Console.WriteLine("Nota insuficiente ou Inválida");
}
    

