using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Proyecto_Valor_Ant.Conexiones_DB;

namespace Proyecto_Valor_Ant.Datos
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string ContrasenaHash { get; set; }
        public decimal SueldoJornada {  get; set; }
        public string Rol {  get; set; }
        public int PersonaId { get; set; }
        public int HorarioId { get; set; }
        public Usuario(int id, string nombreUsuario, string contrasenaHash, decimal sueldoJornada, string rol, int personaId, int horarioId)
        {
            Id = id;
            NombreUsuario = nombreUsuario;
            ContrasenaHash = HashPassword(contrasenaHash);
            SueldoJornada = sueldoJornada;
            Rol = rol;
            PersonaId = personaId;
            HorarioId = horarioId;
        }// este es para crear un usuario que trabajara con la abse de datos
        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2")); // Formato hexadecimal
                }
                return builder.ToString();
            }
        }// esto es para hashear las contrase;as, segun la ia es una buena practica hacer eso
        public bool VerificarContrasena(string password)
        {
            string hashIngresado = HashPassword(password);
            return ContrasenaHash == hashIngresado;
        }
        public static Usuario IniciarSesion(string nombreUsuario, string contrasena)
        {
            using (var conexion = new Conexion_DataBase().ObtenerConexion())
            {
                string sql = "SELECT id, nombreUsuario, contrasena, sueldoPorJornada, rol, persona_id, horario_id FROM usuario WHERE nombreUsuario = @nombreUsuario";
                using (var cmd = new NpgsqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string nombreUsuarioDB = reader.GetString(1);
                            string contrasenaHashDB = reader.GetString(2);
                            decimal sueldoJornada = reader.GetDecimal(3);
                            string rol = reader.GetString(4);
                            int personaId = reader.GetInt32(5);
                            int horarioId = reader.GetInt32(6);

                            Usuario usuario = new Usuario(id, nombreUsuarioDB, contrasenaHashDB, sueldoJornada, rol, personaId, horarioId);
                            if (usuario.VerificarContrasena(contrasena))
                            {
                                return usuario;
                            }
                            else
                            {
                                return null;
                            }
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
        public static bool CrearUsuario(string nombreUsuario, string contrasena, string rol, decimal sueldoPorJornada, int personaId, int horarioId)
        {
            using (var conexion = new Conexion_DataBase().ObtenerConexion())
            {
                string sql = "INSERT INTO usuario (nombreUsuario, contrasena, rol, sueldoPorJornada, persona_id, horario_id) VALUES (@nombreUsuario, @contrasena, @rol, @sueldoPorJornada, @persona_id, @horario_id)";
                using (var cmd = new NpgsqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);
                    cmd.Parameters.AddWithValue("@rol", rol);
                    cmd.Parameters.AddWithValue("@sueldoPorJornada", sueldoPorJornada);
                    cmd.Parameters.AddWithValue("@persona_id", personaId);
                    cmd.Parameters.AddWithValue("@horario_id", horarioId);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo insertar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    finally
                    {
                        if (conexion.State == ConnectionState.Open)
                        {
                            conexion.Close();
                        }
                    }
                }
            }
        }
        public static bool ModificarUsuario(int id, string nombreUsuario, string contrasena, string rol, decimal sueldoPorJornada, int personaId, int horarioId)
        {
            using (var conexion = new Conexion_DataBase().ObtenerConexion())
            {
                string sql = "UPDATE usuario SET nombreUsuario = @nombreUsuario, contrasena = @contrasena, rol = @rol, sueldoPorJornada = @sueldoPorJornada, persona_id = @persona_id, horario_id = @horario_id WHERE id = @id";
                using (var cmd = new NpgsqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);
                    cmd.Parameters.AddWithValue("@rol", rol);
                    cmd.Parameters.AddWithValue("@sueldoPorJornada", sueldoPorJornada);
                    cmd.Parameters.AddWithValue("@persona_id", personaId);
                    cmd.Parameters.AddWithValue("@horario_id", horarioId);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo modificar" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }
        public static bool EliminarUsuario(int id)
        {
            using (var conexion = new Conexion_DataBase().ObtenerConexion())
            {
                string sql = "DELETE FROM usuario WHERE id = @id";
                using (var cmd = new NpgsqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo insertar" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }
    }
}
