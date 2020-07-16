using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RegistroUsuarioRodrigoSandoval.DAO;
using Microsoft.Office.Interop;
using System.IO;

namespace RegistroUsuarioRodrigoSandoval.GUI
{
    public partial class Dashboard : System.Web.UI.Page
    {
        UsuarioDAO objdao = new UsuarioDAO();

        protected void Page_Load(object sender, EventArgs e)
        {
            Select();
        }
        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            ExportGridToExcel();
        }
        private void Select()
        {
            gvProductos.DataSource = objdao.Select();
            gvProductos.DataBind();
            contador.Text = Convert.ToString(gvProductos.Rows.Count);
        }

        public override void VerifyRenderingInServerForm(Control control)
        {
            //required to avoid the runtime error "  
            //Control 'GridView1' of type 'GridView' must be placed inside a form tag with runat=server."  
        }

        private void ExportGridToExcel()
        {
            Response.Clear();
            Response.Buffer = true;
            Response.ClearContent();
            Response.ClearHeaders();
            Response.Charset = "";
            string FileName = "RegistroUsuario" + DateTime.Now.TimeOfDay + DateTime.Now.Minute + DateTime.Now.Second + ".xls";
            StringWriter strwritter = new StringWriter();
            HtmlTextWriter htmltextwrtter = new HtmlTextWriter(strwritter);
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("Content-Disposition", "attachment;filename=" + FileName);
            gvProductos.GridLines = GridLines.Both;
            gvProductos.HeaderStyle.Font.Bold = true;
            gvProductos.RenderControl(htmltextwrtter);
            Response.Write(strwritter.ToString());
            Response.End();

        }
    }
}