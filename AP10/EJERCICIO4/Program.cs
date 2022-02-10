using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO4
{
    class Program
    {
        static void Main(string[] args)
        {
            Maquina expendedora = new Maquina(30, 1);

            expendedora.VerInfo();
            Console.ReadKey();

            Tarjeta tj1 = new Tarjeta(18);
            Tarjeta tj2 = new Tarjeta(20);

            Console.WriteLine("Primer cliente: {0}", expendedora.Extraer(tj1));
            Console.WriteLine("Segundo cliente: {0}", expendedora.Extraer(tj2));
            Console.ReadKey();

            expendedora.VerInfo();
            Console.ReadKey();

            Console.WriteLine("Saldo de la primera tarjeta {0}, Saldo de la segunda {1}", tj1.getSaldo(), tj2.getSaldo());

            Console.ReadKey();
        }
    }
}
