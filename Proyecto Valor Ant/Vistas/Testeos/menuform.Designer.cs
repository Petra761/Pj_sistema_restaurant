namespace Proyecto_Valor_Ant
{
    partial class Form2
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
            this.buttonAbrircaja = new System.Windows.Forms.Button();
            this.btnCerrarCaja = new System.Windows.Forms.Button();
            this.btnGestionUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAbrircaja
            // 
            this.buttonAbrircaja.Location = new System.Drawing.Point(33, 23);
            this.buttonAbrircaja.Name = "buttonAbrircaja";
            this.buttonAbrircaja.Size = new System.Drawing.Size(222, 112);
            this.buttonAbrircaja.TabIndex = 2;
            this.buttonAbrircaja.Text = "abrir caja";
            this.buttonAbrircaja.UseVisualStyleBackColor = true;
            this.buttonAbrircaja.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnCerrarCaja
            // 
            this.btnCerrarCaja.Location = new System.Drawing.Point(33, 163);
            this.btnCerrarCaja.Name = "btnCerrarCaja";
            this.btnCerrarCaja.Size = new System.Drawing.Size(222, 112);
            this.btnCerrarCaja.TabIndex = 3;
            this.btnCerrarCaja.Text = "cerrar caja";
            this.btnCerrarCaja.UseVisualStyleBackColor = true;
            this.btnCerrarCaja.Click += new System.EventHandler(this.btnCerrarCaja_Click);
            // 
            // btnGestionUser
            // 
            this.btnGestionUser.Location = new System.Drawing.Point(33, 293);
            this.btnGestionUser.Name = "btnGestionUser";
            this.btnGestionUser.Size = new System.Drawing.Size(222, 112);
            this.btnGestionUser.TabIndex = 4;
            this.btnGestionUser.Text = "Gestionar Usuario";
            this.btnGestionUser.UseVisualStyleBackColor = true;
            this.btnGestionUser.Click += new System.EventHandler(this.btnGestionUser_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 466);
            this.Controls.Add(this.btnGestionUser);
            this.Controls.Add(this.btnCerrarCaja);
            this.Controls.Add(this.buttonAbrircaja);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAbrircaja;
        private System.Windows.Forms.Button btnCerrarCaja;
        private System.Windows.Forms.Button btnGestionUser;
    }
}