using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Proyecto_Valor_Ant.Conexiones_DB
{
    public class Conexion_DataBase
    {
        static readonly String server = "localhost";
        static readonly String db = "PRACTICE";
        static readonly String user = "postgres";
        static readonly String password = "1234";
        static readonly String puerto = "5432";

        static readonly String cadConexion = $"Host={server};Database={db};Username={user};Password={password};Port={puerto}";

        public NpgsqlConnection ObtenerConexion()
        {
            NpgsqlConnection conexion = new NpgsqlConnection(cadConexion);
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al conectar: {ex.Message}",ex);
            }
        }
        public DataTable ObtenerDataTable(string tableName, string sql)
        {
            DataTable dataTable = new DataTable();
            using (var conexion = new Conexion_DataBase().ObtenerConexion())
            {
                using (var cmd = new NpgsqlCommand(sql, conexion))
                {
                    try
                    {
                        using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(cmd))
                        {
                            dataAdapter.Fill(dataTable);
                        }
                        return dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al obtener datos de la tabla '{tableName}': {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
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
    }
}
