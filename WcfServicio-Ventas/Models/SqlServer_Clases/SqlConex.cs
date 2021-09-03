using System;
using System.Configuration;
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
            ConnectionStringSettings cad = ConfigurationManager.ConnectionStrings["Micon"];
            Conexion = new SqlConnection(cad.ConnectionString);
           
        }

    }
}