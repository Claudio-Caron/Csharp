using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Veiculo;

internal interface IPilotavel
{
    public void MostrarDadosCart(string piloto);
    public bool DisponivelParaPilotar();
    public string SolicitarNomeDoCart();
}
