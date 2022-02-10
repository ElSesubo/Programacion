
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO01
{
    class Cliente
    {
        private string nombre;
        private string apellido;
        private string nif;
        private Array[] cuentas;

        public string Nombre { get { return nombre; } }
        public string Apellidos { get { return apellido; } }
        public string NIF { get { return nif; } }

        public Cliente(string nom, string ape, string nf)
        {
            this.nombre = nom;
            this.apellido = ape;
            this.nif = nf;
        }

        public string getNombre()
        {
            return nombre;
        }

        public string getApellido()
        {
            return apellido;
        }

        public string getNif()
        {
            return nif;
        }

        public double ConsultarSaldo(int num)
        {
            return cuentas[num].getSaldo();
        }

        public void IngresarDinero(int num, double importe)
        {
            cuentas[num].Ingresar(importe);
        }

        public void RetirarDinero(int num, double importe)
        {
            cuentas[num].Retirar(importe);
        }
    }
}
