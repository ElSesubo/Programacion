using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO03
{
    class Program
    {
        static void Main(string[] args)
        {
            Pelicula peli;
            Actor persona;
            List<Actor> actores = new List<Actor>();
            string nompeli; 
            int anyoEstreno;
            string nomactor; 
            int anyoNacActor;
            char continuar;

            Console.WriteLine("Dime el nombre de la película: ");
            nompeli = Console.ReadLine();
            Console.WriteLine("Dime el anyo de Estreno de la peli: ");
            anyoEstreno = int.Parse(Console.ReadLine());
            Console.WriteLine("\nIntroduce los Actores de la pelicula. ");
            do
            {
                Console.Write("Nombre: ");
                nomactor = Console.ReadLine();
                Console.Write("Año de nacimiento: ");
                anyoNacActor = int.Parse(Console.ReadLine());

                persona = new Actor(nomactor, anyoNacActor);
                actores.Add(persona);

                Console.Write("Anyadir más actores? (S/N) ");
                continuar = char.Parse(Console.ReadLine().ToUpper());
            } while (continuar == 'S');

            peli = new Pelicula(nompeli, anyoEstreno, actores);

            List<Actor> menores18 = peli.getActoresMenores18();
            Console.WriteLine("\nActores menores de 18 años en el momento del estreno:");
            foreach (Actor per in menores18)
            {
                per.VerDatosActor();
            }

            Console.ReadLine();
        }
    }
}
