using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3e4e5_04CAAL;

internal class PessoaInfo
{
    private double _alturaEmMetros;
    public PessoaInfo(string nome, char sexo, double alturaEmMetros, int idade)
    {
        Nome = nome;
        Sexo = sexo;
        AlturaEmMetros = alturaEmMetros;
        Idade = idade;
    }
    public int Idade {  get; set; }
    public double AlturaEmMetros 
    { 
        get
        {
            return _alturaEmMetros;
        }
        set
        {
            if (value > 2.7)
                _alturaEmMetros = (value / 100);
            else
                _alturaEmMetros = value;
        }
    }
    public string? Nome { get;  }
    
    public char Sexo {  get; }
    public override string ToString() => $"Nome : {Nome}\nAltura : {AlturaEmMetros}Metros\nSexo : {Sexo}\nIdade : {Idade}\n";
}
