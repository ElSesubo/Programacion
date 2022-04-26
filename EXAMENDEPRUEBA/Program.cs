using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENDEPRUEBA
{
    class Program
    {
        static Television TelevisionBarata(List<Electrodomestico> electros)
        {
            Television salaverga = new Television();
            foreach (var item in electros)
            {
                if(item.PrecioFinal < salaverga.PrecioFinal)
                {
                    salaverga;
                }
            }
            return salaverga;
        }

        static void Main(string[] args)
        {
            List<Electrodomestico> electrodomesticos = new List<Television>();

            Comprador juan = new Comprador();

            Television pepe = new Television();
            electrodomesticos.Add(pepe);

            Television xaomi = new Television(12, false, 128, "asd", 'D', 12, juan);
            electrodomesticos.Add(xaomi);

            Television paco = new Television(11, false, 128123, "qweqweqweasd", 'A', 12, juan);
            electrodomesticos.Add(paco);

            foreach (var item in electrodomesticos)
            {
                Console.WriteLine("Nombre del comprador : {0}, Precio final : {1}", juan.NomComprador, xaomi.PrecioFinal);
            }


        }
    }
}
