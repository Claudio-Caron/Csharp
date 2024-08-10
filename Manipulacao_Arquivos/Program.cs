using ByteBankIO;
using Manipulacao_Arquivos;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

partial class Program
{
    private static void Main(string[] args)
    {
        string endereco = "contas.txt";
        using (FileStream arquivo = new FileStream(endereco, FileMode.Open))
        { 
            using (StreamReader sr = new StreamReader(arquivo))
            {
                List<ContaCorrente> contas = new List<ContaCorrente>();
                string texto;
                while (!sr.EndOfStream)
                {
                    texto = sr.ReadLine();
                    Console.WriteLine(texto);
                    contas.Add(ConversaoDeArquivoParaObjeto(texto));
                    Console.WriteLine("Nome: "+contas.Last().Titular.Nome);
                }
            }
        }

    }
    static ContaCorrente ConversaoDeArquivoParaObjeto(string texto)
    {
        var dados = texto.Split(',');
        ContaCorrente conta = new ContaCorrente(int.Parse(dados[0]), int.Parse(dados[1]));
        conta.Depositar(double.Parse(dados[2]));
      //  conta.Titular= new Cliente();   
        conta.Titular.Nome = dados[3];
        return conta;
    }
}