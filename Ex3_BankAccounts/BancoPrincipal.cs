using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_BankAccounts
{
    internal class BancoPrincipal
    {
        public string Classificacao {  get; set; }
        protected double Saldo {  get; set; }
        
        private Random random = new Random();
        public int IdNacional { get; }
        public BancoPrincipal(double saldo)
        {
            Saldo = saldo;
            Classificacao = "Principal";
            IdNacional = random.Next(1, 10000);
        }
        public virtual void MostrarSaldo()
        {
            Console.Clear();
            Console.WriteLine($"#Saldo atual da conta {Classificacao}: {Saldo}#");
        }
        public virtual double CalcularSaldoImposto => Saldo- (Saldo*13.44/100);
    }
}
