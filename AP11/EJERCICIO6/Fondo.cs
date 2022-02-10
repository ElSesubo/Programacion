using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO6
{
    class Fondo
    {
        private int numero;
        private double cantidadMes;

        public int Numero { get { return numero; } }
        public double CantidadMes { get { return cantidadMes; } }

        public Fondo(int num, double cant)
        {
            numero = num;
            cantidadMes = cant;
        }

        public void Verdatos()
        {
            Console.WriteLine("Numero de Fondo : {0}", numero);
            Console.WriteLine("Cantidad por Mes : {0}", cantidadMes);
        }
    }
}
