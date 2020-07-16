using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using RegistroUsuarioRodrigoSandoval.BO;
using System.Data;

namespace RegistroUsuarioRodrigoSandoval.DAO
{
    public class InicioSesionDAO
    {
        protected SqlConnection conn;
        Conexion conexion = new Conexion();
        public InicioSesionDAO()
        {
            conn = conexion.ObtenerConexion();
        }
        public int EjecutarSQL(SqlCommand cmd)
        {
            int resultado = 0;
            try
            {
                cmd.Connection.Open();
                resultado = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return resultado;
            }
            catch
            {
                cmd.Connection.Close();
                return resultado;
            }
        }

        public bool IniciarSesion(InicioSesionBO usu)
        {
            bool UsuarioCorrecto = false;
            string qlistado;

            qlistado = "SELECT * FROM InicioSesion where Usuario = '" + usu.Usuario + "' AND Contrasena = '" + usu.Contrasena + "'";
            
            SqlDataAdapter dalistado = new SqlDataAdapter(qlistado, conn);
            DataTable dtlistado = new DataTable();
            dalistado.Fill(dtlistado);

            try
            {
                if (dtlistado.Rows.Count == 1)
                    
                    UsuarioCorrecto = true;
            }
            catch (Exception ex)
            { }

            return UsuarioCorrecto;
        }
    }
}