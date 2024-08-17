using Ex2_04CAAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
namespace Ex1_04CAAL;


internal class ShowJson
{
    public static void ExibirArquivoJson(string json)
    {
        try
        {
            var exibicao = JsonSerializer.Deserialize<CadastroPessoaDesserealizado>(json);

            Console.WriteLine(exibicao.ToString());
           
        }catch (Exception ex)
        {
            Console.WriteLine($"Erro na desserialização do arquivo: {ex.Message}\n");
        }
        
    }
}
