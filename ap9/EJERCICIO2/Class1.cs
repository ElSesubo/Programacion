using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO2
{
    class Triangulo
    {
        private double lado1;
        private double lado2;
        private double lado3;

        public Triangulo(double lad1, double lad2, double lad3)
        {
            this.lado1 = lad1;
            this.lado2 = lad2;
            this.lado3 = lad3;
        }

        public Triangulo()
        {
            Console.WriteLine("Dime la longitud del primer lado: ");
            this.lado1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Dime la longitud del segundo lado: ");
            this.lado2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Dime la longitud del tercer lado: ");
            this.lado3 = double.Parse(Console.ReadLine());
        }

        public bool EsEquilatero()
        {
            if (lado1 == lado2 && lado2 == lado3)
                return true;
            else
                return false;
        }

        public bool EsEscaleno()
        {
            if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
                return true;
            else
                return false;
        }

        public bool EsIsosceles()
        {
            if (EsEquilatero() || EsEscaleno())
                return false;
            else
                return true;
        }
    }
}
