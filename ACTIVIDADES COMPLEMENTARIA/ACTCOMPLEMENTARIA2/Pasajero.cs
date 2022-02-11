using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTCOMPLEMENTARIA2
{
    class Pasajero
    {
        private string nif;
        private string nombre;
        private string apellido;
        private string nacionalidad;
        private string fechaNacimiento;
        private int numMaletas;

        public Pasajero(string nif, string nom, string ape, string nac, string fech, string num)
        {
            this.nif = nif;
            nombre = nom;
            apellido = ape;
            nacionalidad = nac;
            fechaNacimiento = fech;
            numMaletas = num;
        }

    }
}
