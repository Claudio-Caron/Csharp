using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Formatting = Newtonsoft.Json.Formatting;

namespace ConversaoArquivos
{
    /// <summary>
    /// enumerator para especificar o tipo do Arquivo para conversão
    /// </summary>
    public enum OpArquivo
    {
        Json,
        XML
    }
    /// <summary>
    /// Classe para serializar listas em arquivos
    /// </summary>
    public class ConversaoArquivo
    {
        /// <summary>
        /// Método responsável por serializar lista genérica em arquivo específico
        /// </summary>
        /// <typeparam name="Tipo da classe"></typeparam>
        /// <param name="lista"></param>
        /// <param name="escolha do tipo de arquivo"></param>
        /// <param name="caminho que o arquivo será salvo"></param>
        /// <exception cref="Exception"></exception>

        public void SalvarListaEmArquivo<T>(List<T> lista, OpArquivo escolha, string caminho)
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("***Lista Vazia***");
                Console.ReadKey();
                return;
            }
            switch (escolha)
            {
                case OpArquivo.Json:
                    SalvarEmJson(lista, caminho);
                    break;
                case OpArquivo.XML:
                    SalvarEmXml(lista, caminho);
                    break;
                default:
                    throw new Exception("Erro no Formato");
            }

        }
        private void SalvarEmJson<T>(List<T> lista, string caminho)
        {
            string json = JsonConvert.SerializeObject(lista, Formatting.Indented);
            try
            {
                Console.WriteLine(lista.ToString());
                Thread.Sleep(3000);
                var arquivo = new FileStream(caminho, FileMode.Create);
                Console.WriteLine("passou instancia filestream");
                Console.ReadKey();
                using (var sr = new StreamWriter(arquivo))
                {
                    Console.WriteLine("antes de escrever");
                    Console.ReadKey();
                    sr.WriteLine(json);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Falha ao escrever arquivo em Json no caminho : "+ caminho+"\n\n\n" + ex.ToString());
            }
        }
        private void SalvarEmXml<T>(List<T> lista, string path)
        {
            var serealizar = new XmlSerializer(typeof(List<T>));
            try
            {
                var arquivo = new FileStream(path + "\\dados.xml", FileMode.Create);
                using (var escritor = new StreamWriter(arquivo))
                {
                    serealizar.Serialize(arquivo, lista);
                    arquivo.Flush();
                }
                Console.WriteLine("Arquivo Salvo em " + path);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }



        }


    }
}
