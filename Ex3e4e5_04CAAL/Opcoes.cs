using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3e4e5_04CAAL
{
    internal class Opcoes
    {
        protected PessoaInfo Op1()
        {
            
            Console.WriteLine(" -> Adicionar Cadastro\nInsira o Nome da Pessoa : ");
            string nomenovo = Console.ReadLine()!;

            Console.WriteLine("Insira a idade : ");
            int idadenova = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Insira a Altura em Metros : ");
            double alturanova = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Qual o sexo da Pessoa? (M ou F)");
            char sexonovo = char.Parse(Console.ReadLine()!);

            sexonovo = sexonovo.Equals('M') ? 'o' : 'a';
            Console.Clear();
            Console.WriteLine($"Os dados d{sexonovo} {nomenovo} Foram cadastrados com sucesso\n" +
                $" Pressione qualquer tecla para continuar\n");
            Console.ReadKey();
            return new PessoaInfo(nomenovo, sexonovo, alturanova, idadenova);



        }
    }
}
