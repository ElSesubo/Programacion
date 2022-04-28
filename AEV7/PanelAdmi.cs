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
    public partial class PanelAdmi : Form
    {
        public PanelAdmi()
        {
            InitializeComponent();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtClave.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private bool ValidarDatos()
        {
            bool ok = true;
            if (txtNIF.Text == "")
            {
            ok = false;
            errorProvider1.SetError(txtNIF, "Ingresa NIF");
            }
            else if (empleado.CheckNIF(txtNIF.Text)==false)
            {
                ok = false;
                errorProvider1.SetError(txtNIF, "NIF introducido no es valido.");
            }
            else if (txtNombre.Text == "") 
            { 
                ok = false; 
                errorProvider1.SetError(txtNombre, "Ingresa Nombre"); 
            }
            else if (txtApellidos.Text == "") 
            { 
                ok = false; 
                errorProvider1.SetError(txtApellidos, "Ingresa Apellidos"); 
            }
            else if (txtClave.Text == "" && checkAdmin.Checked == true) 
            { 
                ok = false; 
                errorProvider1.SetError(txtClave, "Ingresa contraseña para el usuario administrador."); 
            }
            else
            {
            errorProvider1.Clear();
            }
            return ok;
        }



        private void PanelAdmi_Load(object sender, EventArgs e)
        {
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                dgvEmpleados.DataSource = fichaje.ListaEmpleado();
                conexion.CerrarConexion();
            }
            dgvEmpleados.Columns[3].ReadOnly = true;
            if (checkAdmin.Checked == false)
            {
                txtClave.Enabled = false;
            }

        }

        private void refres()
        {
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                dgvEmpleados.DataSource = fichaje.ListaEmpleado();
                conexion.CerrarConexion();
            }
            dgvEmpleados.Columns[3].ReadOnly = true;
            if (checkAdmin.Checked == false)
            {
                txtClave.Enabled = false;
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string a=txtNIF.Text;
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                empleado.BorrarEmpleado(a);
                conexion.CerrarConexion();
            }
            refres();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (conexion.Conexion != null)
                {
                    conexion.AbrirConexion();
                    empleado.addEmployee(txtNIF.Text, txtNombre.Text, txtApellidos.Text, checkAdmin.Checked, txtClave.Text);
                    conexion.CerrarConexion();
                    MessageBox.Show("Usuario agregado con éxito.");
                }
            }
            refres();
        }

        private void dgvInforme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                dgvInforme.DataSource = fichaje.ListaFichaje();
                conexion.CerrarConexion();
            }
            refres();
        }

        private void checkAdmin_Click(object sender, EventArgs e)
        {
            if (checkAdmin.Checked == false)
            {
                txtClave.Enabled = false;
            }
            else
            {
                txtClave.Enabled=true;
            }
        }
    }
}
