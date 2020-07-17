using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RegistroUsuarioRodrigoSandoval.DAO
{
    public class Conexion
    {
        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(@"data source = 34.71.231.215; initial catalog = RegistroUsuario; user id = sqlserver; password = 123456");
        }
    }
}