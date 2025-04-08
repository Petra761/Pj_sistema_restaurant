using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Proyecto_Valor_Ant.Conexiones_DB;

namespace Proyecto_Valor_Ant.Datos
{
    public class Caja
    {
        public int Id { get;private set; }
        public decimal SaldoInicial { get; private set; }
        public decimal? SaldoFinal { get; private set; } // puse el ? para que pueda aceptar nulos hasta que cerremos la caja
        public DateTime HoraApertura { get; private set; }
        public DateTime? HoraCierre { get; private set; } // puse el ? para que pueda aceptar nulos hasta que cerremos la caja
        public DateTime Fecha { get; private set; }
        public int UsuarioId { get; private set; }
        public bool Estado { get; private set; }

        public Caja(decimal saldoInicial, int usuarioId) // este es el contructor
        {
            if (saldoInicial < 0)
            {
                throw new ArgumentException("El saldo inicial no puede ser negativo.");
            }
            SaldoInicial = saldoInicial;
            SaldoFinal = saldoInicial;
            HoraApertura = DateTime.Now;
            HoraCierre = null;
            Fecha = DateTime.Today;
            UsuarioId = usuarioId;
            Estado = true;
        }
        public void AbrirCaja()
        {
            using (var conexion = new Conexion_DataBase().ObtenerConexion())
            {
                string sql = "INSERT INTO caja (saldoInicial, horaApertura, fecha, usuario_id, saldoFinal, horaCierre) " +
                               "VALUES (@saldoInicial, @horaApertura, @fecha, @usuario_id, NULL, NULL) RETURNING id";
                using (var cmd = new NpgsqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@saldoInicial", SaldoInicial);
                    cmd.Parameters.AddWithValue("@horaApertura", HoraApertura);
                    cmd.Parameters.AddWithValue("@fecha", Fecha);
                    cmd.Parameters.AddWithValue("@usuario_id", UsuarioId);

                    Id = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
        public void ActualizarSaldoFinal(decimal monto)
        {
            if (SaldoFinal == null)
            {
                SaldoFinal = monto;
            }
            else
            {
                SaldoFinal += monto;
            }
        }
        public void CerrarCaja(decimal saldoFinal)
        {
            DateTime horaCierre = DateTime.Now;
            using (var conexion = new Conexion_DataBase().ObtenerConexion())
            {

                string sql = "UPDATE caja SET saldoFinal = @saldoFinal, horaCierre = @horaCierre WHERE id = @id";
                using (var cmd = new NpgsqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@saldoFinal", saldoFinal);
                    cmd.Parameters.AddWithValue("@horaCierre", horaCierre);
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.ExecuteNonQuery();
                }
                HoraCierre = horaCierre;
                Estado = false;
            }
        }
    }
}
