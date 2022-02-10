using System;
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
        private Funcion[] precios;

        public Teatro(string nom, string dir, Funcion[] func, Funcion[] pre)
        {
            nombre = nom;
            direccion = dir;
            funciones = func;
            precios = pre;
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
