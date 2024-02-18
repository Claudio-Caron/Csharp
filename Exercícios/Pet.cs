
namespace Petshop;

internal class Pet
{
    public Pet(string nome, string raca, bool planoMensal)
    {
        Nome = nome;
        Raca = raca;
        PlanoMensal = planoMensal;
    }
    public string Nome { get; }
    private string Raca { get; }
    private static bool PlanoMensal { get; set; }

    public static void AlterarPlano(bool planomensal) => PlanoMensal = planomensal;
    public string ImprimirInfo=> PlanoMensal ? 
    $"Nome: {Nome}\nRaca: {Raca}\n Status atual: Incluido no Plano Mensal" :
    $"Nome: {Nome}\nRaca: {Raca}\n Status atual: Nao incluido no Plano Mensal";
    

}
