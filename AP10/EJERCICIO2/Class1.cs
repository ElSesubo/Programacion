ºusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO2
{
    class Teatro
    {
        private string nombre;
        private string direccion;
        private Funcion[] funciones = new Funcion[4];

        public Teatro(string nom, string dir, string[] func, double[] pre)
        {
            nombre = nom;
            direccion = dir;
            for (int i = 0; i < funciones.Length; i++)
            {
                funciones[i] = new Funcion(func[i], pre[i]);
            }
        }
        public string getNombre()
        {
            return nombre;
        }
        public string getDireccion()
        {
            return direccion;
        }

        public void CambiarNombre(string nom)
        {
            nombre = nom;
        }

        public void CambiarDireccion(string dir)
        {
            direccion = dir;
        }

        public void ActualizarNombreFuncion(int n_funcion, string nom)
        {
            funciones[n_funcion].CambiarNombre(nom);
        }

        public void ActualizarPrecioFuncion(int n_funcion, double pre)
        {
            precios[n_funcion].CambiarPrecio(pre);
        }

        public string DevuelveNombreFuncion(int n_funcion)
        {
            return funciones[n_funcion].Nombre();
        }

        public double DevuelvePrecioFuncion(int n_funcion)
        {
            return funciones[n_funcion].Precio();
        }

    }
}
