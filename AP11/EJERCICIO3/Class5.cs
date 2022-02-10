using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO3
{
    class CongeladoPorAgua : ProductosCongelados
    {
        private double salinidad;

        public CongeladoPorAgua(string fcad, string fenv, string pais, int num, double sal, double temp) : base(fcad, fenv, pais, num, temp)
        {
            salinidad = sal;
        }

        public double getSalinidad()
        {
            return salinidad;
        }

        public void setSalinidad(double nuevo)
        {
            salinidad = nuevo;
        }

        public override void verInfo()
        {
            Console.WriteLine("Salinidad : {0}", salinidad);
        }
    }
}
