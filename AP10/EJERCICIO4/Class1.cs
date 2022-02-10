using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO4
{
    class Tarjeta
    {
        private double saldo;

        public Tarjeta(double saldo)
        {
            this.saldo = saldo;
        }
        
        public double getSaldo()
        {
            return saldo;
        }

        public void Descontar(double dinero)
        {
            saldo -= dinero;
        }

        public void Recargar(double dinero)
        {
            saldo += dinero;
        }

        public void VerSaldo()
        {
            Console.WriteLine("Tu saldo actual es de {0}", saldo);
        }
    }
}
