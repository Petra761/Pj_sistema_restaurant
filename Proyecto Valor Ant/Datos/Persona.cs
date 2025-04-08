using Npgsql;
using Proyecto_Valor_Ant.Conexiones_DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Valor_Ant.Datos
{
    public class Persona
    {
        int id;
        string nombre;
        string apPaterno;
        string apMaterno;
        DateTime fecNacimiento;
        string sexo;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string ApPaterno
        {
            get { return apPaterno; }
            set { apPaterno = value; }
        }

        public string ApMaterno
        {
            get { return apMaterno; }
            set { apMaterno = value; }
        }

        public DateTime FecNacimiento
        {
            get { return fecNacimiento; }
            set { fecNacimiento = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }

        }





        public void Insertar()
        {
            using (var conexion = new Conexion_DataBase().ObtenerConexion())
            {
                string query = "INSERT INTO persona (nombre, apellido_paterno, apellido_materno, fec_nacimiento, sexo) VALUES (@nombre, @apPaterno, @apMaterno, @fecNacimiento, @sexo)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", this.nombre);
                    cmd.Parameters.AddWithValue("@apPaterno", this.apPaterno);
                    cmd.Parameters.AddWithValue("@apMaterno", this.apMaterno);
                    cmd.Parameters.AddWithValue("@fecNacimiento", this.fecNacimiento);
                    cmd.Parameters.AddWithValue("@sexo", this.sexo);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool Modificar()
        {
            bool resultado = false;
            try
            {
                string query = "UPDATE persona SET nombre = @nombre, apellido_paterno = @apPaterno, apellido_materno = @apMaterno, fec_nacimiento = @fecNacimiento, sexo = @sexo WHERE id = @id";
                using (var conexion = new Conexion_DataBase().ObtenerConexion())
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@id", this.id);
                        cmd.Parameters.AddWithValue("@nombre", this.nombre);
                        cmd.Parameters.AddWithValue("@apPaterno", this.apPaterno);
                        cmd.Parameters.AddWithValue("@apMaterno", this.apMaterno);
                        cmd.Parameters.AddWithValue("@fecNacimiento", this.fecNacimiento);
                        cmd.Parameters.AddWithValue("@sexo", this.sexo);
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        resultado = filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al modificar cliente: " + ex.Message);

            }
            return resultado;

        }

        public bool Eliminar()
        {
            bool resultado = false;
            try
            {
                string query = "DELETE FROM persona WHERE id = @id";
                using (var conexion = new Conexion_DataBase().ObtenerConexion())
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@id", this.id);
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        resultado = filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar persona: " + ex.Message);
            }
            return resultado;
        }






    }

}
