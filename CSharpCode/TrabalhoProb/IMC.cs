using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoProb
{
    internal class IMC
    {
        public IMC(double alturam, double pesokg)
        {
            AlturaM = alturam;
            PesoKG = pesokg;
        }
        private double _alturaM;
        public double AlturaM
        {
            get
            {
                return _alturaM / 100;
            }
            set
            {
                _alturaM=value;
            }
        }
        public double PesoKG { get; set; }

        public double CalcularImc()=>PesoKG/(AlturaM*AlturaM);

    }
}
