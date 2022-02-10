using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO5
{
    class Program
    {
        private static int NumPubliPrestadas(List<Publicacion> lista)
        {
            int cont = 0;

            foreach (Publicacion p in lista)
            {
                if (p.Prestado())
                    cont++;
            }
            return cont;


        }
        static void Main(string[] args)
        {
            List<Publicacion> list1 = new List<Publicacion>();

            list1.Add(new Libro());
            list1.Add(new Libro());
            list1.Add(new Revista());
            list1.Add(new Revista());

            list1[1].Prestar();
            list1[3].Prestar();

            Console.WriteLine("\nExisten {0} publicaciones prestadas\n", NumPubliPrestadas(list1));

            for (int i = 0; i < list1.Count; i++)
            {
                list1[i].VerInfo();
            }

            Console.ReadKey();
        }
    }
}
