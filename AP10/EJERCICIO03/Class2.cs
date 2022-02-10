using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO03
{
    class Actor
    {
        private string nombre;
        private int anyoNac;

        public Actor(string n, int an)
        {
            nombre = n;
            anyoNac = an;
        }

        public int getAnyoNacimiento()
        {
            return anyoNac;
        }

        public void VerDatosActor()
        {
            Console.WriteLine("Nombre {0}, Anyo de nacimiento {1}",nombre, anyoNac);
        }
    }
}
