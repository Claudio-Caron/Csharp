using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_empresa
{
    internal  class Empresa
    { 
        public string Nome {  get; set; }
        public Empresa(string nome)
        {
            Nome = nome;
        }
        public virtual void ExibirNome() 
        {
            Console.Clear();    
            Console.WriteLine($"Nome da empresa: {Nome}\n");
        }
        public double Bonus(float salario) => (salario * 0.03) + salario;
    }
}
