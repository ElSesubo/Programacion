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
    public partial class FrmContrasenya : Form
    {
        ConexionBD bdatos = new ConexionBD();
        FrmAdministrador formAdmin;
        public FrmContrasenya()
        {
            InitializeComponent();
        }

        private void FrmContrasenya_Load(object sender, EventArgs e)
        {
            formAdmin = new FrmAdministrador();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bdatos.AbrirConexion();
            if (Empleado.VerificarUsuario(bdatos.Conexion, txtNIF.Text.ToUpper(), txtContrasenya.Text) == false)
            {
                MessageBox.Show("Usuario o contraseña incorrecto.");
                bdatos.CerrarConexion();
            }
            else if (Empleado.VerificarUsuario(bdatos.Conexion, txtNIF.Text.ToUpper(), txtContrasenya.Text) == true)
            {
                bdatos.CerrarConexion();
                formAdmin.ShowDialog();
                txtNIF.Clear();
                txtContrasenya.Clear();
                this.Close();
            }
            else bdatos.CerrarConexion();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            txtNIF.Clear();
            txtContrasenya.Clear();
            this.Close();
        }
    }
}
