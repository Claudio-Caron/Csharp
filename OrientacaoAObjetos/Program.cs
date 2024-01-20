using System;

namespace Standard
{
    class Version
    {
        static void Main(String[] args) 
        {
            Console.WriteLine("teste de estrutura");
            Aluno Aluno = new Aluno();
            Console.WriteLine("Insira o valor da primeira nota:");
             int Nota11= int.Parse(Console.ReadLine()!);
            Console.WriteLine("Insira o valor da segunda nota:");
            int Nota22= int.Parse(Console.ReadLine()!); 
            Aluno.situacao=Aluno.AvaliarAluno(Nota11, Nota22);
            Console.WriteLine($"A nota final do aluno é:{Aluno.notafinal}");
            Console.WriteLine("Situação final do aluno:"+ Aluno.situacao);

        }
    }
}
