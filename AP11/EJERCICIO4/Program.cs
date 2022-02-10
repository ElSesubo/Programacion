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
            class Deporte
        {
            protected string nombre;
            protected string tipopuntuacion;

            public void Puntuacion(int num)
            {
                Console.Write("Puntuación del deporte {0}: ", num);
                Console.WriteLine("{0} --> {1}", nombre, tipopuntuacion);
            }

        }

        class Baloncesto : Deporte
        {
            public Baloncesto()
            {
                nombre = "Baloncesto";
                tipopuntuacion = "Canasta";
            }

        }

        class Rugby : Deporte
        {
            public Rugby()
            {
                nombre = "Rugby";
                tipopuntuacion = "Ensayo";
            }
        }

        class Futbol : Deporte
        {
            public Futbol()
            {
                nombre = "Futbol";
                tipopuntuacion = "Gol";
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Deporte[] d = new Deporte[5];
                Random num = new Random();
                int valor;

                for (int i = 0; i < d.Length; i++)
                {
                    valor = num.Next(3);
                    switch (valor)
                    {
                        case 0:
                            d[i] = new Baloncesto();
                            break;
                        case 1:
                            d[i] = new Rugby();
                            break;
                        case 2:
                            d[i] = new Futbol();
                            break;
                    }

                    d[i].Puntuacion(i + 1);
                }
                Console.ReadKey();

            }
        }
    }
}
