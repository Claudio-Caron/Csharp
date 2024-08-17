/*Desenvolver uma classe que represente um estoque de produtos,
 * e que tenha as funcionalidades
 * de adicionar novos produtos, 
 * e exibir todos os produtos no estoque.*/
using System.Globalization;

class Estoque {
    public string Produto {  get; set; }   
    public int Quantidade { get; set; }
    public Estoque() => Produto = "Produto nao cadastrado";
}
class Adm
{
    public List<Estoque> Estoques { get; set;}
    public Adm()=> Estoques = new List<Estoque>();
    
    public void Adc(string item, int quantidade)
    {
        Console.Clear();
        Estoque estoque = new Estoque()
        {

            Produto = item,
            Quantidade = quantidade
        };
        Estoques.Add(estoque);
        Console.WriteLine($"Cadastro do produto {item} realizado com sucesso!" +
            $"\nQUANTIDADE NO ESTOQUE: {quantidade}");
        Thread.Sleep(3000); 
        Console.Clear(); 
    }
    public void ExibirProdutos()
    {
        Console.Clear();
        Console.WriteLine("LISTA DE ESTOQUE E PRODUTOS:\n\n");
        foreach (Estoque e in Estoques) { 
            Console.WriteLine(e.Produto);
            Console.WriteLine(e.Quantidade+ "\n");
        }
        Console.WriteLine("Insira qualquer tecla para voltar:");
        Console.ReadKey();
        Console.Clear();
    }
}

