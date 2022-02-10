using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO4
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Menu menu1 = new Menu();
            Tablero tabla = new Tablero();

            do
            {
                menu1.VisualizarMenu();
                Console.Write("Introduce Opción (1..5) : ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        tabla.MoverArriba();
                        tabla.MostrarPosicion();
                        break;
                    case 2:
                        tabla.MoverAbajo();
                        tabla.MostrarPosicion();
                        break;
                    case 3:
                        tabla.MoverIzquierda();
                        tabla.MostrarPosicion();
                        break;
                    case 4:
                        tabla.MoverDerecha();
                        tabla.MostrarPosicion();
                        break;

                        Console.Clear();
                        Console.ReadKey();
                }
            } while (opcion != 5);
        }
    }
}
