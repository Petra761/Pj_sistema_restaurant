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
    public partial class Form3 : Form
    {
        private Usuario usuarioLogeado;
        public Form3(Usuario usurio)
        {
            InitializeComponent();

            txtusuario.Text = usurio.NombreUsuario;
            usuarioLogeado = usurio;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAperturarcaja_Click(object sender, EventArgs e)
        {
            string saldoinicialtxt = txtmontoInicial.Text;

            string nombreUsuario = txtusuario.Text;
            string contrasena = txtcontraseña.Text;
            decimal saldoInicial = decimal.Parse(saldoinicialtxt);

            Caja cajaAperturada = new Caja(saldoInicial,usuarioLogeado.Id);
            if (usuarioLogeado.VerificarContrasena(contrasena))
            {
                cajaAperturada.AbrirCaja();
                Form2 menu = new Form2(usuarioLogeado, cajaAperturada);
                menu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
