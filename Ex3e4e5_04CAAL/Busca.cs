using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3e4e5_04CAAL
{
    internal class Busca
    {
        public static void Buscar(List<PessoaInfo> Pessoas)
        {
            Console.Clear();
            int a = 0;
            while (a!=1 && a!=2)
            {
                Console.WriteLine("Deseja Buscar os dados por nome ou por Idade?\n 1 -> Nome\n 2 -> Idade\n");
                a = int.Parse(Console.ReadLine()!);
            }
            if (a==1)
            {
                Console.WriteLine("Qual pessoa deseja saber os Dados?");
                string busca_pessoa = Console.ReadLine()!;
                int index= Pessoas.FindIndex(x=>x.Nome!.Equals(busca_pessoa));
            }
        }
    }
}
