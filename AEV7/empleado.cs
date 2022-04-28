using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AEV7
{
    class empleado
    {
        private string nif;
        private string nombre;
        private string apellidos;
        private Boolean admi;
        private string clave;

        public empleado(string nif, string nombre, string apellidos, Boolean admi, string clave)
        {
            this.nif = nif;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.admi = admi;
            this.clave = clave;
        }

        public string Nif { get => nif; set => nif = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public bool Admi { get => admi; set => admi = value; }
        public string Clave { get => clave; set => clave = value; }

        static public void BorrarEmpleado(string nif)
        {
            string consulta = string.Format("DELETE FROM empleados WHERE nif='{0}';", nif.ToUpper());
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            comando.ExecuteNonQuery();

        }

        static public void addEmployee(string nif, string nom, string ape, bool admin, string pass)
        {
            string add = "INSERT INTO empleados VALUES(\"" + nif.ToUpper() + "\",\"" + nom.ToUpper() + "\",\"" + ape.ToUpper() + "\"," + admin + ",\"" + pass + "\")";
            MySqlCommand comando = new MySqlCommand(add, conexion.Conexion);
            comando.ExecuteNonQuery();
        }

        static public bool CheckNIF(string dni)
        {
            if (dni.Length != 9)
            {
                return false;
            }

            string dniNumbers = dni.Substring(0, dni.Length - 1);
            string dniLeter = dni.Substring(dni.Length - 1, 1);


            var numbersValid = int.TryParse(dniNumbers, out int dniInteger);
            if (!numbersValid)
            {
                return false;
            }
            if (CalculateNIF(dniInteger) != dniLeter)
            {
                return false;
            }
            return true;
        }



        static public string CalculateNIF(int dniNumbers)
        {
            string[] control = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
            var mod = dniNumbers % 23;
            return control[mod];
        }

        static public bool VerifyUser(string username, string password)
        {
            bool correct = false;
            string search = "SELECT nif,clave,admi FROM empleados WHERE nif LIKE \"" + username + "\"";
            MySqlCommand comando = new MySqlCommand(search, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                if ((reader.GetString(0) == username && reader.GetString(1) == password) && (reader.GetBoolean(2) == true))
                    correct = true;
            }
            reader.Close();
            comando.ExecuteNonQuery();
            return correct;
        }
    }
}
