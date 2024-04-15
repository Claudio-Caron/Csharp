using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3e4e5_04CAAL
{
    internal class Busca
    {
        public static void BuscarPorNome(List<PessoaInfo> pessoas)
        {
            Console.Clear();


            Console.WriteLine("Qual pessoa deseja saber os Dados?");
            string busca_pessoa = Console.ReadLine()!;
            if (pessoas.Select(x => x.Nome).Contains(busca_pessoa))
            {
                PessoaInfo retornoBusca = pessoas.FirstOrDefault(x => x.Nome.Equals(busca_pessoa));
                Console.WriteLine($"Dados da pessoa encontrados : \nNome : {retornoBusca.Nome}\n" +
                    $"Idade : {retornoBusca.Idade}\nSexo : {retornoBusca.Sexo}\nAltura : {retornoBusca.AlturaEmMetros} metros\n");
            }
            else
            {
                Console.WriteLine("Pessoa não cadastrada");
            }
            Console.WriteLine("Pressione qualquer tecla para continuar\n");
            Console.ReadKey();
            Console.Clear();


        }


        public static void FiltraIdade(List<PessoaInfo> pessoas)
        {
            Console.Clear();
            Console.WriteLine("Qual a idade que deseja filtrar?");
            int c = int.Parse(Console.ReadLine()!);
            var filtradas = pessoas.Where(x => x.Idade == c).ToList();
            if (filtradas.Count != 0)
            {
                Console.WriteLine($"Pessoas com idade = {c}\n|");
                for (int i = 0; i < filtradas.Count; i++)
                {
                    Console.Write(filtradas[i].Nome + " | ");
                }
            }
            else
            {
                Console.WriteLine("Nao foram encontrados registros de pessoas cadastradas nessa faixa de idade");
            }
            Console.WriteLine("Pressione qualquer tecla para Prosseguir");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
