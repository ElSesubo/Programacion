using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO3
{
    class CongeladosPorAire : ProductosCongelados
    {
        private double porcentajeN;
        private double porcentajeO;
        private double porcentajeD;
        private double porcentajeV;

        public double PorcentajeN { get { return porcentajeN; } set { porcentajeN = value; } }
        public double PorcentajeO { get { return porcentajeO; } set { porcentajeO = value; } }
        public double PorcentajeD { get { return porcentajeD; } set { porcentajeD = value; } }
        public double PorcentajeV { get { return porcentajeV; } set { porcentajeV = value; } }

        public CongeladosPorAire(string fcad, string fenv, string pais, int num, double temp, double pN, double pO, double pD, double pV) : base(fcad, fenv, pais, num, temp)
        {
            porcentajeN = pN;
            porcentajeO = pO;
            porcentajeD = pD;
            porcentajeV = pV;
        }

        public double getPN()
        {
            return porcentajeN;
        }

        public double getPO()
        {
            return porcentajeO;
        }

        public double getPD()
        {
            return porcentajeD;
        }

        public double getPV()
        {
            return porcentajeV;
        }

        public void setPN(double nuevo)
        {
            porcentajeN = nuevo;
        }

        public void setPO(double nuevo)
        {
            porcentajeO = nuevo;
        }

        public void setPD(double nuevo)
        {
            porcentajeD = nuevo;
        }

        public void setPV(double nuevo)
        {
            porcentajeV = nuevo;
        }

        public override void verInfo()
        {
            Console.WriteLine("Porcentaje de Nitrogeno : {0}", porcentajeN);
            Console.WriteLine("Porcentaje de Oxigeno : {0}", porcentajeO);
            Console.WriteLine("Porcentaje de Dioxido : {0}", porcentajeD);
            Console.WriteLine("Porcentaje de Vapor de Agua : {0}", porcentajeV);
        }
    }
}
