using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulacao_Arquivos
{
    internal class Op
    {
        public static void EscreverBuffer(byte[] buffer, int numeroFinal)
        {
            var utf8 = new UTF8Encoding();
            Console.WriteLine(utf8.GetString(buffer, 0, numeroFinal));
        }
    }
}
