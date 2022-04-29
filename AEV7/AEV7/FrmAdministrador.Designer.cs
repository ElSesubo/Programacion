
namespace AEV7
{
    partial class FrmAdministrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dtgvEmpleados = new System.Windows.Forms.DataGridView();
            this.dtgvFichajes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fichajeEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fichajeSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Finalizado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbGestion = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblContrasenya = new System.Windows.Forms.Label();
            this.txtContrasenya = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cbAdministrado = new System.Windows.Forms.CheckBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNIF = new System.Windows.Forms.Label();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.lblGestion = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFichajes)).BeginInit();
            this.gbGestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvEmpleados
            // 
            this.dtgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEmpleados.Location = new System.Drawing.Point(27, 41);
            this.dtgvEmpleados.Name = "dtgvEmpleados";
            this.dtgvEmpleados.ReadOnly = true;
            this.dtgvEmpleados.Size = new System.Drawing.Size(543, 207);
            this.dtgvEmpleados.TabIndex = 0;
            this.dtgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvEmpleados_CellContentClick);
            // 
            // dtgvFichajes
            // 
            this.dtgvFichajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFichajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nif,
            this.Fecha,
            this.fichajeEntrada,
            this.fichajeSalida,
            this.Finalizado});
            this.dtgvFichajes.Location = new System.Drawing.Point(27, 272);
            this.dtgvFichajes.Name = "dtgvFichajes";
            this.dtgvFichajes.ReadOnly = true;
            this.dtgvFichajes.Size = new System.Drawing.Size(543, 207);
            this.dtgvFichajes.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nif
            // 
            this.nif.HeaderText = "NIF";
            this.nif.Name = "nif";
            this.nif.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // fichajeEntrada
            // 
            this.fichajeEntrada.HeaderText = "Fichaje Entrada";
            this.fichajeEntrada.Name = "fichajeEntrada";
            this.fichajeEntrada.ReadOnly = true;
            // 
            // fichajeSalida
            // 
            this.fichajeSalida.HeaderText = "Fichaje Salida";
            this.fichajeSalida.Name = "fichajeSalida";
            this.fichajeSalida.ReadOnly = true;
            // 
            // Finalizado
            // 
            this.Finalizado.HeaderText = "Finalizado";
            this.Finalizado.Name = "Finalizado";
            this.Finalizado.ReadOnly = true;
            this.Finalizado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Finalizado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // gbGestion
            // 
            this.gbGestion.Controls.Add(this.btnEliminar);
            this.gbGestion.Controls.Add(this.btnAgregar);
            this.gbGestion.Controls.Add(this.lblContrasenya);
            this.gbGestion.Controls.Add(this.txtContrasenya);
            this.gbGestion.Controls.Add(this.btnCerrar);
            this.gbGestion.Controls.Add(this.cbAdministrado);
            this.gbGestion.Controls.Add(this.lblApellidos);
            this.gbGestion.Controls.Add(this.txtApellidos);
            this.gbGestion.Controls.Add(this.lblNombre);
            this.gbGestion.Controls.Add(this.txtNombre);
            this.gbGestion.Controls.Add(this.lblNIF);
            this.gbGestion.Controls.Add(this.txtNIF);
            this.gbGestion.Controls.Add(this.lblGestion);
            this.gbGestion.Location = new System.Drawing.Point(609, 41);
            this.gbGestion.Name = "gbGestion";
            this.gbGestion.Size = new System.Drawing.Size(275, 327);
            this.gbGestion.TabIndex = 2;
            this.gbGestion.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(161, 247);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(42, 247);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblContrasenya
            // 
            this.lblContrasenya.AutoSize = true;
            this.lblContrasenya.Location = new System.Drawing.Point(8, 206);
            this.lblContrasenya.Name = "lblContrasenya";
            this.lblContrasenya.Size = new System.Drawing.Size(64, 13);
            this.lblContrasenya.TabIndex = 9;
            this.lblContrasenya.Text = "Contraseña:";
            // 
            // txtContrasenya
            // 
            this.txtContrasenya.Enabled = false;
            this.txtContrasenya.Location = new System.Drawing.Point(78, 203);
            this.txtContrasenya.Name = "txtContrasenya";
            this.txtContrasenya.Size = new System.Drawing.Size(158, 20);
            this.txtContrasenya.TabIndex = 8;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(103, 287);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cbAdministrado
            // 
            this.cbAdministrado.AutoSize = true;
            this.cbAdministrado.Location = new System.Drawing.Point(78, 180);
            this.cbAdministrado.Name = "cbAdministrado";
            this.cbAdministrado.Size = new System.Drawing.Size(100, 17);
            this.cbAdministrado.TabIndex = 7;
            this.cbAdministrado.Text = "Administrador/a";
            this.cbAdministrado.UseVisualStyleBackColor = true;
            this.cbAdministrado.CheckedChanged += new System.EventHandler(this.cbAdministrado_CheckedChanged);
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(20, 146);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(52, 13);
            this.lblApellidos.TabIndex = 6;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(78, 143);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(158, 20);
            this.txtApellidos.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(25, 120);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(78, 117);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(158, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Location = new System.Drawing.Point(45, 94);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(27, 13);
            this.lblNIF.TabIndex = 2;
            this.lblNIF.Text = "NIF:";
            // 
            // txtNIF
            // 
            this.txtNIF.Location = new System.Drawing.Point(78, 91);
            this.txtNIF.MaxLength = 9;
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(118, 20);
            this.txtNIF.TabIndex = 1;
            // 
            // lblGestion
            // 
            this.lblGestion.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.lblGestion.AutoSize = true;
            this.lblGestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestion.Location = new System.Drawing.Point(39, 43);
            this.lblGestion.Name = "lblGestion";
            this.lblGestion.Size = new System.Drawing.Size(197, 18);
            this.lblGestion.TabIndex = 0;
            this.lblGestion.Text = "Gestion de EMPLEADOS";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(24, 20);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(232, 18);
            this.lblEmpleado.TabIndex = 12;
            this.lblEmpleado.Text = "Información de EMPLEADOS:";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Información de FICHAJES:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::AEV7.Properties.Resources._4e3ad7aee69e5da6de7e91b63e3952de_apagar_el_icono_de_trazo;
            this.pictureBox1.Location = new System.Drawing.Point(848, 444);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(694, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cerrar Programa";
            // 
            // FrmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 501);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.gbGestion);
            this.Controls.Add(this.dtgvFichajes);
            this.Controls.Add(this.dtgvEmpleados);
            this.Name = "FrmAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdministrador";
            this.Load += new System.EventHandler(this.FrmAdministrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFichajes)).EndInit();
            this.gbGestion.ResumeLayout(false);
            this.gbGestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvEmpleados;
        private System.Windows.Forms.DataGridView dtgvFichajes;
        private System.Windows.Forms.GroupBox gbGestion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblContrasenya;
        private System.Windows.Forms.TextBox txtContrasenya;
        private System.Windows.Forms.CheckBox cbAdministrado;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNIF;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.Label lblGestion;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nif;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn fichajeEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn fichajeSalida;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Finalizado;
    }
}