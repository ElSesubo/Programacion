using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO5
{
    class Revista : Publicacion
    {
        private int numero;
        
        public Revista(int c, string a, int n) : base(c, a)
        {
            numero = n;
        }
        public Revista() : base()
        {
            Console.Write("Numero de la Revista: ");
            numero = int.Parse(Console.ReadLine());
        }

        public int Numero { get { return numero; } }

        public override void VerInfo()
        {
            Console.WriteLine("Numero : {0}", numero);
        }
    }
}
