
namespace AEV7
{
    partial class FrmContrasenya
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
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.txtContrasenya = new System.Windows.Forms.TextBox();
            this.btnEntrarAdmin = new System.Windows.Forms.Button();
            this.lblNIF = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNIF
            // 
            this.txtNIF.Location = new System.Drawing.Point(126, 41);
            this.txtNIF.MaxLength = 9;
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(157, 20);
            this.txtNIF.TabIndex = 0;
            this.txtNIF.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtContrasenya
            // 
            this.txtContrasenya.Location = new System.Drawing.Point(126, 77);
            this.txtContrasenya.Name = "txtContrasenya";
            this.txtContrasenya.Size = new System.Drawing.Size(157, 20);
            this.txtContrasenya.TabIndex = 1;
            // 
            // btnEntrarAdmin
            // 
            this.btnEntrarAdmin.Location = new System.Drawing.Point(160, 122);
            this.btnEntrarAdmin.Name = "btnEntrarAdmin";
            this.btnEntrarAdmin.Size = new System.Drawing.Size(82, 28);
            this.btnEntrarAdmin.TabIndex = 2;
            this.btnEntrarAdmin.Text = "Entrar";
            this.btnEntrarAdmin.UseVisualStyleBackColor = true;
            this.btnEntrarAdmin.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIF.Location = new System.Drawing.Point(81, 41);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(39, 20);
            this.lblNIF.TabIndex = 3;
            this.lblNIF.Text = "NIF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Contraseña:";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(72, 122);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(82, 28);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmContrasenya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 174);
            this.ControlBox = false;
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNIF);
            this.Controls.Add(this.btnEntrarAdmin);
            this.Controls.Add(this.txtContrasenya);
            this.Controls.Add(this.txtNIF);
            this.Name = "FrmContrasenya";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmContrasenya";
            this.Load += new System.EventHandler(this.FrmContrasenya_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.TextBox txtContrasenya;
        private System.Windows.Forms.Button btnEntrarAdmin;
        private System.Windows.Forms.Label lblNIF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolver;
    }
}