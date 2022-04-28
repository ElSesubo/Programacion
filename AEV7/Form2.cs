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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                List<fichaje> lista = fichaje.presencia_empleado();
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
                        dgvEmpleados.Rows.Add(lista[i].Nombre,
                           lista[i].Apellido, lista[i].Hora_entrada);
                    }

                }
                conexion.CerrarConexion();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            /*
            string consulta = "Select * from fichaje where entrada like true and salida like false";

            conexion.AbrirConexion();

            conexion.CerrarConexion();
            */


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
