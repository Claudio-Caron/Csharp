/*Desenvolver a classe Produto, com os atributos nome,
 * marca, preco e estoque. Além disso, garantir que 
 * o preço e o estoque do produto sejam valores positivos 
 * e criar uma propriedade que mostra detalhadamente
 * as informações do produto, para que seja usado pela equipe de vendas.*/

class Produto
{
    private string Nome {  get; set; }
    public float Preco { get; }
    private string Marca { get; set; }
    private int Estoque { get; set; }
    public Produto(string nome,  float preco)
    {
        this.Nome = nome;
        this.Preco = preco;
        Marca = "NULL";
        Estoque = -1;
    }
    public Produto(string nome, string marca, float preco)
    {
        this.Nome = nome;
        this.Marca = marca;
        this.Preco = preco;
    }
    public void ShowInformations()
    {
        Console.WriteLine($"Nome do produto:{Nome}\nPreco: {Preco}\n");
        if (Marca!="NULL") {
            Console.WriteLine($"Marca: {Marca}");
        }
        if (Estoque == -1)
        {
            Console.WriteLine("Estoque: Não informado");
        }
        else
        {
            Console.WriteLine("Estoque: " + Estoque);
        }
    }
    public void ChangeStock(int stock)
    {
        Estoque=(stock>=0)? stock:(stock*(-1));
    }


}