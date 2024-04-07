using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _3_01CAAL;
//Dada uma lista de números, criar uma consulta LINQ
//para retornar apenas os elementos únicos da lista.
    internal class Unico
{
    public static void NumerosUnicos(List <int> lista)
    {
        var listaNova = lista.Distinct().Order().ToList();
        foreach (int i in listaNova)
        {
            Console.WriteLine(i+ "");
        }

    }
}

