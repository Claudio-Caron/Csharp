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
    public Pedido()
    {
      
    }

}
class Cardapio
{
    public bool Hamburguer {  get; set; }   
    public bool 

}