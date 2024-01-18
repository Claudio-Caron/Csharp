class ContaBancaria
{
    public float saldo;
    public float indicador;
    public string titular;
    int senha;
    public void ImprimirDados()
    {
        Console.WriteLine($" SALDO DA CONTA: {saldo}");
        Console.WriteLine($" TITULAR DA CONTA: {titular}");
        Console.WriteLine($" INDICADOR DE CONTA: {indicador}");
    }

}