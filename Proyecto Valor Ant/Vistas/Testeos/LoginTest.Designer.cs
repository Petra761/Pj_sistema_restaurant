namespace Proyecto_Valor_Ant
{
    partial class LoginTest
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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(109, 52);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(238, 22);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Text = "juan.perez";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(109, 94);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(238, 22);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.Text = "clave123";
            this.txtContraseña.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(151, 165);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(146, 23);
            this.Login.TabIndex = 2;
            this.Login.Text = "Iniciar Sesion";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // LoginTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 259);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Name = "LoginTest";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.LoginTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button Login;
    }
}