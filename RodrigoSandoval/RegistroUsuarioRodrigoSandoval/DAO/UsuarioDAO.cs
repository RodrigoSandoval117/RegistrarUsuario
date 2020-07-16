using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using RegistroUsuarioRodrigoSandoval.BO;
using System.Data;

namespace RegistroUsuarioRodrigoSandoval.DAO
{
    public class UsuarioDAO
    {
        protected SqlConnection conn;
        Conexion conexion = new Conexion();
        public UsuarioDAO()
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
            catch(Exception ex)
            {
                cmd.Connection.Close();
                return resultado;
            }
        }
        public int Save(UsuariosBO obj)
        {
            string insert = "INSERT INTO Usuarios(Nombre,Email,Estado,Edad,Telefono,Privacidad,Activo,FechaCreacion) " +
                "VALUES(@Nombre,@Email,@Estado,@Edad,@Telefono,@Privacidad,@Activo,@FechaCreacion)";
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@Estado", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@Edad", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@Privacidad", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@Activo", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@FechaCreacion", SqlDbType.Date));

            cmd.Parameters["@Nombre"].Value = obj.Nombre;
            cmd.Parameters["@Email"].Value = obj.Email;
            cmd.Parameters["@Estado"].Value = obj.Estado;
            cmd.Parameters["@Edad"].Value = obj.Edad;
            cmd.Parameters["@Telefono"].Value = obj.Telefono;
            cmd.Parameters["@Privacidad"].Value = obj.Privacidad;
            cmd.Parameters["@Activo"].Value = obj.Activo;
            cmd.Parameters["@FechaCreacion"].Value = obj.FechaCreacion;
            return EjecutarSQL(cmd);
        }
        public DataTable Select()
        {
            string qlistado = "";
            
            qlistado = "SELECT * FROM Usuarios";

            SqlDataAdapter dalistado = new SqlDataAdapter(qlistado, conn);
            DataTable dtlistado = new DataTable();
            dalistado.Fill(dtlistado);
            return dtlistado;
        }
    }
}