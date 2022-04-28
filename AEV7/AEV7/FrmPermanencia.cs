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
        public FrmPermanencia()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (bdatos.AbrirConexion())
            {
                if(dtpInicio.Value <= dtpFinal.Value)
                {
                    dtgvPermanencia.Columns.Clear();
                    dtgvPermanencia.DataSource = Registro.permanencia(bdatos.Conexion, txtNIFPer.Text, dtpInicio.Value, dtpFinal.Value);
                    bdatos.CerrarConexion();
                }
                else
                {
                    MessageBox.Show("Las fechas no están bien comprendidas");
                }
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }
        }
    }
}
