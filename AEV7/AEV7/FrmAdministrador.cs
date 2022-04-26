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
    public partial class FrmAdministrador : Form
    {
        ConexionBD bdatos = new ConexionBD();
        public FrmAdministrador()
        {
            InitializeComponent();
        }

        private void FrmAdministrador_Load(object sender, EventArgs e)
        {
            CargaListaEmpleados();
            CargaListaFichajes();
        }

        private void CargaListaEmpleados()
        {
            string seleccion = "Select * from empleado";
            if (bdatos.AbrirConexion())
            {
                dtgvEmpleados.DataSource = Empleado.BuscarUsuario(bdatos.Conexion, seleccion);
                bdatos.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }
        }
        private void CargaListaFichajes()
        {
            string seleccion = "Select * from fichaje";
            if (bdatos.AbrirConexion())
            {
                dtgvFichajes.DataSource = Registro.BuscarUsuario(bdatos.Conexion, seleccion);
                bdatos.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }
        }

        private bool ValidarDatos()
        {
            bool ok = true;

            if (txtNIF.TextLength > 9 || txtNIF.TextLength < 9)
            {
                ok = false;
                errorProvider1.SetError(txtNIF, "Formato del NIF mal introducido");
            }
            else
            {
                errorProvider1.Clear();
            }

            if (txtNombre.Text == "")
            {
                ok = false;
                errorProvider2.SetError(txtNombre, "Rellenar campo");
            }
            else
            {
                errorProvider2.Clear();
            }

            if (txtApellidos.Text == "")
            {
                ok = false;
                errorProvider3.SetError(txtApellidos, "Rellenar campo");
            }
            else
            {
                errorProvider3.Clear();
            }

            if (txtContrasenya.Text == "")
            {
                ok = false;
                errorProvider4.SetError(txtContrasenya, "Rellenar campo");
            }
            else
            {
                errorProvider4.Clear();
            }
            return ok;
        }

        private void dtgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int resultado = 0;

            try
            {
                if (bdatos.AbrirConexion())
                {
                    if (ValidarDatos())
                    {
                        Empleado emp = new Empleado();
                        emp.Nif = txtNIF.Text;
                        emp.Nombre = txtNombre.Text;
                        emp.Apellido = txtApellidos.Text;
                        emp.Administrador = cbAdministrado.Checked;
                        emp.Password = txtContrasenya.Text;

                        if (emp.CheckNIF(txtNIF.Text)){
                            if (emp.ComprobarNIF(bdatos.Conexion, emp.Nif))
                            {
                                MessageBox.Show("El empleado ya existe");
                            }
                            else
                            {
                                resultado = emp.AgregarEmpleado(bdatos.Conexion, emp);
                                MessageBox.Show("Se ha agregado el empleado exitosamente");
                            }
                        }
                        else
                        {
                            MessageBox.Show("La letra del NIF es erronea");
                        }

                        if (resultado > 0)
                        {
                            LimpiarControles();
                        }
                        bdatos.CerrarConexion();
                        CargaListaEmpleados();
                    }
                }
                else
                {
                    MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally  
            {
                bdatos.CerrarConexion();
            }
        }

        private void LimpiarControles()
        {
            txtNIF.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            cbAdministrado.Checked = false;
            txtContrasenya.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int resultado;

                if (dtgvEmpleados.SelectedRows.Count == 1) 
                {
                    string nifEmpleado = (string)dtgvEmpleados.CurrentRow.Cells[0].Value; 

                    DialogResult confirmacion = MessageBox.Show("Borrado de registro seleccionado. ¿Continuar?",
                                                "Eliminación", MessageBoxButtons.YesNo);

                    if (confirmacion == DialogResult.Yes)
                    {
                        if (bdatos.AbrirConexion())
                        {
                            resultado = Empleado.EliminaEmpleado(bdatos.Conexion, nifEmpleado);
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
                        }
                        bdatos.CerrarConexion();
                        CargaListaEmpleados();
                        CargaListaFichajes();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbAdministrado_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
