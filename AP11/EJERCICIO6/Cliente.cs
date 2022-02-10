using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO6
{
    class Cliente
    {
        protected string nif;
        protected int ncuenta;
        protected double saldo;

        public string NIF { get { return nif; } }
        public int NCuenta { get { return ncuenta; } }
        public double Saldo { get { return saldo; } }

        public Cliente(string nif, int nc, double sal) {
            this.nif = nif;
            ncuenta = nc;
            saldo = sal;
        }

        public virtual void MostrarInfo()
        {
            Console.WriteLine("Nif : {0}", nif);
            Console.WriteLine("Numero de Cuenta : {0}", ncuenta);
            Console.WriteLine("Saldo : {0}", saldo);
        }
    }
}
