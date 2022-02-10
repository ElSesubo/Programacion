using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO1
{
    class CuentaBancaria
    {
        protected string titular;
        protected static int numC;
        protected int num;
        protected double saldo;

        public string Titula { get { return titular.ToUpper(); } set { titular = value; } }
        public double Saldo { get { return saldo; } }
        public int Num { get { return num; } set { num = value; } }

        public CuentaBancaria(string nombre)
        {
            titular = nombre;
            saldo = 0;
            numC = 1000;
            num++;
        }

        public virtual void IngresarDinero(double ingreso)
        {
            if(ingreso > 0)
            {
                saldo = saldo + ingreso;
                Console.WriteLine("Tu nuevo saldo es de: {0}", saldo);
            }
            else
            {
                Console.WriteLine("No se pueden ingresar valores negativos");
            }
        }

        public void RetirarDinero(double retiro)
        {
            if(retiro>saldo)
            {
                Console.WriteLine("No tienes suficiente saldo para poder retirar esa cantidad");
            }
            else
            {
                saldo = saldo - retiro;
                Console.WriteLine("Tu nuevo saldo es de: {0}", saldo);
            }
        }

        public void ConsultarCuenta()
        {
            Console.WriteLine("Número de cuenta: {0}",num);
            Console.WriteLine("Titular de la cuenta: {0}", titular);
            Console.WriteLine("Saldo de la cuenta: {0}", saldo);
        }
    }
}
