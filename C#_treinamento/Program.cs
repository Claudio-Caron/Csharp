//atividade 1 alura
/*Console.WriteLine("insira sua nota para saber se é o suficiente");
string nota = console.readline()!;
int notateste= int.Parse(nota);
if (notateste >= 5)
{
    Console.WriteLine("nota suficiente");
}
else
{
    Console.WriteLine("nota insuficiente ou inválida");

}*/
// ATIVIDADE  2  ALURA
string b1="C#", b2="javascript", b3="Java";
Console.WriteLine("escolha um número para linguagem:");
Console.WriteLine(" 1\"C#\", 2\"javascript\", 3\"java\"");
string esc=Console.ReadLine()!;
int x= int.Parse(esc);  
switch (x)
{
    case 1:
        Console.WriteLine("Banda escolhida:{0}", b1);
        break;
    case 2:
        Console.WriteLine("Banda escolhida:{0}", b2);
        break;
    case 3: Console.WriteLine("Banda escolhida: {0}"+ b3);
        break;
    default:
        Console.WriteLine("banda inválida");
        break;
}
 

