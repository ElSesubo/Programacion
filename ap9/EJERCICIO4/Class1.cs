using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO4
{
    class Tablero
    {
        private int y;
        private int x;

        public Tablero()
        {
            y = 5;
            x = 5;
        }

        public int VerPosY()
        {
            return this.y;
        }

        public int VerPosX()
        {
            return this.x;
        }

        public void MostrarPosicion()
        {
            Console.WriteLine("Coord.x = {0} -- Coord.y = {1}", VerPosX(), VerPosY());
            Console.WriteLine("Pulsar para continuar");
        }

        public void MoverArriba()
        {
            y++;
        }

        public void MoverAbajo()
        {
            y--;
            if(y < 0)
            {
                y = 1;
            }
        }

        public void MoverDerecha()
        {
            x++;
        }

        public void MoverIzquierda()
        {
            x--;
            if(x < 0)
            {
                x = 1;
            }
        }
    }
}
