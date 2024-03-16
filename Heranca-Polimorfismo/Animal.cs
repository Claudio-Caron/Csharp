using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Polimorfismo
{
    internal class Animal
    {
        public Animal() 
        {
            Vivo = true;
        } 
        protected float Tamanho {  get; set; }  
        private bool Vivo {  get; set; } 
        
        public string ShowStatus() =>Vivo? return 
    }
}
