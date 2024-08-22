using ByteBankIO;
using ConversaoArquivos;
using System.Reflection.Metadata;
using System.Security.Claims;

namespace ManipulandoArquivosPorBibliotecaPessoal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ContaCorrente> listaDeContas = new List<ContaCorrente>();
            listaDeContas.Add(new ContaCorrente(122, 3234));
            ConversaoArquivo conversor = new ConversaoArquivo();
            conversor.SalvarListaEmArquivo(listaDeContas, OpArquivo.Json, "ARQUIVO_MEU_PROGRAMA");

        }
    }
}
