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
    private List<PessoaInfo> RetornoExibir { get; set; } = new List<PessoaInfo>(); 
    public Controler()
    {
       RetornoExibir =  Desserealizacao();
    }
    private string? ArquivoJson { get; set; }
   // public List<PessoaInfo> PessoasCadastradas { get; set; } = new();
    public void PrincipioDeControle()
    {
        int x = 1;
        while (x!=0)
        {
            Console.WriteLine("\t\t\t\tSISTEMA DE CADASTRO E MANIPULAÇÃO DE DADOS DE PESSOAS\n\n");
            Console.WriteLine("Escolha uma das Opcoes para Seguir:\n"+
                " \t1 -> Novo Cadastro-Pessoa\n" +
                " \t2 -> Exibir Pessoas Cadastradas em Ordem\n" +
                " \t3 -> Buscar os dados da pessoa pelo nome\n" +
                " \t4 -> Exibir pessoas com idade específicada\n"+
                " \t5 -> Limpar a lista cadastrada\n" +
                " \t0 -> ENCERRAR PROGRAMA");
            x = int.Parse(Console.ReadLine()!);
            switch (x)
            {
                case 1:
                    AdicionarCadastro();
                    break;
                case 2:
                    ExibirPessoasCadastradasOrdenadas();
                    break;
                case 3:
                    Busca.BuscarPorNome(RetornoExibir);
                    break;
                case 4:
                    Busca.FiltraIdade(RetornoExibir);
                    break;
                case 5:
                    LimparLista();
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
    private void LimparLista()
    {
        if (File.Exists(Path.GetFullPath("Pessoas_Cadastradas.Json")))
        {
            MensagemEscolha(5);
            File.Delete(Path.GetFullPath("Pessoas_Cadastradas.Json"));
            RetornoExibir.Clear();
            Console.WriteLine("\nOs dados armazenados foram deletados com suceso\nPressione qualquer tecla para continuar\n");
        }else
            Console.WriteLine("A lista ja esta vazia\nPressione qualquer tecla para continuar");
        Console.ReadKey();
        Console.Clear();
    }
    private void MensagemEscolha(int n)
    {
        Console.Clear();
        Console.Write($"Opção escolhida : {n}");
    }
    public void AdicionarCadastro()
    {
        MensagemEscolha(1);
        //ContadorDaLista++;
        PessoaInfo pessoanova = Op1();
        RetornoExibir.Add(pessoanova);
        ManipularJson();
        //RetornoExibir = Desserealizacao();
    }
    public void ExibirPessoasCadastradasOrdenadas()
    {
        if (RetornoExibir.Count == 0)
        {
            Console.WriteLine("Não existem pesssoas cadastradas na lista de registros");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            var retornoOrdenado = RetornoExibir.OrderBy(x => x.Nome).Select(x => x.Nome).ToList();
            Console.Clear();
            Console.WriteLine("Pessoas cadastradas na Lista: \n");
            foreach (var nome in retornoOrdenado)
            {
                Console.WriteLine("\t"+nome + " ");
            }
            Console.WriteLine("\n Pressione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
    }
    private void ManipularJson()
    {
        /*   if (JsonNaoVazio && contador == 0)
         *   
         *   
         */
        ArquivoJson = JsonSerializer.Serialize(RetornoExibir);
        File.WriteAllText("Pessoas_Cadastradas.Json",ArquivoJson);
    }

    private List<PessoaInfo>? Desserealizacao()
    {
        try
        {
            if (File.Exists("Pessoas_Cadastradas.Json"))
            {
                List<PessoaInfo> retorno = JsonSerializer.Deserialize<List<PessoaInfo>>(File.ReadAllText(Path.GetFullPath("Pessoas_Cadastradas.Json")))!;
                return retorno;
            } else 
            { 
                return RetornoExibir;
            }
        }
        catch (Exception ex)
        {
            //if (File.Exists("Pessoas_Cadastradas.Json") == false){
            //    Console.WriteLine("Lista vazia");
            //}
            if (File.Exists("Pessoas_Cadastradas.Json"))
            { 
                Console.WriteLine("Erro na desserealizacao do arquivo com os dados inseridos" + ex.Message);
            }
            return null;
        }
    }
    
    
}
