using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tortura_2
{
    class Esfera
    {
        private double raio;
        public void SetRaio(double r)
        {
            raio = r;
        }
        public double GetRaio()
        {
            return raio;
        }
        public double CalcArea()
        {
            return 4 * Math.PI * raio * raio;
        }
        public double CalcVolume()
        {
            return 4 * Math.PI * raio * raio * raio / 3;
        }
    }
}
