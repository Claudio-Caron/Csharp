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
void AllPrint(Dictionary <String, List <int>> band)
{
    foreach(var bandname in band.Keys)
    {
        Console.Write(bandname);   
        foreach(var bandvalue in band[bandname])
        {
            Console.Write(" |"+bandvalue);    
        }
        Console.WriteLine("| \n");
    }
    Console.WriteLine("\n\t\t\t Pressione qualquer tecla para voltar ao Menu");    
    Console.ReadKey();
    return;
}
void imprimir(Dictionary<String, List<int>> band)
{
    foreach (var bandName in band.Keys)
    {
        Console.WriteLine("\t"+bandName);
    }
    Console.WriteLine("Pressine qualquer tecla para continuar");
    Console.ReadKey();
    return;
}
String mostrarmedias(Dictionary<String, List<int>> band){
    float Contador = 0, ValorTotal = 0;
    String Svalor;
    Console.WriteLine("Insira a banda para verificar a média de valores");
    String escolha = Console.ReadLine()!;
    if (band.ContainsKey(escolha))
    {
        foreach (var bandname in band[escolha])
        {
            ValorTotal += bandname;
            Contador++;
        }
        Contador = ValorTotal / Contador;
        Svalor = Contador.ToString();
        return "MEDIA DA BANDA"+escolha+" = "+Svalor;
    }else
    {
        return null;
    } 
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
void frase(string fras)
{
    int vezes= fras.Length;
    String impressao = new string('*',vezes);
    Console.WriteLine(impressao);
    Console.WriteLine(fras);
    Console.WriteLine(impressao);
    return;
}
void Painel()
{
    int esc;
    Dictionary<String, List<int>> DicBandas=new Dictionary<String, List<int>>();
    DicBandas.Add("MAMONAS", new List<int> { 4, 6, 7 });
    DicBandas.Add("Linkin in Park", new List<int> { 6, 3, 9 });
    DicBandas.Add("AC DC", new List<int> { 9, 8, 10 });


    mensagem();
    do
    {
        Console.WriteLine("\t ESCOLHA UMA DAS OPCOES PARA SEGUIR:");
        Console.Write("\t 1_Adicionar uma banda preferida\n\t 2_Exibir lista de bandas preferidas\n\t 3_Classificar uma banda\n\t 4_Mostrar Medias\n\t 5_mostrar notas das bandas\n\t 6_SAIR :(\n\t ");
        String x = Console.ReadLine()!;
        esc = int.Parse(x);
        switch (esc)
        {
            case 1:
                Console.Clear();
                frase("Opcao escolhida 01 -> ADICIONAR BANDA");
                Console.WriteLine("\tInsira qual o nome da Banda que deseja adicionar:");
                String adc = Console.ReadLine()!;
                if (DicBandas.ContainsKey(adc))
                {
                    Console.WriteLine("Essa banda já foi regitrada no sistema");
                }
                else
                {
                    DicBandas.Add(adc, new List<int>());
                    Console.WriteLine("Banda adicionada");
                }
                Thread.Sleep(2000);
                break;
            case 2:
                Console.Clear();
                frase("Opção escolhida : 2 -> IMPRIMIR BANDAS");
                imprimir(DicBandas);
                break;
            case 3:
                Console.Clear();
                frase("Opcao escolhida : 3 -> CLASSIFICAR BANDA");
                Console.WriteLine("Digite o nome da banda que deseja classificar:");
                String cla = Console.ReadLine()!;
                if (DicBandas.ContainsKey(cla))
                {
                    Console.WriteLine("Escolha a nota que deseja atribuir:");
                    int nota = int.Parse(Console.ReadLine()!);
                    DicBandas[cla].Add(nota);
                    Console.Clear();
                    Console.WriteLine($"A nota {nota} foi atribuido a banda {cla}");
                }
                else
                {
                    Console.WriteLine("Essa Banda não existe na lista");
                }
                Thread.Sleep(2000);
                break;
            case 4: 
                Console.Clear();
                frase("Opcao escolhida: 4 -> MOSTRAR MEDIAS");
                String RecebeMedia = mostrarmedias(DicBandas);
                
                if (RecebeMedia!=null)
                {
                    frase(RecebeMedia);
                    Thread.Sleep(3000);
                }
                else
                {
                    Console.WriteLine("Banda não encontrada");
                    Thread.Sleep(2000);
                }
                break;
            case 5:
                Console.Clear();
                frase("OPCAO ESCOLHIDA: 5 -> MOSTRAR NOTAS DAS BANDAS");
                AllPrint(DicBandas);
                break;
            case 6:
                Console.Clear();
                frase("Opcao escolhida : 5 -> SAIR");
                Console.WriteLine(@"
██████╗░██╗░░░██╗███████╗          ██████╗░██╗░░░██╗███████╗
██╔══██╗╚██╗░██╔╝██╔════╝          ██╔══██╗╚██╗░██╔╝██╔════╝
██████╦╝░╚████╔╝░█████╗░░          ██████╦╝░╚████╔╝░█████╗░░
██╔══██╗░░╚██╔╝░░██╔══╝░░          ██╔══██╗░░╚██╔╝░░██╔══╝░░
██████╦╝░░░██║░░░███████╗          ██████╦╝░░░██║░░░███████╗
╚═════╝░░░░╚═╝░░░╚══════╝          ╚═════╝░░░░╚═╝░░░╚══════╝");
                Thread.Sleep(2000);
                break;
            default:
                Console.Clear();
                Console.WriteLine("\t Voce não escolheu uma alternativa valida!!!\n\t PRESSIONE QUALQUER TECLA PARA CONTINUAR");
                Console.ReadKey();
                break;
        }
        Console.Clear();
    } while (esc != 6);
}
Painel();

