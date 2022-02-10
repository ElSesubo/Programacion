using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO03
{
    class Pelicula
    {
        private string nombre;
        private int anyoEstreno;
        private List<Actor> actor = new List<Actor>();

        public Pelicula(string n, int ae, List<Actor> ac)
        {
            nombre = n;
            anyoEstreno = ae;
            actor = ac;
        }

        public void VerDatosPeli()
        {
            Console.WriteLine("Nombre : {0}, Anyo de Estreno {1}", nombre, anyoEstreno);
            Console.WriteLine("Actores: ");
            foreach (var i in actor)
            {
                i.VerDatosActor();
            }
        }

        public List<Actor> getActoresMenores18()
        {
            List<Actor> actoresMenores = new List<Actor>;
            foreach (var i in actoresMenores)
            {
                if (anyoEstreno - i.getAnyoNacimiento() < 18)
                {
                    actoresMenores.Add(i);
                }
            }
            return actoresMenores;
        }
    }
}
