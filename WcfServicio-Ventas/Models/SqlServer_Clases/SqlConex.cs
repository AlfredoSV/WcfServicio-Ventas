using System;
using System.Data.SqlClient;

namespace WcfServicio_Ventas.Models.SqlServer_Clases
{
    public class SqlConex
    {
        private SqlConnection _con;

        public SqlConnection Conexion {
            get { return _con; }
            set {_con = value; } }

        public SqlConex()
        {
            string cad = @"Server=ALFREDO\ALFREDO;database=Ventas;Trusted_Connection=True";
            Conexion = new SqlConnection(cad);
           
        }

    }
}