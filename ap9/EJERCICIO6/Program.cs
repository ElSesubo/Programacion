using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO6
{
    class Program
    {
        private static Circulo DiametroMayor(List<Circulo> t)
        {
            Circulo mayor = t[0];
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i].getRadio()>mayor.getRadio()) 
                {
                    mayor = t[i];
                }
            }
            return mayor;
        }
        static void Main(string[] args)
        {
            Circulo fig1 = new Circulo(15);
            Console.WriteLine("Area: {0:N}", fig1.areaC());
            Console.WriteLine("Perímetro: {0:N}", fig1.perimetroC());

            Circulo fig2 = new Circulo(10);
            Console.WriteLine("Area: {0:N}", fig2.areaC());
            Console.WriteLine("Perímetro: {0:N}", fig2.perimetroC());

            List<Circulo> lista1 = new List<Circulo>();
            lista1.Add(fig1);
            lista1.Add(fig2);
            Circulo fig3 = DiametroMayor(lista1);
            Console.WriteLine("\nMayor diámetro: " + fig3.Radio*2);

            Console.ReadKey();

        }
    }
}
