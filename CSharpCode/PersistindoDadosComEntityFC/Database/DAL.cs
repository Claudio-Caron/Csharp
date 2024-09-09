using Microsoft.Identity.Client;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistindoDadosComEntityFC.Database
{
    internal abstract class DAL<T>
    {
        public abstract IEnumerable<T> Listar();

        public abstract void Alterar(T objeto);

        public abstract void Deletar(T objeto);

        public abstract void Adicionar(T objeto);

        public abstract T? RecuperarPeloNome(string nome);
    }
}
