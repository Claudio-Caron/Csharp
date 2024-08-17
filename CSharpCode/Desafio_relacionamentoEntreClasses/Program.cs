// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!");
Conta Conta = new Conta();
Console.WriteLine("Qual seu sexo? (M ou F)");
string sex=Console.ReadLine()!;
Conta.PreencherSex(sex);
Console.Clear();
Console.WriteLine(" sexo: "+ Conta.Titular.Sexo);
Console.WriteLine("fim do programa");