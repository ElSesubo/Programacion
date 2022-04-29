
namespace AEV7
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblReloj = new System.Windows.Forms.Label();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.btnPresencia = new System.Windows.Forms.Button();
            this.btnPermanencia = new System.Windows.Forms.Button();
            this.btnMantenimiento = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtgvPresencia = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fichajeEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNIF = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPresencia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReloj
            // 
            this.lblReloj.AutoSize = true;
            this.lblReloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReloj.Location = new System.Drawing.Point(693, 87);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(80, 25);
            this.lblReloj.TabIndex = 1;
            this.lblReloj.Text = "RELOJ";
            // 
            // btnEntrada
            // 
            this.btnEntrada.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.Location = new System.Drawing.Point(601, 141);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(259, 65);
            this.btnEntrada.TabIndex = 2;
            this.btnEntrada.Text = "ENTRADA";
            this.btnEntrada.UseVisualStyleBackColor = false;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalida.Location = new System.Drawing.Point(601, 212);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(259, 65);
            this.btnSalida.TabIndex = 3;
            this.btnSalida.Text = "SALIDA";
            this.btnSalida.UseVisualStyleBackColor = false;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // btnPresencia
            // 
            this.btnPresencia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPresencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresencia.Location = new System.Drawing.Point(601, 283);
            this.btnPresencia.Name = "btnPresencia";
            this.btnPresencia.Size = new System.Drawing.Size(259, 65);
            this.btnPresencia.TabIndex = 4;
            this.btnPresencia.Text = "PRESENCIA";
            this.btnPresencia.UseVisualStyleBackColor = false;
            this.btnPresencia.Click += new System.EventHandler(this.btnPresencia_Click);
            // 
            // btnPermanencia
            // 
            this.btnPermanencia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPermanencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermanencia.Location = new System.Drawing.Point(601, 354);
            this.btnPermanencia.Name = "btnPermanencia";
            this.btnPermanencia.Size = new System.Drawing.Size(259, 65);
            this.btnPermanencia.TabIndex = 5;
            this.btnPermanencia.Text = "PERMANENCIA";
            this.btnPermanencia.UseVisualStyleBackColor = false;
            this.btnPermanencia.Click += new System.EventHandler(this.btnPermanencia_Click);
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimiento.Location = new System.Drawing.Point(601, 425);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(259, 65);
            this.btnMantenimiento.TabIndex = 6;
            this.btnMantenimiento.Text = "MANTENIMIENTO";
            this.btnMantenimiento.UseVisualStyleBackColor = false;
            this.btnMantenimiento.Click += new System.EventHandler(this.btnMantenimiento_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(39, 446);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(526, 44);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(678, 42);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(83, 25);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "FECHA";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtgvPresencia
            // 
            this.dtgvPresencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPresencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.apellido,
            this.fichajeEntrega});
            this.dtgvPresencia.Location = new System.Drawing.Point(39, 155);
            this.dtgvPresencia.Name = "dtgvPresencia";
            this.dtgvPresencia.ReadOnly = true;
            this.dtgvPresencia.Size = new System.Drawing.Size(526, 264);
            this.dtgvPresencia.TabIndex = 10;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 180;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 150;
            // 
            // fichajeEntrega
            // 
            this.fichajeEntrega.HeaderText = "Fichaje Entrega";
            this.fichajeEntrega.Name = "fichajeEntrega";
            this.fichajeEntrega.ReadOnly = true;
            this.fichajeEntrega.Width = 150;
            // 
            // txtNIF
            // 
            this.txtNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIF.Location = new System.Drawing.Point(39, 16);
            this.txtNIF.Mask = "########?";
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(526, 116);
            this.txtNIF.TabIndex = 12;
            this.txtNIF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNIF.Click += new System.EventHandler(this.txtNIF_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(890, 516);
            this.ControlBox = false;
            this.Controls.Add(this.txtNIF);
            this.Controls.Add(this.dtgvPresencia);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnMantenimiento);
            this.Controls.Add(this.btnPermanencia);
            this.Controls.Add(this.btnPresencia);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.lblReloj);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPresencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblReloj;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Button btnPresencia;
        private System.Windows.Forms.Button btnPermanencia;
        private System.Windows.Forms.Button btnMantenimiento;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DataGridView dtgvPresencia;
        private System.Windows.Forms.MaskedTextBox txtNIF;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn fichajeEntrega;
    }
}

