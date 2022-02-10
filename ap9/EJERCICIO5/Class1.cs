using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO5
{
    class Vehiculo
    {
        private string marca;
        private string modelo;
        private double potencia;
        private double precio;

        public Vehiculo(string mar, string mod, double pot, double price)
        {
            this.marca = mar;
            this.modelo = mod;
            this.potencia = pot;
            this.precio = price;
        }

        public double VerPrecio()
        {
            return this.precio;
        }

        public void MostrarInfo()
        {
            Console.WriteLine("Marca: {0}\t Modelo: {1}", marca, modelo);
            Console.WriteLine("Potencia: {0}\t Precio: {1}", potencia, precio);
        }

    }
}
