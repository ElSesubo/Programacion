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
    public partial class Form1 : Form
    {
        Form2 form2;
        permanencia permanencia;
        login login;
        private Timer ti;
        public Form1()
        {
            ti = new Timer();
            InitializeComponent();
            ti.Tick += new EventHandler(eventtimer);
            ti.Enabled = true;
            if (conexion.Conexion != null)
            {
                conexion.AbrirConexion();
                fichaje.iniciarBBDD();
                conexion.CerrarConexion();
            }

        }
        private void eventtimer(object ob, EventArgs evt)
        {
            DateTime hoy = DateTime.Now;
            time.Text = hoy.ToString("T");
        }

        private bool ValidarDatos()
        {
            bool ok = true;

            if (txtNIF.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNIF, "Ingresa NIF");
            }
            else if (empleado.CheckNIF(txtNIF.Text) == false)
            {
                ok = false;
                errorProvider1.SetError(txtNIF, "NIF incorrecto.");
            }
            else
            {
                errorProvider1.Clear();
            }
            return ok;
        }

            private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPRESENCIA_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.Show();
        }

        private void btnADMI_Click(object sender, EventArgs e)
        {
            login=new login();
            login.Show();
        }

        private void btnENTRADA_Click(object sender, EventArgs e)
        {
            fichaje f = new fichaje(txtNIF.Text);
            if (ValidarDatos())
            {
                if (conexion.Conexion != null)
                {
                    conexion.AbrirConexion();
                    if (f.DarEntrada() == 1)
                    {
                        MessageBox.Show("Fichaje de entrada realizado con éxito");
                    }
                    else
                    {
                        MessageBox.Show("Ya esta registrado.");
                    }
                    conexion.CerrarConexion();
                }
            }

        }

        private void btnSALIDA_Click(object sender, EventArgs e)
        {
            fichaje f = new fichaje(txtNIF.Text);
            if (ValidarDatos())
            {

                if (conexion.Conexion != null)
                {
                    conexion.AbrirConexion();
                    if (f.DarSalida() == 1)
                    {
                        MessageBox.Show("Fichaje de salida realizado con éxito");
                    }
                    else
                    {
                        MessageBox.Show("El empleado ya salio.");
                    }
                    conexion.CerrarConexion();
                }
            }
        }

        private void btnPermanencia_Click(object sender, EventArgs e)
        {
            permanencia=new permanencia();
            permanencia.Show();
        }
    }
}
