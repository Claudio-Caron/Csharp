using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_BankAccounts
{
    internal class ContaPoupanca : BancoPrincipal
    {
        private double SaldoPoupanca {  get; set; }
        public ContaPoupanca(double saldoprincipal, double saldopoupanca): base(saldoprincipal)
        {
            Saldo=saldopoupanca;
            Classificacao = "Poupanca";
        }
        public override void MostrarSaldo()
        {
            base.MostrarSaldo();
        }
    }
}
