using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO2
{
    class Funcion
    {
        private string nombre;
        private double precio;

        public Funcion(string nom, double pre)
        {
            nombre = nom;
            precio = pre;
        }

        public string Nombre()
        {
            return nombre;
        }

        public double Precio()
        {
            return precio;
        }

        public void CambiarNombre(string nom)
        {
            nombre = nom;
        }

        public void CambiarPrecio(double pre)
        {
            precio = pre;
        }
    }
}
