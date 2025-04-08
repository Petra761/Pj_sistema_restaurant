using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Valor_Ant.Conexiones_DB;
using Proyecto_Valor_Ant.Datos;

namespace Proyecto_Valor_Ant
{
    public partial class gestionarUserform : Form
    {
        public gestionarUserform()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = usuariotxt.Text;
            string contrasena = contratxt.Text;
            string rol = cmboxrol.SelectedItem.ToString();
            string sueldoPorJornadatxt = sueldotxt.Text;
            decimal sueldoPorJornada = decimal.Parse(sueldoPorJornadatxt);
            string personaIdtxt = persona_idtxt.Text;
            int personaId = int.Parse(personaIdtxt);
            string horarIdtxt = horarioidtxt.Text;
            int horarioId = int.Parse(horarIdtxt);

            bool resultado = Usuario.CrearUsuario(nombreUsuario, contrasena, rol, sueldoPorJornada, personaId, horarioId);
            if (resultado)
            {
                LimpiarCamposFormulario();
            }
        }
        private void LimpiarCamposFormulario()
        {
            idtxt.Text = string.Empty;
            usuariotxt.Text = string.Empty;
            contratxt.Text = string.Empty;
            sueldotxt.Text = string.Empty;
            persona_idtxt.Text = string.Empty;
            horarioidtxt.Text = string.Empty;
            cmboxrol.SelectedIndex = -1;
        }

        private void gestionarUserform_Load(object sender, EventArgs e)
        {
            string tableName = "HORARIO";
            string sql = "SELECT * FROM HORARIO";
            DataTable dataTable = new Conexion_DataBase().ObtenerDataTable(tableName, sql);
            datagridhorarios.DataSource = dataTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnpersona_Click(object sender, EventArgs e)
        {
            string tableName = "PERSONA";
            string sql = "SELECT * FROM PERSONA";
            DataTable dataTable = new Conexion_DataBase().ObtenerDataTable(tableName, sql);
            datagridUsers.DataSource = dataTable;
        }

        private void btnusuario_Click(object sender, EventArgs e)
        {
            string tableName = "USUARIO";
            string sql = "SELECT * FROM USUARIO";
            DataTable dataTable = new Conexion_DataBase().ObtenerDataTable(tableName, sql);
            datagridUsers.DataSource = dataTable;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string id_txt = idtxt.Text;
            int id = int.Parse(id_txt);
            string nombreUsuario = usuariotxt.Text;
            string contrasena = contratxt.Text;
            string rol = cmboxrol.SelectedItem.ToString();
            string sueldoPorJornadatxt = sueldotxt.Text;
            decimal sueldoPorJornada = decimal.Parse(sueldoPorJornadatxt);
            string personaIdtxt = persona_idtxt.Text;
            int personaId = int.Parse(personaIdtxt);
            string horarIdtxt = horarioidtxt.Text;
            int horarioId = int.Parse(horarIdtxt);

            bool resultado = Usuario.ModificarUsuario(id, nombreUsuario, contrasena, rol, sueldoPorJornada, personaId, horarioId);
            if (resultado)
            {
                LimpiarCamposFormulario();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id_txt = idtxt.Text;
            int id = int.Parse(id_txt);

            bool resultado = Usuario.EliminarUsuario(id);
            if (resultado)
            {
                LimpiarCamposFormulario();
            }
        }
    }
}
