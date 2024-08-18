using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Formatting = Newtonsoft.Json.Formatting;

/*Neste ponto do curso você já sabe como utilizar bibliotecas,
 * tanto próprias, como de terceiros. Agora que viu como criar um componente (DLL),
 * o seu desafio, caso você aceite, é desenvolver uma DLL que possa receber
 * uma lista genérica de objeto e também salvá-la nos formatos .xml e .json.

Lembre-se este desafio é opcional, mas é uma ótima oportunidade para 
que você possa colocar em prática o que estamos estudando até aqui.*/
namespace ConversaoArquivos
{
    class ConversaoArquivo
    {
        public enum OpArquivo
        {
            Json,
            XML,
            CSV
        }
        public void SalvarListaEmArquivo<T>(List<T> lista, OpArquivo escolha, string caminho)
        {
            switch (escolha)
            {
                case OpArquivo.Json:
                    SalvarEmJson(lista, caminho);
                    break;
                case OpArquivo.XML:

                    break;
                case OpArquivo.CSV:
                    break;
                default:
                    throw new Exception("Erro no Formato");
            }
        }
        private void SalvarEmJson<T>(List<T> lista, string path)
        {
            string json = JsonConvert.SerializeObject(lista, Formatting.Indented);
            try
            {
                File.WriteAllText(path, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Falha ao escrever arquivo em Json"+ex.ToString());
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
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }



        }


    }
}
