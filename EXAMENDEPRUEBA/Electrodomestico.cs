using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENDEPRUEBA
{
    class Electrodomestico
    {
        protected double preciobase = 100;
        protected string color = "BLANCO";
        protected char consumoEner = 'D';
        protected double peso = 5;
        Comprador comprador;

        public Comprador Comprador { get { return comprador; } }

        public Electrodomestico(double pre, string co, char cosm, double p, Comprador comp)
        {
            preciobase = pre;
            ComprobarPrecio(preciobase);
            color = co;
            ComprobarColor(color);
            consumoEner = cosm;
            ComprobarConsum(consumoEner);
            peso = p;
            ComprobarPeso(peso);
            comprador = comp;

        }

        public Electrodomestico()
        {
            Console.WriteLine("Dime el color (solo en blanco, negro y plata) ");
            this.color = Console.ReadLine();
            ComprobarColor(color);

            Console.WriteLine("Dime el consumo energético : ");
            this.consumoEner = char.Parse(Console.ReadLine());
            ComprobarConsum(consumoEner);

            Console.WriteLine("Dime el precio : ");
            this.preciobase = double.Parse(Console.ReadLine());
            ComprobarPrecio(preciobase);

            Console.WriteLine("Dime el peso :");
            this.peso = double.Parse(Console.ReadLine());
            ComprobarPeso(peso);

            Comprador comprador = new Comprador();
        }

        public string ComprobarColor(string color)
        {
            if (color != "BLANCO" && color != "NEGRO" && color != "PLATA")
            {
                color = "BLANCO";
            }
            return color;
        }

        public double PrecioFinal(double peso, char consumE)
        {
            if(consumE == 'A' || consumE == 'B')
            {
                preciobase = preciobase + 100;
            }
            else
            {
                preciobase = preciobase + 80;
            }
            if(peso >= 0 || peso <= 49)
            {
                preciobase = preciobase * 1.10;
            }
            else
            {
                preciobase = preciobase * 1.20;
            }
            return preciobase;
        }

        public char ComprobarConsum(char consumoEner)
        {
            if (consumoEner != 'A' && consumoEner != 'B' && consumoEner != 'C' && consumoEner != 'D')
            {
                consumoEner = 'D';
            }
            return consumoEner;
        }

        public double ComprobarPrecio(double pre)
        {
            if (pre < 0)
            {
                pre = 0;
            }
            return pre;
        }

        public double ComprobarPeso(double peso)
        {
            if(peso < 0)
            {
                peso = 0;
            }
            return peso;
        }
    }
}