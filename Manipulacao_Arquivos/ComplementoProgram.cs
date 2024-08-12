partial class Program
{
    static void ConverterTexto_Objeto()
    {
        string way = Path.GetFullPath("contas.txt");
        using (FileStream arquivo = new FileStream(way, FileMode.Open))
        {
            using (StreamReader leitor = new StreamReader(arquivo))
            {
                string linha;
                while (!leitor.EndOfStream)
                {
                    linha = leitor.ReadLine();
                    var dados = linha.Split(',');
                }
            }
        }
    }
    static void EscreverEmArquivo(string way, string dados)
    {
        using (FileStream arquivo = new FileStream(way, FileMode.Create))
        {
            using (StreamWriter escritor = new StreamWriter(arquivo)) 
            {
                escritor.WriteLine(dados);
                escritor.Flush();
            }
        }
    }
}