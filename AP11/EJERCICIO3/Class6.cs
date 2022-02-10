using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO3
{
    class CongeladoPorNitrogeno : ProductosCongelados
    {
        private string metodoCongelacion;
        private int tiempoExposicion;

        public CongeladoPorNitrogeno(string fcad, string fenv, string pais, int num, double temp, string metodo, int tiempo) : base(fcad, fenv, pais, num, temp)
        {
            metodoCongelacion = metodo;
            tiempoExposicion = tiempo;
        }

        public string getMetodo()
        {
            return metodoCongelacion;
        }

        public int getTiempo()
        {
            return tiempoExposicion;
        }

        public void setMetodo(string nuevo)
        {
            metodoCongelacion = nuevo;
        }

        public void setTiempo(int nuevo)
        {
            tiempoExposicion = nuevo;
        }

        public override void verInfo()
        {
            Console.WriteLine("Metodo de Congelacion : {0} y Tiempo de Exposicion : {1}", metodoCongelacion, tiempoExposicion);
        }
    }
}
