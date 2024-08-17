// See https://aka.ms/new-console-template for more information
using Ex3_BankAccounts;

Console.WriteLine("Project -> Ex3_BankAccounts");
Console.WriteLine("Criar uma hierarquia de classes representando contas bancárias, \n" +
    "como ContaCorrente e ContaPoupanca. Utilize herança e o conceito de métodos \n" +
    "virtuais para implementar um método CalcularSaldo que retorne o saldo atual da conta.\n\n");
ContaPoupanca contaPoupanca = new ContaPoupanca(1200, 10000);
ContaCorrente corrente = new ContaCorrente(1200, 3500);
Console.WriteLine($"Numero da conta(Id NACIONAL): {contaPoupanca.IdNacional}");
Thread.Sleep(2000);
contaPoupanca.MostrarSaldo();
Thread.Sleep(2000);
corrente.MostrarSaldo();
Thread.Sleep(2000);

