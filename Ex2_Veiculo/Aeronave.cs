using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Veiculo;

internal class Aeronave:IPilotavel, IVoavel
{
    protected int Altitude {  get; set; }   
    protected bool Disponivel {  get; set; }    
    public Aeronave(string piloto, bool disponivel)
    {
        Piloto = piloto;
        Disponivel = disponivel;
    }
    private string Piloto {  get; }
    public string PilotShow() 
    {
        return $"Piloto prinicipal responsável pelo VOO: {Piloto}";
    }

    public bool DisponivelParaPilotar() => Disponivel;
    public void ShowInformations()
    {
        MostrarAltitude();
        Console.WriteLine(PilotShow());
        Console.ReadKey();
        //Informations
    }
    public void MostrarVelocidade() { }
    public void MostrarAltitude()
    {
        Console.Clear();
        Console.WriteLine("Altitude atual: "+ Altitude);
    }
    protected virtual void AlterarAltitude()
    {
        MostrarAltitude();
        Altitude++;
        //Alterar altitude com base em algo
    }

}
