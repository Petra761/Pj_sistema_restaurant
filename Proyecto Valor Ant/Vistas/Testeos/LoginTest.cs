using Proyecto_Valor_Ant.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Valor_Ant
{
    public partial class LoginTest : Form
    {
        public LoginTest()
        {
            MessageBox.Show("silencio putaaaaaaaaa");
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text;
            string contrasena = txtContraseña.Text;

            Usuario usuario = Usuario.IniciarSesion(nombreUsuario, contrasena);

            if (usuario != null)
            {
                Form2 FormMenu = new Form2(usuario,null);
                FormMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginTest_Load(object sender, EventArgs e)
        {

        }
    }
}
