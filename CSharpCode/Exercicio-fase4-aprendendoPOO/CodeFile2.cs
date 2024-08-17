class Titular
{
    public string Nome { get; }
    public int Cpf { get; }
    public string Endereco { get; set; }
    public Titular(string nome, int cpf, string endereco)
    {
        Nome = nome;
        Cpf = cpf;
        Endereco = endereco;
    }

}
