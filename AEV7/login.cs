using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AEV7
{
    public partial class login : Form
    {
        PanelAdmi panelAdmi;
        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            conexion.AbrirConexion();
            if (empleado.VerifyUser(txtUsuario.Text.ToUpper(), txtClave.Text) == false)
            {
                MessageBox.Show("Usuario o contraseña incorrecto.");
                conexion.CerrarConexion();
            }
            else if (empleado.VerifyUser(txtUsuario.Text.ToUpper(), txtClave.Text) == true)
            {
                conexion.CerrarConexion();
                panelAdmi = new PanelAdmi();
                panelAdmi.Show();
                this.Close();
            } else conexion.CerrarConexion();
        }
        private void bntVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
