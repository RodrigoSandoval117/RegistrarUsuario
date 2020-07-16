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
    public partial class AltaUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuariosBO usuBO = new UsuariosBO();
            UsuarioDAO usuDAO = new UsuarioDAO();
            bool EnviarUsuario = true;

            usuBO.Activo = true;
            if (txtEdad.Text != "")
                usuBO.Edad = Convert.ToInt32(txtEdad.Text);
            if (txtCorreo.Text != "")
                usuBO.Email = txtCorreo.Text;
            else
            {
                obliEmail.Visible = true;
                EnviarUsuario = false;
            }
            if (txtEstado.Text != "")
                usuBO.Estado = txtEstado.Text;
            else
            {
                obliEstado.Visible = true;
                EnviarUsuario = false;
            }
            if (txtUsuario.Text != "")
                usuBO.Nombre = txtUsuario.Text;
            else
            {
                obliUsuario.Visible = true;
                EnviarUsuario = false;
            }
            if (chkAcepto.Checked == true)
                usuBO.Privacidad = chkAcepto.Checked;
            else
            {
                EnviarUsuario = false;
                obliCheck.Visible = true;
            }
            usuBO.Telefono = txtTelefono.Text;
            usuBO.FechaCreacion = DateTime.Now.Date;

            if (EnviarUsuario == true)
            {
                usuDAO.Save(usuBO);
                txtEdad.Text = "";
                txtCorreo.Text = "";
                txtEstado.Text = "";
                txtUsuario.Text = "";
                txtTelefono.Text = "";
                chkAcepto.Checked = false;
                obliCheck.Visible = false;
                obliEstado.Visible = false;
                obliUsuario.Visible = false;
                obliEmail.Visible = false;
            }
        }
    }
}