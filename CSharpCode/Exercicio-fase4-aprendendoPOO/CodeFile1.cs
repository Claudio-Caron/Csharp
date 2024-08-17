class Conta
{
    private Random Random = new Random();
    public Titular Titular { get; }
    public int Agencia { get; }
    public int NumeroDaConta { get;}
    public double Saldo { get; set; }
    public double Limite { get; set; }
    public Conta(Titular titular1, int numerodaconta)
    {
        Titular = titular1;
        Agencia = Random.Next(40, 450);
        NumeroDaConta = numerodaconta;
    }

    public string Informacoes => $"Conta nº {this.NumeroDaConta}, Agência {this.Agencia}, Titular: {this.Titular.Nome} - Saldo: {this.Saldo}";
}
