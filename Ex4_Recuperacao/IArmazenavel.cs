using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Criar uma interface chamada IArmazenavel com métodos Salvar e Recuperar.
//Implemente essa interface em duas classes, Arquivo e BancoDeDados.
//Os métodos Salvar e Recuperar devem exibir mensagens simulando
//a ação de salvar e recuperar dados.
namespace Ex4_Recuperacao;

internal interface IArmazenavel
{
    void Salvar();
    void Recuperar();

}
