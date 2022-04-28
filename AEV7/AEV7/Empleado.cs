using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;


namespace AEV7
{
    class Empleado
    {
        private string nif;
        private string nombre;
        private string apellido;
        private Boolean administrador;
        private string password;

        public string Nif { get { return nif; } set { nif = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public Boolean Administrador { get { return administrador; } set { administrador = value; } }
        public string Password { get { return password; } set { password = value; } }


        public Empleado(string n, string nom, string ape, Boolean admin, string pass)
        {
            nif = n;
            nombre = nom;
            apellido = ape;
            administrador = admin;
            password = pass;
        }

        public Empleado()
        {

        }
        public bool ComprobarNIF(MySqlConnection conexion, string nif)
        {
            string consulta = string.Format("SELECT * FROM empleado" +
            " WHERE NIF='{0}'", nif);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            { 
                reader.Close();  
                return true;
            }
            else
            {
                reader.Close();  
                return false;
            }
        }

        public static List<Empleado> BuscarUsuario(MySqlConnection conexion, string consulta)
        {
            List<Empleado> lista = new List<Empleado>();

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)   
            {
                while (reader.Read())
                {
                    Empleado user = new Empleado(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                        reader.GetBoolean(3), reader.GetString(4));
                    lista.Add(user);
                }
            }
            return lista;
        }

        static public int AgregarEmpleado(MySqlConnection conexion, Empleado emp)
        {
            int retorno;
            string consulta;

            if (emp.Administrador)
            {
                consulta = string.Format("INSERT INTO empleado VALUES ('{0}','{1}','{2}','{3}','{4}')", emp.nif.ToUpper(), emp.nombre, emp.apellido, 1, emp.password);
            }
            else
            {
                consulta = string.Format("INSERT INTO empleado VALUES ('{0}','{1}','{2}','{3}','{4}')", emp.nif.ToUpper(), emp.nombre, emp.apellido, 0, emp.password);
            }

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        } 

        public int ActualizarEmpleado(MySqlConnection conexion, Empleado emp)
        {
            int retorno;
            string consulta = string.Format("UPDATE empleado SET nombre='{0}',apellido='{1}',administrador='{2}',contraseña='{3}' WHERE NIF='{4}'", emp.nombre, emp.apellido, emp.administrador, emp.password, emp.nif);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int EliminaEmpleado(MySqlConnection conexion, string nif)
        {
            int retorno;
            string consulta = string.Format("DELETE FROM empleado WHERE NIF='{0}'", nif);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public bool CheckNIF(string dni)
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

        public string CalculateNIF(int dniNumbers)
        {
            string[] control = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
            var mod = dniNumbers % 23;
            return control[mod];
        }

        static public bool VerificarUsuario(MySqlConnection conexion, string usuario, string contrasenya)
        {
            bool valido = false;
            string consulta = "SELECT nif,contraseña,administrador FROM empleado WHERE nif LIKE \"" + usuario + "\"";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                if ((reader.GetString(0) == usuario && reader.GetString(1) == contrasenya) && (reader.GetBoolean(2) == true))
                {
                    valido = true;
                }
            }
            reader.Close();
            comando.ExecuteNonQuery();
            return valido;
        }
    }
}
