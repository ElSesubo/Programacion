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
        private string fecha;
        private string fichajeEntrada;
        private string fichajeSalida;
        private bool finalizado;

        public int Id { get { return id; } set { id = value;} }
        public string Nif { get { return nif; } set { nif = value; } }
        public string Fecha { get { return fecha; } set { fecha = value; } }
        public string FichajeEntrada { get { return fichajeEntrada; } set { fichajeEntrada = value; } }
        public string FichajeSalida { get { return fichajeSalida; } set { fichajeSalida = value; } }
        public bool Finalizado { get { return finalizado; } set { finalizado = value; } }

        public Registro(int i, string n, string f, string fEntrada, string fSalida, bool fin)
        {
            id = i;
            nif = n;
            fecha = f;
            fichajeEntrada = fEntrada;
            fichajeSalida = fSalida;
            finalizado = fin;
        }

        public Registro()
        {

        }

        public int ficharEntrada(MySqlConnection conexion, string nif, string fecha, string hora)
        {
            int retorno;
            string consulta = string.Format("INSERT INTO fichaje (NIF,fecha,fichajeEntrada) VALUES('{0}','{1}','{2}')", nif, fecha, hora);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public int ficharSalida(MySqlConnection conexion, string hora, string nif)
        {
            int retorno;
            string consulta = string.Format("UPDATE fichaje SET fichajeSalida='{0}',finalizado=true WHERE nif='{1}' AND finalizado=0", hora, nif);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            retorno = comando.ExecuteNonQuery();
            return retorno;
        }


        public static List<Registro> BuscarUsuario(MySqlConnection conexion, string consulta)
        {
            List<Registro> lista = new List<Registro>();

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            try
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Registro user = new Registro(reader.GetInt32(0),reader.GetString(1),reader.GetString(2),reader.GetString(3),reader.GetString(4),reader.GetBoolean(5));
                        lista.Add(user);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            return lista;
        }
    }
}
