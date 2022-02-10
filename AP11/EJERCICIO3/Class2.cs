using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO3
{
    class ProductosRefrigerados : Producto
    {
        protected double temperatura;
        protected string codOrganismo;

        public ProductosRefrigerados(string fcad, string fenv, string pais, int num, string cod, double temp) : base(fcad, fenv, pais, num)
        {
            temperatura = temp;
            codOrganismo = cod;
        }

        public double getTemperatura()
        {
            return temperatura;
        }

        public string getCodOrga()
        {
            return codOrganismo;
        }

        public void setTemperatura(double nuevo)
        {
            temperatura = nuevo;
        }

        public void setCodOrga(string nuevo)
        {
            codOrganismo = nuevo;
        }

        public new void verInfo()
        {
            Console.WriteLine("Temperatura : {0}", temperatura);
            Console.WriteLine("Codigo Organismo : {0}", codOrganismo);
        }
    }
}
