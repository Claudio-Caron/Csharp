/*Reescrever a propriedade Ano da classe carro, 
 * para que ela apenas aceite valores
 * entre 1960 e 2023.*/
using System.Reflection.Metadata.Ecma335;

class Carro
{
    private string Modelo { get; set; }
    private int Aano {  get; set; }  
    private int Ano
    {
        get => Aano;
        set => Aano = (value > 1960 && value < 2023) ? value : 0; 

    }
    private float ValorCarro 
    {
        get;set; 
    } 
    
    public Carro(string modelo, int ano)
    {
        Modelo = modelo;
        Ano = ano;
        ValorCarro = 0;
    }
    public string MostrarDados => " - Modelo: " + Modelo + "\n - Ano: " + Ano + "\n - ValorCarro: " + ValorCarro;
    
    public void AtualizarValorVeiculo()
    {
        Console.WriteLine("Qual o preço atualizado do veículo?");
        ValorCarro= int.Parse(Console.ReadLine()!);
        
    }
}
   
