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
        FrmContrasenya formContra;
        FrmPermanencia formPer;
        

        public FrmPrincipal()
        {
            InitializeComponent();
            formContra = new FrmContrasenya(); // Creamos dos formularios
            formPer = new FrmPermanencia();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true; // Inicializamos el reloj
            dtgvPresencia.RowHeadersVisible = false; // Ocultamos las columnas de el datagridview
            dtgvPresencia.Columns[0].Visible = false;
            dtgvPresencia.Columns[1].Visible = false;
            dtgvPresencia.Columns[2].Visible = false;
            dtgvPresencia.Columns[3].Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString("HH:mm:ss"); 
            lblFecha.Text = DateTime.Now.ToString("d");
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            try
            {
                if (bdatos.AbrirConexion()) // Comprobamos la conexión
                {
                    Registro re = new Registro();
                    Empleado emp = new Empleado();
                    if (emp.CheckNIF(txtNIF.Text)) // Comprobamos la letra del NIF
                    {
                        if (emp.ComprobarNIF(bdatos.Conexion, txtNIF.Text.ToUpper())) // Comprobamos que el NIF exista
                        {
                            if(re.VerificarFinalizado(bdatos.Conexion, txtNIF.Text) == false) // Comprobamos que el registro esté cerrado
                            {
                                if (re.ficharEntrada(bdatos.Conexion, txtNIF.Text.ToUpper()) == 1) // realizamos el fichaje
                                {
                                    MessageBox.Show("Fichaje de entrada realizado");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ya hay un registro de entrada abierto");
                            }
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
            try
            {
                if (bdatos.AbrirConexion()) // Comprobamos la conexión
                {
                    Registro re = new Registro();
                    Empleado emp = new Empleado();
                    if (emp.CheckNIF(txtNIF.Text)) // Comprobamos la letra del NIF
                    {
                        if (emp.ComprobarNIF(bdatos.Conexion, txtNIF.Text.ToUpper())) // Comprobamos que el NIF exista
                        {
                            if (re.ficharSalida(bdatos.Conexion, txtNIF.Text.ToUpper()) == 1) // realizamos el fichaje
                            {
                                MessageBox.Show("Fichaje de salida realizado");
                            }
                            else
                            {
                                MessageBox.Show("No hay ningun fichaje abierto"); // En caso de que no halla ningún fichaje abierto saltara un messageBox
                            }
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            dtgvPresencia.RowHeadersVisible = false;
            dtgvPresencia.Columns[0].Visible = false;
            dtgvPresencia.Columns[1].Visible = false;
            dtgvPresencia.Columns[2].Visible = false;
            dtgvPresencia.Columns[3].Visible = false;
            txtNIF.Text = "";
            dtgvPresencia.Columns.Clear();
            bdatos.CerrarConexion();
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            formContra.ShowDialog();
        }

        private void btnPresencia_Click(object sender, EventArgs e)
        {
            if (bdatos.AbrirConexion())
            {
                List<Registro> lista = Registro.presencia(bdatos.Conexion); // Utilizamos el método presencia para cargar la lista de registros
                if (lista.Count == 0)
                {
                    MessageBox.Show("No se ha encontrado ningún registro");
                }
                else
                {
                    dtgvPresencia.RowHeadersVisible = true; // visualizamos las columnas de el datagridView
                    dtgvPresencia.Columns[0].Visible = true;
                    dtgvPresencia.Columns[1].Visible = true;
                    dtgvPresencia.Columns[2].Visible = true;
                    dtgvPresencia.Columns[3].Visible = true;
                    dtgvPresencia.Rows.Clear();
                    for (int i = 0; i < lista.Count; i++) // Cargamos fila a fila los datos que queremos que se visualizen en el datagrid
                    {
                        dtgvPresencia.Rows.Add(lista[i].Id,lista[i].Nif,lista[i].Fecha.ToString("yyyy/MM/dd"),lista[i].FichajeEntrada); 
                    }

                }
                bdatos.CerrarConexion();
            }
            else
            {
                MessageBox.Show("No se ha podido abrir la conexión con la Base de Datos");
            }
        }

        private void btnPermanencia_Click(object sender, EventArgs e)
        {
            formPer.ShowDialog(); // Abrimos el formulario de la permanencia
        }
    }
}
