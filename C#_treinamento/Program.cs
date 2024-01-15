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
/*
string b1="C#", b2="javascript", b3="Java";
Console.WriteLine("escolha um número para linguagem:");
Console.WriteLine(" 1\"C#\", 2\"javascript\", 3\"java\"");
string esc=Console.ReadLine()!;
int x = int.Parse(esc);
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
*/
using System.Diagnostics;
void imprimir(List<String> band)
{
    foreach(var bandName in band)
    {
        Console.WriteLine(bandName);
    }
    Console.ReadKey();
    return;
}
void mensagem()
{
    Console.WriteLine(@"
██████╗░░█████╗░███╗░░██╗██████╗░  ░██████╗██╗░░░██╗░██████╗████████╗███████╗███╗░░░███╗
██╔══██╗██╔══██╗████╗░██║██╔══██╗  ██╔════╝╚██╗░██╔╝██╔════╝╚══██╔══╝██╔════╝████╗░████║
██████╦╝███████║██╔██╗██║██║░░██║  ╚█████╗░░╚████╔╝░╚█████╗░░░░██║░░░█████╗░░██╔████╔██║
██╔══██╗██╔══██║██║╚████║██║░░██║  ░╚═══██╗░░╚██╔╝░░░╚═══██╗░░░██║░░░██╔══╝░░██║╚██╔╝██║
██████╦╝██║░░██║██║░╚███║██████╔╝  ██████╔╝░░░██║░░░██████╔╝░░░██║░░░███████╗██║░╚═╝░██║
╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░  ╚═════╝░░░░╚═╝░░░╚═════╝░░░░╚═╝░░░╚══════╝╚═╝░░░░░╚═╝");
}
void Painel()
{
    int esc;
    List<string> ListaBandas = new List<string> { "mamonas", "AC DC", "Linkin Park", "Skilet" };
    mensagem();
    do
    {
        Console.WriteLine("\t ESCOLHA UMA DAS OPCOES PARA SEGUIR:");
        Console.Write("\t 1_Adicionar uma banda preferida\n\t 2_Exibir lista de bandas preferidas\n\t 3_Remover Uma Banda\n\t 4_Sair da Lista :(\n\t ");
        String x = Console.ReadLine()!;
        esc = int.Parse(x);
        switch (esc)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("\tOpcao escolhida : 1");
                Console.WriteLine("\tInsira qual o nome da Banda que deseja adicionar:");
                String adc = Console.ReadLine()!;
                ListaBandas.Add(adc);
                Console.WriteLine("Banda adicionada");

                Thread.Sleep(2000);
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("Opção escolhida : 2");
                imprimir(ListaBandas);
                Thread.Sleep(2000);
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("Opcao escolhida : 3");
                Console.WriteLine("Digite o nome da banda que deseja remover:");
                String rem = Console.ReadLine()!;
                bool Check = ListaBandas.Remove(rem);
                if (Check)
                {
                    Console.WriteLine("Banda removida");
                }
                else
                {
                    Console.WriteLine("Essa Banda não existe na lista");
                }
                Thread.Sleep(2000);
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("Opcao escolhida : 4");
                Console.WriteLine(@"
██████╗░██╗░░░██╗███████╗          ██████╗░██╗░░░██╗███████╗
██╔══██╗╚██╗░██╔╝██╔════╝          ██╔══██╗╚██╗░██╔╝██╔════╝
██████╦╝░╚████╔╝░█████╗░░          ██████╦╝░╚████╔╝░█████╗░░
██╔══██╗░░╚██╔╝░░██╔══╝░░          ██╔══██╗░░╚██╔╝░░██╔══╝░░
██████╦╝░░░██║░░░███████╗          ██████╦╝░░░██║░░░███████╗
╚═════╝░░░░╚═╝░░░╚══════╝          ╚═════╝░░░░╚═╝░░░╚══════╝");
                break;
            default:
                Console.Clear();
                Console.WriteLine("\t Voce não escolheu uma alternativa valida!!!\n\t PRESSIONE QUALQUER TECLA PARA CONTINUAR");
                Console.ReadKey();
                break;
        }
        Console.Clear();
    } while (esc != 4);
}
Painel();

