//Declarar uma lista de inteiros e tente acessar um elemento em um índice inexistente.
//Tratar a exceção apropriada.
List<int> MyList = new List<int>();
for (int i = 1; i<=10;  i++)
	MyList.Add(i);
Console.WriteLine("Impresssão da Lista: \n");
try
{
	for (int i = 0; i <= 10; i++)
        Console.WriteLine(MyList[i]+"");
}
catch (Exception e)
{
    Console.WriteLine($"Erro na Impressão: {e.Message}");

}