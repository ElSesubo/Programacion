using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO2
{
    class Program
    {
        static void Main(string[] args)
        {

            CuentaBancaria c1 = new CuentaBancaria("Rafita");
            c1.IngresarDinero(2000);
            c1.ConsultarCuenta();
            CuentaBancaria c2 = new CuentaBancaria("Pepe");
            c2.IngresarDinero(4000);
            c2.ConsultarCuenta();
            CuentaBancaria c3 = new CuentaBancaria("Shrek");
            c3.IngresarDinero(20200);
            c3.ConsultarCuenta();
            CuentaBancariaRemunerada c4 = new CuentaBancariaRemunerada("Salita", 0.4);
            c4.IngresarDinero(323);
            c4.ConsultarCuenta();
            Console.ReadKey();
            CuentaNomina c5 = new CuentaNomina("ss");
            c5.IngresarDinero(5000);
            c5.PagoRecibo("aguita", 500);
            c5.VerRecibos();
            c5.ConsultarCuenta();
            Console.ReadKey();
        }
    }
}
