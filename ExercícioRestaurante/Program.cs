// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*Modelar um sistema para um restaurante com classes como Restaurante,
 * Mesa, Pedido e Cardapio. A classe Restaurante deve ter mesas que 
 * podem ser reservadas e um cardápio com itens que podem ser pedidos.
 * Os pedidos podem estar associados a uma mesa.*/
class Restaurante {
    List<Mesa> Mesas;
    public Restaurante()
    {
        Mesas= new List<Mesa>();
    }

}
class Mesa
{
    public List<Pedido> pedidos;    
    Random Random = new Random();   
    public bool Reserva {  get; set; }  
    private int Id { get; }
    public Mesa()
    {
        pedidos = new List<Pedido>();
        Reserva = false;
        Id = Random.Next(1,45); 
    }
}
class Pedido
{
    public int Id { get;  }
    private float Valor { get; set; }   
    public Pedido(int id)
    {
        Id= id;
        Valor = 0;  
    }

}
class Cardapio
{

  
    private Hamburguer Ham {  get; set; }  
    private BatataFrita Bat {  get; set; }  

    public Cardapio() { 
        Ham = new Hamburguer();
        Bat = new BatataFrita();
    } 

}
    class BatataFrita
    {
        string nome;
        int porcoes;
        float valor;
        bool disponivel;
    }
class Hamburguer
{
    public int Estoque { get; set; }    
    string Nome { get;  } 
    private int Quantidade { get; set; }
    double ValorProduto { get; set; }
    public bool Disponivel
        {
        get
        {
            return Disponivel;
        }
        set
        {
            if (Estoque >= Quantidade)
            {
                Disponivel = true;
            }
            else
            {
                Disponivel = false;
            }
        }
        }
    public Hamburguer()
    {
        Disponivel = true;
        Nome = "Hamburguer";
        ValorProduto =29.9;
        Quantidade = 0;
        Estoque = 0;
    }
    public void DisponibilidadeProduto()
    {
        Disponivel= false;
    }
}