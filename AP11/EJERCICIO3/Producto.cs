using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO3
{
    class Producto
    {
        private string fechaCaducidad;
        private string fechaEnvasado;
        private string paisOrigen;
        private int numLote;

        public Producto(string fcad, string fenv, string pais, int num)
        {
            fechaCaducidad = fcad;
            fechaEnvasado = fenv;
            paisOrigen = pais;
            numLote = num;
        }

        public string getFechaCaducidad()
        {
            return fechaCaducidad;
        }
        public string getFechaEnvasado()
        {
            return fechaEnvasado;
        }
        public string getPaisOrigen()
        {
            return paisOrigen;
        }
        public int getNumLote()
        {
            return numLote;
        }

        public void setFechaCaducidad(string nuevo)
        {
            fechaCaducidad = nuevo;
        }

        public void setFechaEnvasado(string nuevo)
        {
            fechaEnvasado = nuevo;
        }

        public void setPaisOrigen(string nuevo)
        {
            paisOrigen = nuevo;
        }

        public void setNumLote(int nuevo)
        {
            numLote = nuevo;
        }

        public virtual void verInfo()
        {
            Console.WriteLine("Fecha de Caducidad : {0}", fechaCaducidad);
            Console.WriteLine("Fecha de Envasado : {0}", fechaEnvasado);
            Console.WriteLine("Pais de Origen : {0}", paisOrigen);
            Console.WriteLine("Numero de Lote: {0}", numLote);
        }
    }
}
