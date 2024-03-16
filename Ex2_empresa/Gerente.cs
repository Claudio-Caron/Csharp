using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_empresa
{
    internal class Gerente :Empresa
    {
        private double Salario {  get; set; }   
        private string NomeGerente { get; }

        public Gerente(string nome, string nomegerente, float salario): base(nome)
        {
            NomeGerente = nomegerente;
            Salario = Bonus(salario);
        }

        public override void ExibirNome()
        {
            base.ExibirNome();
            Console.WriteLine($"Gerente: {NomeGerente} da empresa: {Nome}");
        }
        public void MostrarSalario()
        {
            base.ExibirNome();
            Console.WriteLine($"Salario do {NomeGerente} com acrescimos da empresa: " +
                $"{Salario}\n");
        }
    }
}
