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
    public partial class FrmPrincipal : Form
    {
        ConexionBD bdatos = new ConexionBD();
        FrmAdministrador formAdmin;
        FrmPermanencia formPer;
        Contrasenya formContra;

        public FrmPrincipal()
        {
            InitializeComponent();
            formAdmin = new FrmAdministrador();
            formPer = new FrmPermanencia();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("d");
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            try
            {
                if (bdatos.AbrirConexion())
                {
                    string hora = DateTime.Now.ToString("HH:mm:ss");
                    string fecha = DateTime.Now.ToString("yyyy/MM/dd");
                    Registro re = new Registro();
                    Empleado emp = new Empleado();
                    if (emp.CheckNIF(txtNIF.Text))
                    {
                        if (emp.ComprobarNIF(bdatos.Conexion, txtNIF.Text))
                        {
                            resultado = re.ficharEntrada(bdatos.Conexion, txtNIF.Text, fecha, hora);
                            MessageBox.Show("Fichaje de entrada realizado");
                        }
                        else
                        {
                            MessageBox.Show("El NIF es erroneo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La letra del NIF es incorrecta");
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

        private void btnSalida_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            try
            {
                if (bdatos.AbrirConexion())
                {
                    Registro re = new Registro();
                    re.Finalizado = true;
                    string hora = DateTime.Now.ToString("HH:mm:ss");
                    Empleado emp = new Empleado();
                    if (emp.ComprobarNIF(bdatos.Conexion, txtNIF.Text))
                    {
                        resultado = re.ficharSalida(bdatos.Conexion, hora, txtNIF.Text);
                        MessageBox.Show("Fichaje de entrada realizado");
                    }
                    else
                    {
                        MessageBox.Show("El NIF es erroneo");
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            txtNIF.Text = "";
            dtgvPresencia.Columns.Clear();
            bdatos.CerrarConexion();
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            formAdmin.ShowDialog();
        }

        private void btnPresencia_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM fichaje WHERE finalizado=0";
            if (bdatos.AbrirConexion())
            {
                dtgvPresencia.DataSource = Registro.BuscarUsuario(bdatos.Conexion, consulta);
                bdatos.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }
        }

        private void btnPermanencia_Click(object sender, EventArgs e)
        {
            formPer.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
