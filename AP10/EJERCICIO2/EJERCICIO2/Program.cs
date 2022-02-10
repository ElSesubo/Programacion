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
            Funcion[] funciones = new Funcion[4];

            funciones[0] = new Funcion("Alv", 15);
            funciones[1] = new Funcion("Pepe", 12);
            funciones[2] = new Funcion("Aaaa", 13);
            funciones[3] = new Funcion("paskdpoajpdojapoj", 23);

            Teatro tea = new Teatro("San Jordi", "C/UAUUEU",1,2);
        }
    }
}
