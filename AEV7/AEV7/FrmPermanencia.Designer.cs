
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
            this.dtpPrimeraFecha = new System.Windows.Forms.DateTimePicker();
            this.dtpUltimaFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpPrimeraFecha
            // 
            this.dtpPrimeraFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPrimeraFecha.Location = new System.Drawing.Point(134, 39);
            this.dtpPrimeraFecha.Name = "dtpPrimeraFecha";
            this.dtpPrimeraFecha.Size = new System.Drawing.Size(86, 20);
            this.dtpPrimeraFecha.TabIndex = 0;
            // 
            // dtpUltimaFecha
            // 
            this.dtpUltimaFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUltimaFecha.Location = new System.Drawing.Point(134, 84);
            this.dtpUltimaFecha.Name = "dtpUltimaFecha";
            this.dtpUltimaFecha.Size = new System.Drawing.Size(86, 20);
            this.dtpUltimaFecha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Primera Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Segunda Fecha:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(75, 132);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(119, 56);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(75, 194);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 56);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmPermanencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 273);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpUltimaFecha);
            this.Controls.Add(this.dtpPrimeraFecha);
            this.Name = "FrmPermanencia";
            this.Text = "FrmPermanencia";
            this.Load += new System.EventHandler(this.FrmPermanencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpPrimeraFecha;
        private System.Windows.Forms.DateTimePicker dtpUltimaFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnCancelar;
    }
}