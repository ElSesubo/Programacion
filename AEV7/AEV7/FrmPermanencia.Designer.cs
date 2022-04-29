
namespace AEV7
{
    partial class FrmPermanencia
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
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtgvPermanencia = new System.Windows.Forms.DataGridView();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNIFPer = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fichajeentrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fichajeSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasTotales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPermanencia)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(211, 376);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(109, 20);
            this.dtpInicio.TabIndex = 2;
            // 
            // dtgvPermanencia
            // 
            this.dtgvPermanencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPermanencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.Fichajeentrada,
            this.fichajeSalida,
            this.horasTotales});
            this.dtgvPermanencia.Location = new System.Drawing.Point(78, 162);
            this.dtgvPermanencia.Name = "dtgvPermanencia";
            this.dtgvPermanencia.ReadOnly = true;
            this.dtgvPermanencia.Size = new System.Drawing.Size(625, 181);
            this.dtgvPermanencia.TabIndex = 3;
            this.dtgvPermanencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPermanencia_CellContentClick);
            // 
            // dtpFinal
            // 
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(390, 376);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(109, 20);
            this.dtpFinal.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "INICIAL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "FINAL:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(521, 364);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 44);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNIFPer
            // 
            this.txtNIFPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIFPer.Location = new System.Drawing.Point(117, 20);
            this.txtNIFPer.Mask = "########?";
            this.txtNIFPer.Name = "txtNIFPer";
            this.txtNIFPer.Size = new System.Drawing.Size(526, 116);
            this.txtNIFPer.TabIndex = 13;
            this.txtNIFPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(682, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(667, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Horas Totales:";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(679, 76);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(35, 13);
            this.lblHoras.TabIndex = 16;
            this.lblHoras.Text = "label4";
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.Width = 150;
            // 
            // Fichajeentrada
            // 
            this.Fichajeentrada.HeaderText = "Fichaje Entrada";
            this.Fichajeentrada.Name = "Fichajeentrada";
            this.Fichajeentrada.Width = 150;
            // 
            // fichajeSalida
            // 
            this.fichajeSalida.HeaderText = "Fichaje Salida";
            this.fichajeSalida.Name = "fichajeSalida";
            this.fichajeSalida.Width = 150;
            // 
            // horasTotales
            // 
            this.horasTotales.HeaderText = "Horas Totales";
            this.horasTotales.Name = "horasTotales";
            this.horasTotales.Width = 130;
            // 
            // FrmPermanencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtNIFPer);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.dtgvPermanencia);
            this.Controls.Add(this.dtpInicio);
            this.Name = "FrmPermanencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPermanencia";
            this.Load += new System.EventHandler(this.FrmPermanencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPermanencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DataGridView dtgvPermanencia;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.MaskedTextBox txtNIFPer;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fichajeentrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn fichajeSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasTotales;
    }
}