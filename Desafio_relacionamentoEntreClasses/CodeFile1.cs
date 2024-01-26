/*Modelar uma classe Conta, que tenha como atributos uma classe Titular, 
 * além de informações da conta,como agência, número da conta, saldo e limite,
 * bem como um método que devolva as informações da conta de forma detalhada.*/
class Conta
{
    
}
class Titular
{
    private Random random = new Random();   
    public int Conta { get; set; }
    public int Agencia { get; set; }
    private int points;
    public Titular()
    {
        Limite = 200;
        points = 0;
        Conta = random.Next(20000,99999);
        Agencia = random.Next(300, 1200);
    }
    private float Saldo { get; set; }
    public float Limite { get => Limite; set { Limite =(points >= 1000) ? value : Limite; } }
    public void Depositar(float deposito)
    {
        float teste;
        //if dinheiro disponível..
        teste=Saldo;
        Saldo += (teste==Saldo)?deposito:0;
        points += (deposito >= 100/*cash*/) ? 100/*points*/ : 0;

    }

    
}
