using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_Recuperacao;

internal class Arquivo: IArmazenavel
{
    public void Salvar()
    {
        Console.Clear();
        Console.WriteLine("Seus dados foram salvos com sucesso");
    }
    public void Recuperar()
    {
        Console.Clear();
        Console.WriteLine("Seus dados foram recuperados com sucesso");
    }
}
