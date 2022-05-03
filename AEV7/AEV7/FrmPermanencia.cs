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
            dtgvPermanencia.Rows.Clear();
            lblHoras.Text = "";
            txtNIFPer.Text = "";
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (bdatos.AbrirConexion()) // Comprobamos que se abre la conexión
                {
                    lblHoras.Visible = false;
                    if (dtpInicio.Value <= dtpFinal.Value && dtpFinal.Value >= dtpInicio.Value) // Comprobamos que los valores entre los dateTimePickers no se contradigan
                    {
                        lblHoras.Visible = true;
                        List<Registro> lista = Registro.permanencia(bdatos.Conexion, txtNIFPer.Text, dtpInicio.Value, dtpFinal.Value); // Utilizamos el metodo permanencia para cargar una lista
                        if (lista.Count == 0)
                        {
                            MessageBox.Show("No se ha encontrado ningún empleado");
                            lblHoras.Text = "";
                            lblHoras.Visible = false;
                        }
                        else
                        {
                            TimeSpan total = new TimeSpan(0, 0, 0);
                            dtgvPermanencia.Rows.Clear();
                            for (int i = 0; i < lista.Count; i++) // Cargamos fila a fila los datos que queremos que se visualizen en el datagrid
                            {
                                dtgvPermanencia.Rows.Add(lista[i].Fecha.ToString("yyyy/MM/dd"),
                                   lista[i].FichajeEntrada, lista[i].FichajeSalida, lista[i].HorasTotales);
                                total += lista[i].HorasTotales;
                            }
                            lblHoras.Text = total.ToString();

                        }
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                bdatos.CerrarConexion();
            }
        }

        private void dtgvPermanencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FrmPermanencia_Load(object sender, EventArgs e)
        {
            lblHoras.Visible = false;
        }

        private void txtNIFPer_Click(object sender, EventArgs e)
        {
            txtNIFPer.Select(0,0);
        }
    }
}
