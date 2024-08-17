

namespace Petshop;

internal class Dono
{
    public string Nome { get; }
    public List<Pet> Pets { get; set; }

    public Dono (string nome)
    {
        Nome = nome;
        Pets = new List<Pet> 
        { 
        new("Pity", "Pinscher", true),
        new("Pity", "Pinscher", true),
        new("Pity", "Pinscher", true),
        new("Pity", "Pinscher", true),
        new("Pity", "Pinscher", true)
        };
        //como é inicialização eu faço busca
    }   
    //ao adicionar, testa se é igual a algum dos pets, se for, o dono dele recebe o nome do pet

}
