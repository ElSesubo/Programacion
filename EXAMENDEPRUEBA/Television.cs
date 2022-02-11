using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENDEPRUEBA
{
    class Television : Electrodomestico
    {
        private int pulgadas = 20;
        private bool sintonizadorTDT = false;

        public Television() : base()
        {
            Console.WriteLine("Dime el numero de pulgadas: ");
            pulgadas = int.Parse(Console.ReadLine());

            Console.WriteLine("Esta sintonizada? ");
            string sinto = Console.ReadLine();
            sintonizadorTDT = ComprobarSintonizador(sinto);
        }

        public Television(int pul, bool sint, double pre, string co, char cosm, double p, Comprador comp) : base(pre, co, cosm, p, comp)
        {
            pulgadas = pul;
            sintonizadorTDT = sint;
        }

        public int getPulgadas()
        {
            return pulgadas;
        }

        public bool getSintonizacion()
        {
            return sintonizadorTDT;
        }

        public void setPulgada(int pul)
        {
            pulgadas = pul;
        }

        public void setSintonizacion(bool sin)
        {
            sintonizadorTDT = sin;
        }

        public double PrecioFinal()
        {
            base.PrecioFinal;
            double precioFinal = 0;
            if (res > 40)
            {
                precioFinal = precioFinal*1.30;
            }
            if (sin == true)
            {
                precioFinal = precioFinal * 50;
            }
            return precioFinal;
        }

        public bool ComprobarSintonizador(string sin)
        {
            if(sin == "si")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
