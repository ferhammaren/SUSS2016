using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Clases;
using SUSS2016.CLASES;
using System.IO;

namespace WEBGUI
{
    public partial class alumnoReporte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label nameLabel = (Label)Master.FindControl("lbNombre");
            //System.Diagnostics.Debug.WriteLine(Session["UsuarioId"].ToString());
            if (Session["UsuarioId"] != null)
            {
                Alumnos.getInfoAlumno(Convert.ToInt32(Session["UsuarioId"].ToString()));
                nameLabel.Text = Alumnos.getNombre();
            }
            else
            {
                Literal ltr = new Literal();
                //send not logged in message
                ltr.Text = @"<script type='text/javascript'> alert('No has iniciado sesión') </script>";
                this.Controls.Add(ltr);
                Response.Redirect("~/index.aspx");
            }


        }

        protected void subirReporte_Click(object sender, EventArgs e)
        {
            string[] extensiones = new string[] { ".docx", ".doc", ".pdf" };
            if (eligeReporte.HasFile && extensiones.Contains(Path.GetExtension(eligeReporte.PostedFile.FileName)))
            {
                try
                {
                    string nombreArchivo = Path.GetFileName(eligeReporte.FileName);
                    eligeReporte.SaveAs(Server.MapPath("/localhost/") + nombreArchivo); 
                    System.Diagnostics.Debug.WriteLine("Tu muy bien!");
                    //Console.WriteLine("Tu muy bien!");
                }
                catch (Exception ex)
                {
                    //Console.Write("AYYYY");
                    System.Diagnostics.Debug.WriteLine("AYYY");
                }
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("AYYYLMAOOOOOOOO");
            }
        }
    }
}