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
                string texto;
                while (!sr.EndOfStream)
                {
                    texto = sr.ReadLine();
                    Console.WriteLine(texto);
                }
            }
        }

    }
}