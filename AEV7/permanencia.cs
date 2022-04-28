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
    public partial class permanencia : Form
    {
        public permanencia()
        {
            InitializeComponent();
        }

        private void permanencia_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvEmpleados.Rows.Clear();
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                List<fichaje> lista = fichaje.permanencia_empleado(txtNIF.Text, dtpInicio.Value, dtpFin.Value);
                if (lista.Count == 0)
                {
                    // la lista devuelta está vacía
                    MessageBox.Show("No se ha encontrado ningún empleado: ");
                }
                else
                {
                    //Si existen empleados en la lista se muestran en el DataGridView
                    dgvEmpleados.Rows.Clear();
                    for (int i = 0; i < lista.Count; i++)
                    {
                        dgvEmpleados.Rows.Add(lista[i].Dia.ToString("yyy/MM/dd"),
                           lista[i].Hora_entrada, lista[i].Hora_salida);
                    }

                }
                conexion.CerrarConexion();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
