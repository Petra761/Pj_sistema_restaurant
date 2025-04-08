namespace Proyecto_Valor_Ant
{
    partial class Form3
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
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtmontoInicial = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.btnAperturarcaja = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(307, 86);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.ReadOnly = true;
            this.txtusuario.Size = new System.Drawing.Size(239, 22);
            this.txtusuario.TabIndex = 0;
            this.txtusuario.TextChanged += new System.EventHandler(this.txtusuario_TextChanged);
            // 
            // txtmontoInicial
            // 
            this.txtmontoInicial.Location = new System.Drawing.Point(307, 114);
            this.txtmontoInicial.Name = "txtmontoInicial";
            this.txtmontoInicial.Size = new System.Drawing.Size(239, 22);
            this.txtmontoInicial.TabIndex = 1;
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(307, 142);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(239, 22);
            this.txtcontraseña.TabIndex = 2;
            this.txtcontraseña.TextChanged += new System.EventHandler(this.txtcontraseña_TextChanged);
            // 
            // btnAperturarcaja
            // 
            this.btnAperturarcaja.Location = new System.Drawing.Point(326, 236);
            this.btnAperturarcaja.Name = "btnAperturarcaja";
            this.btnAperturarcaja.Size = new System.Drawing.Size(134, 70);
            this.btnAperturarcaja.TabIndex = 3;
            this.btnAperturarcaja.Text = "Aperturar caja";
            this.btnAperturarcaja.UseVisualStyleBackColor = true;
            this.btnAperturarcaja.Click += new System.EventHandler(this.btnAperturarcaja_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Monto Inicial";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirmar contrasena";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAperturarcaja);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.txtmontoInicial);
            this.Controls.Add(this.txtusuario);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtmontoInicial;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Button btnAperturarcaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}