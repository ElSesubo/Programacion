using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AEV7
{
    internal class conexion
    {
        
        private static MySqlConnection instancia = null;
        private static readonly object padlock = new object();


        private conexion() { }


        public static MySqlConnection Conexion
        {
            get
            {
                lock (padlock)
                {
                    if (instancia == null)
                    {
                        instancia = new MySqlConnection();
                        string server = "server=127.0.0.1;";
                        string port = "port=3306;";
                        string database = "database=bd_gestion_empleados;";
                        string usuario = "uid=root;";
                        string password = "pwd=;";
                        instancia.ConnectionString = server + port + database + usuario + password;
                    }
                    return instancia;
                }
            }
        }


        public static void AbrirConexion()
        {
            if (instancia != null)
                instancia.Open();
        }


        public static void CerrarConexion()
        {
            if (instancia != null)
                instancia.Close();
        }
    }
}
