using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_CAAL;
//Escrever um programa que solicite dois números a e b lidos do teclado
//e realize a divisão de a por b. Caso essa operação não seja possível,
//mostrar uma mensagem no console que deixe claro o erro ocorrido.
internal class Operacao
{
    public int A {  get;  }
    public int B {  get; }
    public Operacao(int a, int b)
    {
        A = a;
        B = b;
    }
    public string Dividir()
    {
        try
        {
            return $"Resultado da divisão: {A/B}";
        }
        catch(Exception e)
        {
            return "Erro! Divisão por zero\n"+e.Message;
        }
    }
}
