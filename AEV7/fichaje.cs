using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.Odbc;

namespace AEV7
{
    internal class fichaje
    {
        private string nif_empleado;
        private DateTime dia;
        private TimeSpan hora_entrada;
        private TimeSpan hora_salida;
        private bool entrada;
        private bool salida;
        private string nombre;
        private string apellido;

        public string Nif_empleado { get => nif_empleado; set => nif_empleado = value; }
        public DateTime Dia { get => dia; set => dia = value; }
        public TimeSpan Hora_entrada { get => hora_entrada; set => hora_entrada = value; }
        public TimeSpan Hora_salida { get => hora_salida; set => hora_salida = value; }
        public bool Entrada { get => entrada; set => entrada = value; }
        public bool Salida { get => salida; set => salida = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public fichaje(string nif)
        {
            this.nif_empleado = nif;
        }

        public fichaje(string nom,string ape, TimeSpan h_en)
        {
            this.nombre = nom;
            this.apellido=ape;
            this.hora_entrada = h_en;
        }

        public fichaje(DateTime dia,TimeSpan h_en,TimeSpan h_sa)
        {
            this.dia = dia;
            this.hora_entrada=h_en;
            this.hora_salida=h_sa;
        }

        public fichaje(string nif_empleado, DateTime dia, TimeSpan hora_entrada, TimeSpan hora_salida, bool entrada, bool salida, string nombre, string apellido)
        {
            this.nif_empleado = nif_empleado;
            this.dia = dia;
            this.hora_entrada = hora_entrada;
            this.hora_salida = hora_salida;
            this.entrada = entrada;
            this.salida = salida;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        static private List<string> guardarNIF()
        {
            List<string> list = new List<string>();
            string consulta1 = "Select nif from empleados;";
            MySqlCommand comando1 = new MySqlCommand(consulta1, conexion.Conexion);
            MySqlDataReader reader = comando1.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                list.Add(reader.GetString(0));
                }
            }
            reader.Close();
            return list;
        }

        static public void iniciarBBDD()
        {

            List<string> lista = guardarNIF();
            for (int i = 0; i < lista.Count; i++)
            {
                if (!comprobar(i))
                {
                    String consulta = "INSERT INTO fichaje (nif_empleado,dia,entrada,salida) " +
                    "VALUES (@nif,@fe,@en,@sa)";

                    MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
                    comando.Parameters.AddWithValue("nif", lista[i].ToString());
                    comando.Parameters.AddWithValue("fe", DateTime.Now.ToString("yyyy/MM/dd"));
                    comando.Parameters.AddWithValue("en", false);
                    comando.Parameters.AddWithValue("sa", false);

                    comando.ExecuteNonQuery();
                }

            }
        }

        private static bool comprobar(int num)
        {
            List<string>Lis=guardarNIF();
            string consulta = String.Format("Select nif_empleado,dia from fichaje WHERE dia='{0}' and nif_empleado='{1}';", DateTime.Now.ToString("yyyy/MM/dd"),Lis[num].ToString());
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                reader.Close();
                return true;
            }
            reader.Close();
            return false;
        }

        //private static int comprobarExiste()
        //{
        //    int count = 0;
        //    string consulta = String.Format("Select dia from fichaje WHERE dia='{0}';", DateTime.Now.ToString("yyyy/MM/dd"));
        //    MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
        //    MySqlDataReader reader = comando.ExecuteReader();
        //    if (reader.HasRows)
        //    {
        //        while (reader.Read())
        //        {
        //            count++;
        //        }
        //    }
        //    reader.Close();
        //    return count;

        //}


        public int DarEntrada()
        {
            int retorno;
            String consulta = "UPDATE fichaje SET hora_entrada=@h_en,entrada=@en WHERE nif_empleado=@nif AND entrada=false;";

            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            comando.Parameters.AddWithValue("nif", this.nif_empleado);
            comando.Parameters.AddWithValue("h_en", DateTime.Now.ToString("HHmmss"));
            comando.Parameters.AddWithValue("en", true);

            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public int DarSalida()
        {
            int retorno;
            String consulta = "UPDATE fichaje SET hora_salida=@h_sa,salida=@sa WHERE nif_empleado=@nif AND salida=false AND entrada=true;";

            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            comando.Parameters.AddWithValue("nif", this.nif_empleado);
            comando.Parameters.AddWithValue("h_sa", DateTime.Now.ToString("HHmmss"));
            comando.Parameters.AddWithValue("sa", true);

            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        static public List<fichaje> presencia_empleado()
        {
            List<fichaje> l_fichajes =new List<fichaje>();
            string consulta = "SELECT nombre,apellidos,hora_entrada FROM empleados INNER JOIN fichaje on nif_empleado=nif WHERE entrada LIKE TRUE AND salida LIKE FALSE;";
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                l_fichajes.Add(new fichaje(reader.GetString(0), reader.GetString(1), reader.GetTimeSpan(2)));
            }
            reader.Close();
            return l_fichajes;
        }

        static public List<fichaje> permanencia_empleado(string nif,DateTime inicio,DateTime fin)
        {
            List<fichaje> l_fichajes = new List<fichaje>();
            string f_inicio = inicio.ToString("yyyyMMdd");
            string f_fin = fin.ToString("yyyyMMdd");
            string consulta = String.Format("SELECT dia,hora_entrada,hora_salida from fichaje WHERE nif_empleado='{0}' and (dia BETWEEN {1} and {2}) and salida like true;",nif.ToUpper(),f_inicio,f_fin);
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                l_fichajes.Add(new fichaje(reader.GetDateTime(0), reader.GetTimeSpan(1), reader.GetTimeSpan(2)));
            }
            reader.Close();
            return l_fichajes;
        }

        static public List<empleado> ListaEmpleado()
        {
            string clave;
            List<empleado> l_empleado = new List<empleado>();
            string consulta = String.Format("SELECT * from empleados;");
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    clave = reader.GetString(4);
                    if (clave == null)
                    {
                        clave = "--";
                    }

                    empleado en = new empleado(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetBoolean(3), clave);
                    l_empleado.Add(en);
                }
                reader.Close();
            }
            return l_empleado;
        }

        static public List<fichaje> ListaFichaje()
        {
            string clave;
            List<fichaje> l_fichaje = new List<fichaje>();
            string consulta = String.Format("SELECT nif_empleado,dia,hora_entrada,hora_salida,entrada,salida,nombre,apellidos from fichaje inner join empleados on nif_empleado=nif WHERE salida=true;");
            MySqlCommand comando = new MySqlCommand(consulta, conexion.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    fichaje fi = new fichaje(reader.GetString(0), reader.GetDateTime(1),reader.GetTimeSpan(2),reader.GetTimeSpan(3),reader.GetBoolean(4),reader.GetBoolean(5), reader.GetString(6), reader.GetString(7));
                    l_fichaje.Add(fi);
                }
            }
            reader.Close();
            return l_fichaje;
        }
    }
}
