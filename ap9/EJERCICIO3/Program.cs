using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO3
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado1 = 17.2;
            double lado2 = 20.2;

            Cuadrilatero forma1 = new Cuadrilatero(lado1, lado2);
            Console.WriteLine("Rectangulo con un perimertro de {0} y un area de {1}", forma1.Perimetro(), forma1.Area());

            Console.ReadKey();

            double lado3 = 12.2;

            Cuadrilatero forma2 = new Cuadrilatero(lado3);
            Console.WriteLine("Rectangulo con un perimertro de {0} y un area de {1}", forma2.Perimetro(), forma2.Area());

            Console.ReadKey();

        }
    }
}
