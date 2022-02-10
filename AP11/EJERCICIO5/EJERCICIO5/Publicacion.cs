using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO5
{
    class Publicacion
    {
        protected int codigo;
        protected string anyo;
        protected bool prestado;

        public Publicacion(int c, string a)
        {
            codigo = c;
            anyo = a;
            prestado = false;
        }

        public Publicacion()
        {
            Console.WriteLine("\nIntroduce datos de nueva publicación:");
            Console.Write("Codigo de publicación: ");
            codigo = int.Parse(Console.ReadLine());
            Console.Write("Año de Publicación: ");
            anyo = Console.ReadLine();
            prestado = false;
        }

        public int Codigo { get { return codigo; } set { codigo = value; } }
        public string Anyo { get { return anyo; } set { anyo = value; } }

        public bool Prestado()
        {
            return prestado;
        }

        public void Prestar()
        {
            if (prestado == false)
            {
                prestado = true;
                Console.WriteLine("\nPréstamo realizado. Publicación con código {0}", codigo);
            }
            else
            {
                Console.WriteLine("No es posible realizar el prestamo");
                Console.WriteLine("La publicación con código {0} está prestada", codigo);
            }
        }

        public void Devolver()
        {
            if(prestado == true)
            {
                prestado = false;
                Console.WriteLine("\nDevolucion realizada. Publicacion con codígo {0}", codigo);
            }
            else
            {
                Console.WriteLine("No se puede realizar la devolucion");
                Console.WriteLine("La publicacion con código {0} no está prestada", codigo);
            }
        }

        public virtual void VerInfo()
        {
            Console.WriteLine("Codigo : {0}", codigo);
            Console.WriteLine("Anyo : {0}", anyo);
            Console.WriteLine("Prestado : {0}", prestado);
        }
    }
}
