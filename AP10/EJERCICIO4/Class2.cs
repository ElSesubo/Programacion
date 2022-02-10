using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO4
{
    class Maquina
    {
        private double ganancia;
        private int numBotellas;
        private static double precio;
        
        public Maquina(int numBotellas, double pre)
        {
            this.numBotellas = numBotellas;
            precio = pre;
        }

        public int getNumeroBotellas()
        {
            return numBotellas;
        }

        public double getGanancia()
        {
            return ganancia;
        }

        public string Extraer(Tarjeta t)
        {
            if(numBotellas == 0)
            {
                return "No quedan existencias del producto seleccionado";
            }
            else
            {
                if (t.getSaldo() < precio)
                {
                    return "Saldo insuficiente";
                }
                else
                {
                    numBotellas--;
                    t.Descontar(precio);
                    ganancia += precio;
                    return "Botella dispensada";
                }
            }
        }
        public void VerInfo()
        {
            Console.WriteLine("Ganancias : {0} Numero de botellas {1} y Precio {2}", ganancia, numBotellas, precio);
        }
    }
}
