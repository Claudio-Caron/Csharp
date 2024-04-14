using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Ex3e4e5_04CAAL;

internal class Controler: Opcoes
{
    public List<PessoaInfo> PessoasCadastradas { get; set; } = new();
    private static int ContadorDaLista {  get; set; } = 0;
    public void PrincipioDeControle()
    {
        int x = 1;
        while (x!=0)
        {
            Console.WriteLine("\t\t\t\tSISTEMA DE CADASTRO E MANIPULAÇÃO DE DADOS DE PESSOAS\n\n");
            Console.WriteLine("Escolha uma das Opcoes para Seguir:\n"+
                " \t1 -> Novo Cadastro-Pessoa\n" +
                " \t2 -> Exibir Pessoas Cadastradas em Ordem\n" +
                " \t3 -> Buscar Pessoa(Por nome/idade)\n" +
                " \t4 -> Exibir Dados de uma pessoa\n" +
                " \t0 -> ENCERRAR PROGRAMA");
            x = int.Parse(Console.ReadLine()!);
            switch (x)
            {
                case 1:
                    AdicionarCadastro();
                    break;
                case 2:
                    ExibirPessoasCadastradas();
                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 0:
                    Console.WriteLine("PROGRAMA ENCERRADO\n");
                    break;
                default:
                    Console.WriteLine("COMANDO NÃO RECONHECIDO\n");
                    break;
            }
        }
    }
    private void MensagemEscolha(int n)
    {
        Console.Clear();
        Console.Write($"Opção escolhida : {n}");
    }
    public void AdicionarCadastro()
    {
        MensagemEscolha(1);
        ContadorDaLista++;
        PessoaInfo pessoanova = Op1();
        PessoasCadastradas.Add(pessoanova);
        ManipularJson();
    }
    public void ExibirPessoasCadastradas()
    {
        List<PessoaInfo> retornoExibir = Desserealizacao();
        var retornoOrdenado = retornoExibir.OrderBy(x=>x.Nome).Select(x=>x.Nome).ToList();
        Console.Clear();
        foreach (var nome in retornoOrdenado)
        {
            Console.WriteLine(nome+" ");
        }
    }
    private void ManipularJson()
    {
        ArquivoJson = JsonSerializer.Serialize(PessoasCadastradas); 
        File.WriteAllText("Pessoas_Cadastradas.Json",ArquivoJson);
    }
    private string? ArquivoJson {  get; set; }
    private List<PessoaInfo> Desserealizacao()
    { 
        var jsonDesserealizado =
            JsonSerializer.Deserialize<List<PessoaInfo>>(File.ReadAllText(Path.GetFullPath("Pessoas_Cadastradas.Json")));
        return jsonDesserealizado!;
    }
    
}
