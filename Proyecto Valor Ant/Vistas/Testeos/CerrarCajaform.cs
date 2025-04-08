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
    public partial class CerrarCajaform : Form
    {
        private Usuario usuarioLogeado;
        private Caja cajaAperturada;
        public CerrarCajaform(Usuario usuario,Caja caja)
        {
            usuarioLogeado = usuario;
            cajaAperturada = caja;
            InitializeComponent();

            txtusuario.Text = usuarioLogeado.NombreUsuario;
            txtmontoInicial.Text = cajaAperturada.SaldoInicial.ToString();
            txtMontoFinal.Text = cajaAperturada.SaldoFinal.ToString();
        }

        private void CerrarCajaform_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarcaja_Click(object sender, EventArgs e)
        {
            string contrasena = txtcontraseña.Text;
            string saldofinaltxt = txtMontoFinal.Text;
            decimal saldofinal = decimal.Parse(saldofinaltxt);

            if (usuarioLogeado.VerificarContrasena(contrasena))
            {
                cajaAperturada.CerrarCaja(saldofinal);                                                     
                Form2 menu = new Form2(usuarioLogeado, null);
                menu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
