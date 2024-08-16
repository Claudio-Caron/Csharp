using System.Xml;

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
                    string[] dados = linha.Split(',');
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
    static void EscreverArquivoXml(string way, string dados)
    {
        try
        {
            string xml = XmlConvert.DecodeName(dados);
            File.WriteAllText(way, xml);

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}