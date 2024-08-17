using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_Notific;

internal class Sms: INotificavel
{
    public void EnviarNotificacao()
    {
        Console.WriteLine("NEW SMS\n Seus dados foram atualizados com sucesso!");
    }
}
