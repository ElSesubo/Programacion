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
            Console.WriteLine("Nombre del teatro: ");
            string nombreTea = Console.ReadLine();
            Console.Write("Dirección del teatro: ");
            string dirTea = Console.ReadLine();

            string[] nomfunciones = new string[4];
            double[] prefunciones = new double[4];
            Console.WriteLine("Indica nombre y precio de cada función");
            for (int i = 0; i < nombrefunciones.Length; i++)
            {
                Console.Write("Nombre de funcion {0}: ", i + 1);
                nombrefunciones[i] = Console.ReadLine();
                Console.Write("Precio de funcion {0}: ", i + 1);
                preciofunciones[i] = double.Parse(Console.ReadLine());
            }

            Teatro principal = new Teatro(nombreTea, dirTea, nomfunciones, prefunciones);

            Console.WriteLine("Nombre del teatro : {0} y Dirección {1}", principal.getNombre(), principal.gerDireccion());

            Console.WriteLine("Funcion: {0}  Precio: {1}",principal.DevuelveNombreFuncion(0), principal.DevuelvePrecioFuncion(0));

            principal.ActualizarNombreFuncion(2, "Prietos en aprietos");

            principal.ActualizarPrecioFuncion(2, 14.4);

            Console.ReadKey();
        }
    }
}
