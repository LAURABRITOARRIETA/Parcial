using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Connection
    {
        protected OracleConnection conexion;
        public Connection(string connectionString)
        {
            conexion = new OracleConnection(connectionString);
        }
        public void Open()
        {
            conexion.Open();
        }
        public void Close()
        {
            conexion.Close();
        }
    }
}
