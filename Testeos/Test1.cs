using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto_Valor_Ant.Datos;
using Proyecto_Valor_Ant.Conexiones_DB;
using System;
using Npgsql;

namespace Proyecto_Valor_Ant.Testeos
{
    [TestClass]
    public class ConexionDBTest
    {
        [TestMethod]
        public void ObtenerConexion_ConexionExitosa()
        {
            Conexion_DataBase conexionDataBase = new Conexion_DataBase();

            NpgsqlConnection conexion = conexionDataBase.ObtenerConexion();

            Assert.IsNotNull(conexion);
            Assert.AreEqual(System.Data.ConnectionState.Open, conexion.State);

            conexion.Close();
        }
    }
}