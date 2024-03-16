using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_BankAccounts
{
    internal class ContaCorrente:BancoPrincipal 
    {

        public ContaCorrente(float saldo, double saldocorrente) : base(saldo) 
        {
            Saldo= saldocorrente;
            Classificacao = "Corrente";
        }
        public override void MostrarSaldo()
        {
            Console.Clear();
            Console.WriteLine($"Saldo na Conta {Classificacao}: {Saldo} IIII");
        }


    }
}
