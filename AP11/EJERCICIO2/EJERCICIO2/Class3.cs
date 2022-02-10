using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO2
{
    class CuentaNomina : CuentaBancaria
    {
        List<string> concepto = new List<string>();

        public CuentaNomina(string nom) : base(nom) { 
        }
        public void PagoRecibo(string pago, double cantidad)
        {
            if (cantidad <= saldo)  
            {
                saldo -= cantidad;       
                concepto.Add(pago);    
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }

        public void VerRecibos()
        {
            Console.WriteLine();
            for (int i = 0; i < concepto.Count; i++)
            {
                Console.WriteLine("Recibo {0}:\t{1}", i + 1, concepto[i]);
            }
        }
    }
}
