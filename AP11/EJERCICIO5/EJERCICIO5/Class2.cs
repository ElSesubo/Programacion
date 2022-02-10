using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO5
{
    class Libro : Publicacion
    {
        private string autor;

        public Libro(int c, string a, string autor) : base(c, a)
        {
            this.autor = autor;
        }
        public Libro() : base()
        {
            Console.Write("Nombre de autor:");
            autor = Console.ReadLine();
        }

        public string Autor { get { return autor; } }

        public override void VerInfo()
        {
            Console.WriteLine("Autor : {0}", autor);
        }
    }
}
