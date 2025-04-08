using Npgsql;
using Proyecto_Valor_Ant.Conexiones_DB;
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
    public partial class Form2 : Form
    {
        private Usuario usuarioLogeado;
        private Caja cajaAperturada;

        public Form2(Usuario usuario, Caja caja)
        {
            InitializeComponent();
            usuarioLogeado = usuario;
            cajaAperturada = caja;
        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conexion = new Conexion_DataBase().ObtenerConexion())
                {
                    if (conexion.State == System.Data.ConnectionState.Open)
                    {
                        MessageBox.Show("Conexión exitosa a la base de datos!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo conectar a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Error al conectar a la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginTest formLogin = new LoginTest();
            this.Hide();
            formLogin.ShowDialog();
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (cajaAperturada == null)
            {
                Form3 cajaform = new Form3(usuarioLogeado);
                this.Close();
                cajaform.Show();
            }
            else
            {
                MessageBox.Show("Ya existe una caja aperturada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {
            cajaAperturada.ActualizarSaldoFinal(45);
            if (cajaAperturada == null)
            {
                MessageBox.Show("Ya existe una caja aperturada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CerrarCajaform cajaform = new CerrarCajaform(usuarioLogeado,cajaAperturada);
                this.Close();
                cajaform.Show();
            }
        }

        private void btnGestionUser_Click(object sender, EventArgs e)
        {
            gestionarUserform gestionform = new gestionarUserform();
            this.Hide();
            gestionform.ShowDialog();
            this.Show();
        }
    }
}
