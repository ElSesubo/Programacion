using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO01
{
    class Cuenta
    {
        private int numeroDeCuenta;
        private double saldo;

        public int NumeroDeCuenta { get { return numeroDeCuenta; } }        
        public double Saldo { get { return saldo; } set { saldo = value; } }

        public Cuenta(int num, int sal)
        {
            this.numeroDeCuenta = num;
            this.saldo = sal;
        }

        public int getNumeroDeCuenta()
        {
            return numeroDeCuenta;
        }
        public double getSaldo()
        {
            return saldo;
        }
        public double 

        public double IngresarDinero(double ingreso)
        {
            Console.WriteLine("Cuanto dinero quieres ingresar? ");
            ingreso = int.Parse(Console.ReadLine());
            ingreso = saldo + ingreso;

            return ingreso;
        }

        public double RetirarDinero(double retirado)
        {
            Console.WriteLine("Cuanto dineros quieres retirar? ");
            retirado = int.Parse(Console.ReadLine());
            retirado = saldo - retirado;

            return retirado;
        }

        public void setNumCuenta(int numcue)
        {
            numeroDeCuenta = numcue;
        }
    }
}
