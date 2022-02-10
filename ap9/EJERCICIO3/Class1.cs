using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO3
{
    class Cuadrilatero
    {
        private double lado1;
        private double lado2;

        public Cuadrilatero(double lad1, double lad2)
        {
            if (lad1 < 0 || lad2 < 0)
            {
                Console.WriteLine("Datos incorrectos: Algún lado es negativo");
                lado1 = 0; lado2 = 0;
            }
            else
            {
                lado1 = lad1;
                lado2 = lad2;
            }
        }

        public Cuadrilatero(double lad1)
        {
            if (lad1 < 0)
            {
                Console.WriteLine("Datos incorrectos: Algún lado es negativo");
                lado1 = 0; lado2 = 0;
            }
            else
            {
                lado1 = lad1;
                lado2 = lad1;
            }
        }

        public double Perimetro()
        {
            double perimetro;
            perimetro = 2 * lado1 + 2 * lado2;
            return perimetro;
        }

        public double Area()
        {
            double area;
            area = lado1 * lado2;
            return area;
        }
    }
}
