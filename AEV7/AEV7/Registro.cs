using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace AEV7
{
    class Registro
    {

        private int id;
        private string nif;
        private DateTime fecha;
        private TimeSpan fichajeEntrada;
        private TimeSpan fichajeSalida;
        private bool finalizado;
        private TimeSpan horasTotales;

        public int Id { get { return id; } set { id = value;} }
        public string Nif { get { return nif; } set { nif = value; } }
        public DateTime Fecha { get { return fecha; } set { fecha = value; } }
        public TimeSpan FichajeEntrada { get { return fichajeEntrada; } set { fichajeEntrada = value; } }
        public TimeSpan FichajeSalida { get { return fichajeSalida; } set { fichajeSalida = value; } }
        public TimeSpan HorasTotales { get { return horasTotales; } set { horasTotales = value; } }
        public bool Finalizado { get { return finalizado; } set { finalizado = value; } }

        /// <summary>
        /// Constructor de la clase Registro que guarda todos los datos excepto las horas totales realizadas
        /// </summary>
        /// <param name="i">identificador del registro</param>
        /// <param name="n">nif del empleado</param>
        /// <param name="f">fecha del registro</param>
        /// <param name="fEntrada">hora de entrada</param>
        /// <param name="fSalida">hora de salida</param>
        /// <param name="fin">booleano que nos permite saber si están realizados los dos fichajes</param>
        public Registro(int i, string n, DateTime f, TimeSpan fEntrada, TimeSpan fSalida, bool fin)
        {
            id = i;
            nif = n;
            fecha = f;
            fichajeEntrada = fEntrada;
            fichajeSalida = fSalida;
            finalizado = fin;
        }

        /// <summary>
        /// Constructor de la clase Registro para utilizar en la permanencia
        /// </summary>
        /// <param name="f">fecha del registro</param>
        /// <param name="fEntrada">hora de entrada</param>
        /// <param name="fSalida">hora de salida</param>
        public Registro(DateTime f, TimeSpan fEntrada, TimeSpan fSalida)
        {
            fecha = f;
            fichajeEntrada = fEntrada;
            fichajeSalida = fSalida;
            horasTotalesES();
        }

        /// <summary>
        /// Constructor de la clase Registro para utilizar en la presencia
        /// </summary>
        /// <param name="id">identificador del registro</param>
        /// <param name="n">nif del empleado</param>
        /// <param name="f">fecha del registro</param>
        /// <param name="fEntrada">hora de entrada</param>
        public Registro(int id, string n, DateTime f,TimeSpan fEntrada)
        {
            this.id = id;
            nif = n;
            fecha = f;
            fichajeEntrada = fEntrada;
        }

        /// <summary>
        /// Constructor vacío
        /// </summary>
        public Registro()
        {

        }

        /// <summary>
        /// Inserta la información del fichaje de Entrada en la base de datos
        /// </summary>
        /// <param name="conexion">Conexión con la base de datos</param>
        /// <param name="nif">nif del empleado</param>
        /// <returns>1 o 0 para comprobar si el proceso se ha realizado exitosamente</returns>
        public int ficharEntrada(MySqlConnection conexion, string nif)
        {
            int retorno;
            string consulta = string.Format("INSERT INTO fichaje (NIF,fecha,fichajeEntrada,fichajeSalida) VALUES('{0}',@fecha,@h_en,@h_sal)", nif);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("fecha", DateTime.Now.ToString("yyyyMMdd"));
            comando.Parameters.AddWithValue("h_en", DateTime.Now.ToString("HHmmss"));
            comando.Parameters.AddWithValue("h_sal", DateTime.MinValue.ToString("HHmmss"));

            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        /// <summary>
        /// Actualiza el fichaje de entrada para proveer la hora de salida y cambiar el estado a finalizado
        /// </summary>
        /// <param name="conexion">Conexión con la base de datos</param>
        /// <param name="nif">nif del empleado</param>
        /// <returns>1 o 0 para comprobar si el proceso se ha realizado exitosamente</returns>
        public int ficharSalida(MySqlConnection conexion, string nif)
        {
            int retorno;
            string consulta = string.Format("UPDATE fichaje SET fichajeSalida=@h_sal,finalizado=1 WHERE nif='{0}' AND finalizado=0", nif);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("h_sal", DateTime.Now.ToString("HHmmss"));

            retorno = comando.ExecuteNonQuery();
            return retorno;
        }


        /// <summary>
        /// Selecciona todos los registros para posteriormente visualizarlos en un dataGridView
        /// </summary>
        /// <param name="conexion">Conexión con la base de datos</param>
        /// <returns>Lista de registros cargada</returns>
        public static List<Registro> buscarRegistro(MySqlConnection conexion)
        {
            List<Registro> fichajes = new List<Registro>();
            string consulta = "SELECT * FROM fichaje";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                fichajes.Add(new Registro(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2), reader.GetTimeSpan(3), reader.GetTimeSpan(4), reader.GetBoolean(5)));
            }
            reader.Close();
            return fichajes;
        }

        /// <summary>
        /// Selecciona la id, el nif, la fecha y el fichaje de entrada donde no este fichada la salida para posteriormente visualizarlos en un dataGridView
        /// </summary>
        /// <param name="conexion">Conexión con la base de datos</param>
        /// <returns>Lista de registros cargada</returns>
        public static List<Registro> presencia(MySqlConnection conexion)
        {
            List<Registro> fichajes = new List<Registro>();
            string consulta = "SELECT id,nif,fecha,fichajeEntrada FROM fichaje WHERE finalizado=0;";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                fichajes.Add(new Registro(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2), reader.GetTimeSpan(3)));
            }
            reader.Close();
            return fichajes;
        }

        /// <summary>
        /// Selecciona la fecha, el fichaje de entrada y salida dentro del rango de dos fechas para posteriormente visualizarlos en un dataGridView
        /// </summary>
        /// <param name="conexion">Conexión con la base de datos</param>
        /// <param name="nif">nif del empleado</param>
        /// <param name="inicio">fecha de inicio</param>
        /// <param name="fin">fecha final</param>
        /// <returns>Lista de registros cargada</returns>
        static public List<Registro> permanencia(MySqlConnection conexion, string nif, DateTime inicio, DateTime fin)
        {
            List<Registro> fichajes = new List<Registro>();
            string fechaIni = inicio.ToString("yyyyMMdd");
            string fechaSal = fin.ToString("yyyyMMdd");
            string consulta = String.Format("SELECT fecha,fichajeEntrada,fichajeSalida FROM fichaje WHERE nif='{0}' AND (fecha BETWEEN {1} and {2}) AND finalizado=TRUE;", nif.ToUpper(), fechaIni, fechaSal);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                fichajes.Add(new Registro(reader.GetDateTime(0), reader.GetTimeSpan(1), reader.GetTimeSpan(2)));
            }
            reader.Close();
            return fichajes;
        }

        /// <summary>
        /// Realiza un calculo para saber las horas totales entre dos horas
        /// </summary>
        public void horasTotalesES()
        {
            this.horasTotales = this.fichajeSalida - this.fichajeEntrada;
        }

        /// <summary>
        /// Verifica que el registro de salida este hecho 
        /// </summary>
        /// <param name="conexion">Conexión con la base de datos</param>
        /// <param name="usuario">nif del empleado</param>
        /// <returns>True en caso de que un fichaje esté abierto y false en el caso contrario</returns>
        public bool VerificarFinalizado(MySqlConnection conexion, string usuario)
        {
            bool valido = false;
            string consulta = "SELECT * FROM fichaje WHERE nif LIKE \"" + usuario + "\"";
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetBoolean(5) == false)
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
