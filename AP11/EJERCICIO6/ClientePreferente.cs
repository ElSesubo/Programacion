using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO6
{
    class ClientePreferente : Cliente
    {
        private List<Fondo> producto = null;

        public List<Fondo> Producto { get { return producto; } }

        public ClientePreferente(string nif, int nc, double sal, List<Fondo> fon) : base(nif, nc, sal)
        {
            producto = fon;
        }

        public int NumeroDeFondos()
        {
            return producto.Count;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();

            foreach (var item in producto)
            {
                item.Verdatos();
            }
        }

        public double CantidadEnFondos()
        {
            double saldoTotal = 0;
            for(int i = 0; i < producto.Count; i++)
            {
                saldoTotal += producto[i].CantidadMes;
            }
            return saldoTotal;
        }
    }
}
