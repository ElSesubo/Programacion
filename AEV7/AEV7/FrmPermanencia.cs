using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AEV7
{
    public partial class FrmPermanencia : Form
    {
        ConexionBD bdatos = new ConexionBD();
        List<Registro> registros = new List<Registro>();

        public List<Registro> Registros { get { return registros; } set { registros = value; } }

        public FrmPermanencia()
        {
            InitializeComponent();
        }

        private void FrmPermanencia_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string fecha1 = dtpPrimeraFecha.Value.ToString();
            string fecha2 = dtpUltimaFecha.Value.ToString();
            string consulta = "SELECT * FROM fichaje WHERE fecha >= '{0}' AND fecha <= '{1}'";
            if (bdatos.AbrirConexion())
            {
                registros = Registro.BuscarUsuario(bdatos.Conexion, consulta);
                bdatos.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }
            this.Close();
        }
    }
}
