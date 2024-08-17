using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_CAAL;

internal class Simpleclass
{
    public int A {  get; set; }
    public int B {  get; set; }

    public string Somar()
    {
        try
        {
            return $"Soma:{A + B}";
        }
        catch (Exception ex)
        {
            return "Erro no código: " + ex.Message;
        }
    }
}
