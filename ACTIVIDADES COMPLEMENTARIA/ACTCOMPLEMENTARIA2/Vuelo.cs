using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTCOMPLEMENTARIA2
{
    class Vuelo
    {
        private int codVuelo;
        private string fechaVuelo;
        private string horaVuelo;
        private string ciudadOri;
        private string ciudadDes;
        private int capMaxPasajeros;
        private List<Pasajero> pasajeros;

        public Vuelo(int cod, string fech, string ho, string cidO, string cidD, int cap, List<Pasajero> pas)
        {
            codVuelo = cod;
            fechaVuelo = fech;
            horaVuelo = ho;
            ciudadOri = cidO;
            ciudadDes = cidD;
            capMaxPasajeros = cap;
            pasajeros = pas;
        }
    }
}
