using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SUSS2016.CLASES;

namespace WEBGUI
{
    public partial class alumnoCatalogoProgramas : System.Web.UI.Page
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
    }
}