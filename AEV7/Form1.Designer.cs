namespace AEV7
{
    partial class Form1
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
            this.lblNIF = new System.Windows.Forms.Label();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.btnENTRADA = new System.Windows.Forms.Button();
            this.btnSALIDA = new System.Windows.Forms.Button();
            this.btnPRESENCIA = new System.Windows.Forms.Button();
            this.btnADMI = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.btnPermanencia = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIF.Location = new System.Drawing.Point(98, 126);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(52, 29);
            this.lblNIF.TabIndex = 0;
            this.lblNIF.Text = "NIF";
            // 
            // txtNIF
            // 
            this.txtNIF.Location = new System.Drawing.Point(203, 130);
            this.txtNIF.MaxLength = 9;
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(236, 27);
            this.txtNIF.TabIndex = 1;
            this.txtNIF.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnENTRADA
            // 
            this.btnENTRADA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnENTRADA.Location = new System.Drawing.Point(98, 247);
            this.btnENTRADA.Name = "btnENTRADA";
            this.btnENTRADA.Size = new System.Drawing.Size(131, 63);
            this.btnENTRADA.TabIndex = 2;
            this.btnENTRADA.Text = "Entrada";
            this.btnENTRADA.UseVisualStyleBackColor = true;
            this.btnENTRADA.Click += new System.EventHandler(this.btnENTRADA_Click);
            // 
            // btnSALIDA
            // 
            this.btnSALIDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSALIDA.Location = new System.Drawing.Point(290, 247);
            this.btnSALIDA.Name = "btnSALIDA";
            this.btnSALIDA.Size = new System.Drawing.Size(131, 63);
            this.btnSALIDA.TabIndex = 3;
            this.btnSALIDA.Text = "Salida";
            this.btnSALIDA.UseVisualStyleBackColor = true;
            this.btnSALIDA.Click += new System.EventHandler(this.btnSALIDA_Click);
            // 
            // btnPRESENCIA
            // 
            this.btnPRESENCIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPRESENCIA.Location = new System.Drawing.Point(481, 247);
            this.btnPRESENCIA.Name = "btnPRESENCIA";
            this.btnPRESENCIA.Size = new System.Drawing.Size(131, 63);
            this.btnPRESENCIA.TabIndex = 4;
            this.btnPRESENCIA.Text = "Presencia";
            this.btnPRESENCIA.UseVisualStyleBackColor = true;
            this.btnPRESENCIA.Click += new System.EventHandler(this.btnPRESENCIA_Click);
            // 
            // btnADMI
            // 
            this.btnADMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADMI.Location = new System.Drawing.Point(661, 247);
            this.btnADMI.Name = "btnADMI";
            this.btnADMI.Size = new System.Drawing.Size(157, 63);
            this.btnADMI.TabIndex = 5;
            this.btnADMI.Text = "Administrar";
            this.btnADMI.UseVisualStyleBackColor = true;
            this.btnADMI.Click += new System.EventHandler(this.btnADMI_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(656, 126);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(106, 29);
            this.time.TabIndex = 6;
            this.time.Text = "TIEMPO";
            // 
            // btnPermanencia
            // 
            this.btnPermanencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermanencia.Location = new System.Drawing.Point(871, 247);
            this.btnPermanencia.Name = "btnPermanencia";
            this.btnPermanencia.Size = new System.Drawing.Size(165, 63);
            this.btnPermanencia.TabIndex = 7;
            this.btnPermanencia.Text = "Permanencia";
            this.btnPermanencia.UseVisualStyleBackColor = true;
            this.btnPermanencia.Click += new System.EventHandler(this.btnPermanencia_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 633);
            this.ControlBox = false;
            this.Controls.Add(this.btnPermanencia);
            this.Controls.Add(this.time);
            this.Controls.Add(this.btnADMI);
            this.Controls.Add(this.btnPRESENCIA);
            this.Controls.Add(this.btnSALIDA);
            this.Controls.Add(this.btnENTRADA);
            this.Controls.Add(this.txtNIF);
            this.Controls.Add(this.lblNIF);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Fichar entrada o salida";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNIF;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.Button btnENTRADA;
        private System.Windows.Forms.Button btnSALIDA;
        private System.Windows.Forms.Button btnPRESENCIA;
        private System.Windows.Forms.Button btnADMI;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Button btnPermanencia;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

