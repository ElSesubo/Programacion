using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO3
{
    class ProductosFrescos : Producto
    {
        public ProductosFrescos(string fcad, string fenv, string pais, int num) : base(fcad, fenv, pais, num)
        {

        }

        public new void verInfo()
        {
            base.verInfo();
        }
    }
}
