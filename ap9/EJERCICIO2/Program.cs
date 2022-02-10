using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo primerT = new Triangulo(20, 32, 12);
            Console.WriteLine("Equilatero: " + primerT.EsEquilatero());
            Console.WriteLine("Escaleno: " + primerT.EsEscaleno());
            Console.WriteLine("Isosceles: " + primerT.EsIsosceles());

            Console.ReadKey();

            Triangulo segundoT = new Triangulo();
            Console.WriteLine("Equilatero: " + segundoT.EsEquilatero());
            Console.WriteLine("Escaleno: " + segundoT.EsEscaleno());
            Console.WriteLine("Isosceles: " + segundoT.EsIsosceles());

            Console.ReadKey();
        }
    }
}
