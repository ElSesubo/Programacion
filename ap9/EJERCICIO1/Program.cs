using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Información del primer socio: ");
            Console.WriteLine("=================================");
            Socio soc1 = new Socio();

            soc1.Informa();

            Console.WriteLine("\n{0} tiene un peso {1}",soc1.Nombre,soc1.CalcularIMC());
            if (soc1.EsMayorDeEdad())
            {
                Console.WriteLine("\n{0} es mayor de edad",soc1.Nombre);
            }
            else
            {
                Console.WriteLine("\n{0} es menor de edad", soc1.Nombre);
            }
            Console.ReadKey();

            Console.WriteLine("\nInformación del segundo socio: ");
            Console.WriteLine("=================================");
            Socio soc2 = new Socio();

            soc2.Informa();

            Console.WriteLine("\n{0} tiene un peso {1}", soc2.Nombre, soc2.CalcularIMC());
            if (soc2.EsMayorDeEdad())
            {
                Console.WriteLine("\n{0} es mayor de edad", soc2.Nombre);
            }
            else
            {
                Console.WriteLine("\n{0} es menor de edad", soc2.Nombre);
            }

            Console.ReadKey();
        }
    }
}
