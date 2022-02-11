using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENDEPRUEBA
{
    class Comprador 
    {
        private int idComprador;
        private string nomComprador;

        public int IdComprador { get { return idComprador; } set { idComprador = value; } }
        public string NomComprador { get { return nomComprador; } set { nomComprador = value; } }

        public Comprador()
        {
            Console.WriteLine("Dime la id del Comprador : ");
            idComprador = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime el nombre del comprador : ");
            nomComprador = Console.ReadLine();
            if(nomComprador == "")
            {
                nomComprador = "No identificado";
            }
        }
    }
}
