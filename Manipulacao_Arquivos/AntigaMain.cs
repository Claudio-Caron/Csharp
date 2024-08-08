using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulacao_Arquivos
{
    partial class Program
    {
        public void ManipulacaoAntiga()
        {
            string Diretorio = "contas.txt";
            using (FileStream arquivo = new FileStream(Diretorio, FileMode.Open))
            {
                var buffer = new byte[1024];
                int bitslidos = -1;
                while (bitslidos != 0)
                {
                    bitslidos = arquivo.Read(buffer, 0, buffer.Length);
                    Op.EscreverBuffer(buffer, bitslidos);
                }
                arquivo.Close();

            }

        }
    }
}
