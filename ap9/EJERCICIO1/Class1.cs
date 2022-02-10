using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO1
{
    class Socio
    {
        private string nombre;
        private int edad;
        private string NIF;
        private char sexo;
        private double peso;
        private double altura;

        public string Nombre { get { return nombre; } set { nombre = value; } }

        public int Edad { get { return edad; } set { edad = value; EsMayorDeEdad(); } }

        public char Sexo { get { return sexo; } set { sexo = value; } }

        public double Peso { get { return peso; } set { peso = value; } }

        public double Altura { get { return altura; } set { altura = value; } }

        public Socio(string nom, int edadP, char sex, double pesoP, double alturaP )
        {
            this.edad = edadP;
            this.nombre = nom.ToUpper();
            this.NIF = GenerarNIF();
            this.sexo = sex;
            this.peso = pesoP;
            this.altura = alturaP;
        }
        
        public Socio()
        {
            Console.Write("\nNombre: ");
            this.nombre = Console.ReadLine().ToUpper();

            Console.Write("Edad: ");
            this.edad = int.Parse(Console.ReadLine());

            Console.Write("Sexo (H/M): ");
            this.sexo = char.Parse(Console.ReadLine());

            Console.Write("Peso: ");
            this.peso = double.Parse(Console.ReadLine());

            Console.Write("Altura: ");
            this.altura = double.Parse(Console.ReadLine());
        }

        public string CalcularIMC()
        {
            double IMC;
            IMC = peso / Math.Pow(altura, 2);
            if(IMC < 18.5)
            {
                return "Bajo";
            }else if(IMC >= 18.5 && IMC < 25){
                return "Normal";
            }
            else
            {
                return "Alto";
            }
        }

        public bool EsMayorDeEdad()
        {
            if (this.edad >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Informa()
        {
            Console.WriteLine("\nNombre: {0}   Dni: {1}\nEdad: {2}          Sexo: {3}\nPeso: {4}         Altura {5}",nombre,GenerarNIF(),edad,sexo,peso,altura);
        }

        public string GenerarNIF()
        {
            Random num = new Random();
            string dni = ""; int valorDni;
            int indice;
            const string tabla = "TRWAGMYFPDXBNJZSQVHLCKE";

            for (int i = 1; i <= 8; i++)
            {
                dni += Convert.ToString(num.Next(10));
            }

            valorDni = Convert.ToInt32(dni);
            indice = valorDni % 23;
            dni = dni + tabla[indice];

            return dni;
        }
    }
}
