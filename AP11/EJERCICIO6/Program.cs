using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO6
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente roberto = new Cliente("54424941H", 12, 5000);
            roberto.MostrarInfo();
            Console.ReadKey();

            List<Fondo> list1 = new List<Fondo>();

            Console.WriteLine("Cuantos fondos vas a crear? ");
            int cantFondos = int.Parse(Console.ReadLine());

            for(int y = 1; y < cantFondos; y++)
            {
                Console.WriteLine("Fondo de inversion {0}:", y);
                Console.Write("Numero de Fondo: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Saldo mensual del Fondo:");
                double saldo = double.Parse(Console.ReadLine());
                list1.Add(new Fondo(numero, saldo));
            }

            ClientePreferente haitian = new ClientePreferente("23434231", 15, 140000, list1);

            haitian.MostrarInfo();

            Console.WriteLine("NIF : {0} Cantidad total del fondos : {1}", haitian.NIF, haitian.CantidadEnFondos());

            haitian.NumeroDeFondos();

            Console.ReadKey();
        }
    }
}
