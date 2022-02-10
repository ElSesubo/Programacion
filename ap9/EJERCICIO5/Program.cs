using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO5
{
    class Program
    {
        static Vehiculo RellenarDatos()
        {
            string mar; string mod; double pot; double price;

            Console.Write("\nIntroduce la marca: ");
            mar = Console.ReadLine();
            Console.Write("Introduce el modelo: ");
            mod = Console.ReadLine();
            Console.Write("Introduce la potencia: ");
            pot = double.Parse(Console.ReadLine());
            Console.Write("Introduce el precio: ");
            price = double.Parse(Console.ReadLine());

            Vehiculo coche = new Vehiculo(mar, mod, pot, price);
            return coche;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuantos vehiculos quieres comprar? ");
            int numV = int.Parse(Console.ReadLine());

            Vehiculo[] coches = new Vehiculo[numV];

            for(int i = 0; i < coches.Length; i++)
            {
                coches[i] = RellenarDatos();
            }

            int posicion = 0;
            double precioMenor = coches[0].VerPrecio();

            for(int y = 0; y < coches.Length; y++)
            {
                if (coches[y].VerPrecio() < precioMenor)
                {
                    posicion = y;
                }
            }

            Console.WriteLine("Información del coche más barato: ");
            coches[posicion].MostrarInfo();
            Console.ReadKey();
        }
    }
}
