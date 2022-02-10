using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO1
{
    class CuentaBancariaRemunerada : CuentaBancaria
    {
        private double porcentaje;
        public CuentaBancariaRemunerada(string nom, double por): base(nom)
        {
            porcentaje = por;
        }

        public override void IngresarDinero(double ingreso)
        {
            if (ingreso > 0)
            {
                saldo += ingreso + ingreso*porcentaje;
                Console.WriteLine("Tu nuevo saldo es de: {0}", saldo);
            }
            else
            {
                Console.WriteLine("No se pueden ingresar valores negativos");
            }
        }
    }
}
