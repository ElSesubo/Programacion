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

        /// <summary>
        /// Constructor de la clase empleado
        /// </summary>
        /// <param name="n">nif del empleado</param>
        /// <param name="nom">nombre del empleado</param>
        /// <param name="ape">apellido del empleado</param>
        /// <param name="admin">credencial de que el empleado es administrador o no</param>
        /// <param name="pass">contraseña del empleado(solamente administradores)</param>
        public Empleado(string n, string nom, string ape, Boolean admin, string pass)
        {
            nif = n;
            nombre = nom;
            apellido = ape;
            administrador = admin;
            password = pass;
        }

        /// <summary>
        /// Constructor vacío
        /// </summary>
        public Empleado()
        {

        }

        /// <summary>
        /// Comprueba la existencia de un nif en la base de datos.
        /// </summary>
        /// <param name="conexion">Conexión con la base de datos</param>
        /// <param name="nif">Nif del empleado</param>
        /// <returns>true en caso de que exista, false en el contrario</returns>
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

        /// <summary>
        /// Selecciona todos los campos de la tabla empleado para posteriormente introducirlo en un dataGridView.
        /// </summary>
        /// <param name="conexion">Conexión con la base de datos</param>
        /// <returns>Lista de Empleados</returns>
        public static List<Empleado> buscarEmpleado(MySqlConnection conexion)
        {
            List<Empleado> empleados = new List<Empleado>();
            string consulta = "SELECT * FROM empleado";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                empleados.Add(new Empleado(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetBoolean(3), reader.GetString(4)));
            }
            reader.Close();
            return empleados;
        }

        /// <summary>
        /// Agrega un empleado a la tabla empleado
        /// </summary>
        /// <param name="conexion">Conexión con la base de datos</param>
        /// <param name="emp">Objeto de clase empleado cargado</param>
        /// <returns>1 o 0 para comprobar si el proceso se ha realizado exitosamente</returns>
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

        /// <summary>
        /// Elimina un empleado de la tabla empleado
        /// </summary>
        /// <param name="conexion">Conexión con la base de datos</param>
        /// <param name="nif">string referente al nif del empleado</param>
        /// <returns>1 o 0 para comprobar si el proceso se ha realizado exitosamente</returns>
        public static int EliminaEmpleado(MySqlConnection conexion, string nif)
        {
            int retorno;
            string consulta = string.Format("DELETE FROM empleado WHERE NIF='{0}'", nif);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        /// <summary>
        /// Comprueba si la letra del NIF es correcta
        /// </summary>
        /// <param name="dni">string referente a el nif del empleado</param>
        /// <returns>true en caso de que sea correcta y false en el caso contrario</returns>
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

        /// <summary>
        /// Calcula la letra del nif basandose en los números del nif
        /// </summary>
        /// <param name="dniNumbers">numeros del nif</param>
        /// <returns>string con la letra correspondiente</returns>
        public string CalculateNIF(int dniNumbers)
        {
            string[] control = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
            var mod = dniNumbers % 23;
            return control[mod];
        }

        /// <summary>
        /// Verifica que el empleado sea administrador
        /// </summary>
        /// <param name="conexion">Conexión con la base de datos</param>
        /// <param name="usuario">nif del empleado</param>
        /// <param name="contrasenya">contraseña del empleado</param>
        /// <returns>True en caso de que el usuario sea administrador y la contraseña sea valida y false en el caso contrario</returns>
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
