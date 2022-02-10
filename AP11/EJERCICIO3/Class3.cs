using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO3
{
    class ProductosCongelados : Producto
    {
        protected double temperatura;

        public ProductosCongelados(string fcad, string fenv, string pais, int num, double temp) : base(fcad, fenv, pais, num)
        {
            temperatura = temp;
        }

        public double getTemperatura()
        {
            return temperatura;
        }

        public void setTemperatura(double nuevo)
        {
            temperatura = nuevo;
        }

        public virtual new void verInfo()
        {
            Console.WriteLine("Temperatura : {0}", temperatura);
        }

    }
}
