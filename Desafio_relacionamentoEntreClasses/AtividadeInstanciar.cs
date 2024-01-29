/*Modelar uma classe Conta, que tenha como atributos uma classe Titular, 
 * além de informações da conta,como agência, número da conta, saldo e limite,
 * bem como um método que devolva as informações da conta de forma detalhada.*/
class Conta
{
    public Conta()
    {
        limit = 200;
        points = 0;
        NumConta = Random.Next(20000,99999);
        Agencia = 304;
        Console.WriteLine("Vamos iniciar!\n Por favor, digite seu nome:");
        Titular.Name = Console.ReadLine()!;
        Console.WriteLine("Seu nome foi cadastrado com sucesso\n Pressione enter para continuarmos o cadastro");
        Console.ReadKey();  
        Console.Clear();
        Console.WriteLine($"Seu novo numero de conta é: {NumConta}\nNumero da agencia: {Agencia}\n\n " +
            $"\tPressione enter para continuarmos o cadastro.\"");
        Console.ReadKey();
        Console.Clear();
    }
    public void PreencherSex(string sex)
    {
        Titular.Sexo=sex;   
    }
    public Titular Titular= new Titular();
    private Random Random = new Random();
    public int NumConta{ get; set;/*se tal valor se mostrar booleano, em caso de uma possível troca de conta(
                                   se tratando do campo Agencia)*/ }
    public int Agencia { get; set; }
    private int points;
    private float Saldo { get; set; }

    private float limit;
    public float Limite { get => limit; set => limit = points >= 1000 ? value : limit;  }
    public void Depositar(float deposito)
    {
        float teste;
        //if dinheiro disponível..
        teste=Saldo;
        Saldo += (teste==Saldo)?deposito:0;
        points += (deposito >= 100/*cash*/) ? 100/*points*/ : 0;

    }
    
}
class Titular
{

    public Random Random = new Random();    
    public Titular(){
        Sexo = " SEXO NAO DEFINIDO";
        Name = " NOME DE PORTADOR ÑAO DEFINIDO!";
        SecurityKey = Random.Next(100,999);
    }
    public int SecurityKey {  get;}
    public string Sexo { get; set; }
    public string Name { get; set; }
    //let the name and the points on in this class


}
