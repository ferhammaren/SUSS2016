using SUSS2016.CLASES;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEBGUI
{
    public partial class alumnoReporte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label nameLabel = (Label)Master.FindControl("lbNombre");
            //  System.Diagnostics.Debug.WriteLine(Session["UsuarioId"].ToString());
            if (Session["UsuarioId"] != null)
            {
                Alumnos.getInfoAlumno(Convert.ToInt32(Session["UsuarioId"].ToString()));

                nameLabel.Text = Alumnos.getNombre();
            }
            else
            {
                Literal ltr = new Literal();
                ltr.Text = @"<script type='text/javascript'> alert('No iniciaste sesión') </script>";
                this.Controls.Add(ltr);
                Response.Redirect("~/index.aspx");
            }
        }

        protected void subirReporte_Click(object sender, EventArgs e)
        {
            string[] extensiones = { ".doc", ".docx", ".pdf" };
            if (elegirReporte.HasFile && (extensiones.Contains(Path.GetExtension(elegirReporte.PostedFile.FileName))))
            {
                try
                {
                  //  string 
                  //  elegirReporte.SaveAs(Server.MapPath("~/") + filename);
                }catch(Exception ex)
                {
                   
                }
            }
        }
    }
}