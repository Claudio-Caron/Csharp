// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int x=1;
Adm Controle=new Adm();
while (x == 1 || x == 2)
{
    Console.WriteLine("SISTEMA DE CADASTRAMENTO DE ESTOQUE E PRODUTO");
    Console.WriteLine("Escolha uma opcao?\n 1- Cadastrar produto\n 2- Ver produtos no estoque\n 3- Sair");
    x=int.Parse(Console.ReadLine()!);
    if (x == 1)
    {
        Console.WriteLine("Insira o nome do produto para cadastro:");
        string produto=Console.ReadLine()!;
        Console.WriteLine("Qual a quantidade disponível no estoque?");
        int quant=int.Parse(Console.ReadLine()!);
        Controle.Adc(produto, quant);
    }else if (x == 2)
    {
        Controle.ExibirProdutos();
    }
}