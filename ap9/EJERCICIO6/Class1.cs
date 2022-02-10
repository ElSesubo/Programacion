using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO6
{
    class Circulo
    {
        private double radio

         public double Radio { get { return radio; } }

        public Circulo(double rad)
        {
            this.radio = rad;
            Console.WriteLine("Creado circulo de radio {0}", radio);
        }

        public double getRadio()
        {
            return radio;
        }

        public double perimetroC()
        {
            return (2 * Math.PI * radio);
        }

        public double areaC()
        {
            return (Math.PI * Math.Pow(radio, 2));
        }
    }
}
