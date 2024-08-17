using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    

namespace Ex1_Geometricas;

internal class Circulo: IForma

{
    public Circulo() 
    {
        Area = "Area nao definida";
        Perimetro = 0;
    }
    public string Area { get; set; }    
    public double Perimetro { get; set; }
    public void CalcularArea(float haltura)
    {
        Area = ((haltura / 2)* (haltura / 2)*3.1415).ToString();
    }
    public void CalcularPerimetro(float haltura)
    {

        Perimetro=3.1415 * haltura;
    }
    public void MostrarDados()
    {
        Console.Clear();
        Console.WriteLine($"Area do Circulo: {Area} -> Perimetro: {Perimetro}");
        Console.ReadKey();
    }
}
