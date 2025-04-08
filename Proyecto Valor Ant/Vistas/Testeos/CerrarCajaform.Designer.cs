namespace Proyecto_Valor_Ant
{
    partial class CerrarCajaform
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrarcaja = new System.Windows.Forms.Button();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.txtmontoInicial = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMontoFinal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Confirmar contrasena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Monto Inicial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Usuario";
            // 
            // btnCerrarcaja
            // 
            this.btnCerrarcaja.Location = new System.Drawing.Point(328, 259);
            this.btnCerrarcaja.Name = "btnCerrarcaja";
            this.btnCerrarcaja.Size = new System.Drawing.Size(134, 70);
            this.btnCerrarcaja.TabIndex = 10;
            this.btnCerrarcaja.Text = "Cerrar caja";
            this.btnCerrarcaja.UseVisualStyleBackColor = true;
            this.btnCerrarcaja.Click += new System.EventHandler(this.btnCerrarcaja_Click);
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(309, 193);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(239, 22);
            this.txtcontraseña.TabIndex = 9;
            // 
            // txtmontoInicial
            // 
            this.txtmontoInicial.Location = new System.Drawing.Point(309, 137);
            this.txtmontoInicial.Name = "txtmontoInicial";
            this.txtmontoInicial.ReadOnly = true;
            this.txtmontoInicial.Size = new System.Drawing.Size(239, 22);
            this.txtmontoInicial.TabIndex = 8;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(309, 109);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.ReadOnly = true;
            this.txtusuario.Size = new System.Drawing.Size(239, 22);
            this.txtusuario.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Monto Final";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtMontoFinal
            // 
            this.txtMontoFinal.Location = new System.Drawing.Point(309, 165);
            this.txtMontoFinal.Name = "txtMontoFinal";
            this.txtMontoFinal.ReadOnly = true;
            this.txtMontoFinal.Size = new System.Drawing.Size(239, 22);
            this.txtMontoFinal.TabIndex = 14;
            // 
            // CerrarCajaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMontoFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrarcaja);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.txtmontoInicial);
            this.Controls.Add(this.txtusuario);
            this.Name = "CerrarCajaform";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.CerrarCajaform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrarcaja;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.TextBox txtmontoInicial;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMontoFinal;
    }
}