using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace Data.Database
{
    public class Adapter
    {
        //private SqlConnection sqlConnection = new SqlConnection("ConnectionString;");
        //Clave por defecto a utlizar para la cadena de conexion
        const string consKeyDefaultCnnString = "ConnStringExpress";
        private SqlConnection _sqlConn;
        public SqlConnection sqlConn
        {
            get => this._sqlConn;
            set => this._sqlConn = value;
        }
        protected void OpenConnection()
        {
            String conn = ConfigurationManager.ConnectionStrings[consKeyDefaultCnnString].ConnectionString;
            //throw new Exception("Metodo no implementado");
            sqlConn = new SqlConnection(conn);
            sqlConn.Open();
        }

        protected void CloseConnection()
        {
            //throw new Exception("Metodo no implementado");
            sqlConn.Close();
            sqlConn = null;
        }

        protected SqlDataReader ExecuteReader(String commandText)
        {
            throw new Exception("Metodo no implementado");
        }
    }
}
