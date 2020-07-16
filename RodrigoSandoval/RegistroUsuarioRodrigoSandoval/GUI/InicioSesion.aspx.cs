using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RegistroUsuarioRodrigoSandoval.BO;
using RegistroUsuarioRodrigoSandoval.DAO;

namespace RegistroUsuarioRodrigoSandoval.GUI
{
    public partial class InicioSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void Loguear()
        {
            InicioSesionBO obj = new InicioSesionBO();
            InicioSesionDAO objDao = new InicioSesionDAO();
            obj.Usuario = txtUsuario.Text;
            obj.Contrasena = txtContrasenia.Text;
            bool logueado = objDao.IniciarSesion(obj);
            if (logueado)
            {
                Response.Redirect("MenuPrincipal.aspx");
            }
        }
        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Loguear();
        }
    }
}